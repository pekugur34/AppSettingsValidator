using System.Collections.Generic;

namespace AppSettingsValidator.Models
{
    public class ValidationResult
    {
        public bool IsValid => Errors.Count == 0;
        public List<ValidationError> Errors { get; } = new List<ValidationError>();

        public void AddError(string key, string? value, string validationType, string errorMessage)
        {
            Errors.Add(new ValidationError(key, value, validationType, errorMessage));
        }
    }

    public class ValidationError
    {
        public string Key { get; }
        public string? Value { get; }
        public string ValidationType { get; }
        public string ErrorMessage { get; }

        public ValidationError(string key, string? value, string validationType, string errorMessage)
        {
            Key = key;
            Value = value;
            ValidationType = validationType;
            ErrorMessage = errorMessage;
        }

        public override string ToString()
        {
            return $"Validation failed for key '{Key}' with value '{Value}' ({ValidationType} validation)";
        }
    }
} 