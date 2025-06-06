using AppSettingsValidator.Models;
using System;

namespace AppSettingsValidator.Attributes
{
    public class RequiredAttribute : ConfigurationValidationAttribute
    {
        public RequiredAttribute(string key, string? errorMessage = null) 
            : base(key, errorMessage)
        {
        }

        public override ValidationRule CreateValidationRule()
        {
            return ValidationRuleBuilder.Required(Key, ErrorMessage);
        }
    }

    public class MinLengthAttribute : ConfigurationValidationAttribute
    {
        public int MinLength { get; }

        public MinLengthAttribute(string key, int minLength, string? errorMessage = null) 
            : base(key, errorMessage)
        {
            MinLength = minLength;
        }

        public override ValidationRule CreateValidationRule()
        {
            return ValidationRuleBuilder.MinLength(Key, MinLength, ErrorMessage);
        }
    }

    public class EmailAttribute : ConfigurationValidationAttribute
    {
        public EmailAttribute(string key, string? errorMessage = null) 
            : base(key, errorMessage)
        {
        }

        public override ValidationRule CreateValidationRule()
        {
            return ValidationRuleBuilder.Email(Key, ErrorMessage);
        }
    }

    public class RangeAttribute : ConfigurationValidationAttribute
    {
        public int Min { get; }
        public int Max { get; }

        public RangeAttribute(string key, int min, int max, string? errorMessage = null) 
            : base(key, errorMessage)
        {
            Min = min;
            Max = max;
        }

        public override ValidationRule CreateValidationRule()
        {
            return ValidationRuleBuilder.Range(Key, Min, Max, ErrorMessage);
        }
    }

    public class BooleanAttribute : ConfigurationValidationAttribute
    {
        public BooleanAttribute(string key, string? errorMessage = null) 
            : base(key, errorMessage)
        {
        }

        public override ValidationRule CreateValidationRule()
        {
            return ValidationRuleBuilder.Boolean(Key, ErrorMessage);
        }
    }

    public class PhoneNumberAttribute : ConfigurationValidationAttribute
    {
        public string? DefaultRegion { get; }

        public PhoneNumberAttribute(string key, string? defaultRegion = null, string? errorMessage = null) 
            : base(key, errorMessage)
        {
            DefaultRegion = defaultRegion;
        }

        public override ValidationRule CreateValidationRule()
        {
            return ValidationRuleBuilder.PhoneNumber(Key, DefaultRegion, ErrorMessage);
        }
    }
} 