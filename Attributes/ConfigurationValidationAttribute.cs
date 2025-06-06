using System;
using AppSettingsValidator.Models;

namespace AppSettingsValidator.Attributes
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
    public abstract class ConfigurationValidationAttribute : Attribute
    {
        public string Key { get; }
        public string? ErrorMessage { get; }

        protected ConfigurationValidationAttribute(string key, string? errorMessage = null)
        {
            Key = key ?? throw new ArgumentNullException(nameof(key));
            ErrorMessage = errorMessage;
        }

        public abstract ValidationRule CreateValidationRule();
    }
} 