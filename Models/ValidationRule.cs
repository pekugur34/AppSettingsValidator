using System;

namespace AppSettingsValidator.Models
{
    public class ValidationRule
    {
        public string Key { get; }
        public Func<string, bool> Validator { get; }
        public string ValidationType { get; }
        public string ErrorMessage { get; }

        public ValidationRule(string key, Func<string, bool> validator, string validationType, string errorMessage)
        {
            Key = key ?? throw new ArgumentNullException(nameof(key));
            Validator = validator ?? throw new ArgumentNullException(nameof(validator));
            ValidationType = validationType ?? throw new ArgumentNullException(nameof(validationType));
            ErrorMessage = errorMessage ?? throw new ArgumentNullException(nameof(errorMessage));
        }
    }
} 