using System;
using System.Text.RegularExpressions;

namespace AppSettingsValidator
{
    public static class Validators
    {
        public static Func<string, bool> Required => value => !string.IsNullOrEmpty(value);
        
        public static Func<string, bool> NotEmpty => value => !string.IsNullOrWhiteSpace(value);
        
        public static Func<string, bool> Email => value =>
        {
            if (string.IsNullOrEmpty(value)) return false;
            return Regex.IsMatch(value, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        };
        
        public static Func<string, bool> Url => value =>
        {
            if (string.IsNullOrEmpty(value)) return false;
            return Uri.TryCreate(value, UriKind.Absolute, out _);
        };
        
        public static Func<string, bool> MinLength(int minLength) => 
            value => value?.Length >= minLength;
            
        public static Func<string, bool> MaxLength(int maxLength) => 
            value => value?.Length <= maxLength;
            
        public static Func<string, bool> Range(int min, int max) => 
            value => int.TryParse(value, out int num) && num >= min && num <= max;
            
        public static Func<string, bool> Range(double min, double max) => 
            value => double.TryParse(value, out double num) && num >= min && num <= max;
            
        public static Func<string, bool> Pattern(string pattern) => 
            value => !string.IsNullOrEmpty(value) && System.Text.RegularExpressions.Regex.IsMatch(value, pattern);
            
        public static Func<string, bool> EnumValue<T>() where T : struct, Enum => 
            value => Enum.TryParse<T>(value, out _);
            
        public static Func<string, bool> Guid => 
            value => System.Guid.TryParse(value, out _);
            
        public static Func<string, bool> Boolean => 
            value => bool.TryParse(value, out _);
            
        public static Func<string, bool> DateTime => 
            value => System.DateTime.TryParse(value, out _);
    }
} 