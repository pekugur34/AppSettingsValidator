using System;
using System.Collections.Generic;
using System.Linq;

namespace AppSettingsValidator
{
    public class ConfigurationValidationException : Exception
    {
        public IEnumerable<string> ValidationErrors { get; }

        public ConfigurationValidationException(string message, IEnumerable<string> validationErrors)
            : base($"{message}\nValidation Errors:\n{string.Join("\n", validationErrors.Select(e => $"- {e}"))}")
        {
            ValidationErrors = validationErrors;
        }
    }
} 