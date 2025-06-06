using Microsoft.Extensions.Configuration;
using AppSettingsValidator.Models;
using AppSettingsValidator.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace AppSettingsValidator
{
    public class ConfigurationValidator
    {
        private readonly IConfiguration _configuration;
        private readonly List<ValidationRule> _validationRules;

        public ConfigurationValidator(IConfiguration configuration)
        {
            _configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
            _validationRules = new List<ValidationRule>();
        }

        public void AddRule(ValidationRule rule)
        {
            if (rule == null)
                throw new ArgumentNullException(nameof(rule));

            _validationRules.Add(rule);
        }

        public void AddRulesFromAttributes<T>() where T : class
        {
            var type = typeof(T);
            var properties = type.GetProperties();

            foreach (var property in properties)
            {
                var attributes = property.GetCustomAttributes<ConfigurationValidationAttribute>();
                foreach (var attribute in attributes)
                {
                    AddRule(attribute.CreateValidationRule());
                }
            }
        }

        public ValidationResult Validate()
        {
            var result = new ValidationResult();

            foreach (var rule in _validationRules)
            {
                var value = _configuration[rule.Key];
                if (value == null)
                {
                    result.AddError(
                        rule.Key,
                        null,
                        "Required",
                        $"Configuration key '{rule.Key}' is missing"
                    );
                    continue;
                }

                if (!rule.Validator(value))
                {
                    result.AddError(
                        rule.Key,
                        value,
                        rule.ValidationType,
                        rule.ErrorMessage
                    );
                }
            }

            if (!result.IsValid)
            {
                throw new ConfigurationValidationException(
                    "Configuration validation failed",
                    result.Errors.Select(e => e.ToString())
                );
            }

            return result;
        }
    }
} 