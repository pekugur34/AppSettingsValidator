# AppSettingsValidator

A .NET library for validating application settings and configuration values with a fluent API and attribute-based validation.

## Features

- Attribute-based validation for configuration properties
- Support for common validation rules:
  - Required fields
  - Minimum length
  - Email validation
  - Numeric range validation
  - Boolean validation
  - Phone number validation with support for 200+ countries
- Fluent API for custom validation rules
- Detailed validation error reporting
- Easy integration with dependency injection

## Installation

```bash
dotnet add package AppSettingsValidator
```

## Quick Start

### Using Attributes

```csharp
// Define your configuration class with validation attributes
public class AppSettings
{
    [Required("Database:ConnectionString")]
    [MinLength("Database:ConnectionString", 10)]
    public string ConnectionString { get; set; }

    [Email("Admin:Email")]
    public string AdminEmail { get; set; }

    [Range("Server:Port", 1, 65535)]
    public int Port { get; set; }

    [Boolean("Feature:Enabled")]
    public bool FeatureEnabled { get; set; }

    [PhoneNumber("Contact:Phone", "US")]
    public string PhoneNumber { get; set; }
}

// Create a configuration validator
var validator = new ConfigurationValidator();

// Validate your configuration
var configuration = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json")
    .Build();

var result = validator.Validate(configuration);

if (!result.IsValid)
{
    foreach (var error in result.Errors)
    {
        Console.WriteLine($"Validation failed: {error.ErrorMessage}");
        Console.WriteLine($"Key: {error.Key}");
        Console.WriteLine($"Value: {error.Value}");
        Console.WriteLine($"Validation Type: {error.ValidationType}");
    }
}
```

### Using Fluent API

```csharp
var validator = new ConfigurationValidator();
validator.AddRule(ValidationRuleBuilder.Required("Database:ConnectionString"));
validator.AddRule(ValidationRuleBuilder.Email("Admin:Email"));
validator.AddRule(ValidationRuleBuilder.Range("Server:Port", 1, 65535));
validator.AddRule(ValidationRuleBuilder.Boolean("Feature:Enabled"));
validator.AddRule(ValidationRuleBuilder.PhoneNumber("Contact:Phone", "US"));

var result = validator.Validate(configuration);
if (!result.IsValid)
{
    foreach (var error in result.Errors)
    {
        Console.WriteLine(error);
    }
}
```

### Example appsettings.json

```json
{
  "Database": {
    "ConnectionString": "Server=localhost;Database=mydb;User=admin;Password=secret"
  },
  "Admin": {
    "Email": "admin@example.com"
  },
  "Server": {
    "Port": 8080
  },
  "Feature": {
    "Enabled": true
  },
  "Contact": {
    "Phone": "+1-555-123-4567"
  }
}
```

### Dependency Injection Example

```csharp
// In Startup.cs or Program.cs
public void ConfigureServices(IServiceCollection services)
{
    services.AddSingleton<IConfigurationValidator, ConfigurationValidator>();
    
    // Register your configuration
    services.Configure<AppSettings>(Configuration);
}

// In your service or controller
public class MyService
{
    private readonly IConfigurationValidator _validator;
    private readonly IConfiguration _configuration;

    public MyService(IConfigurationValidator validator, IConfiguration configuration)
    {
        _validator = validator;
        _configuration = configuration;
    }

    public void ValidateSettings()
    {
        var result = _validator.Validate(_configuration);
        if (!result.IsValid)
        {
            // Handle validation errors
            throw new ConfigurationValidationException(result.Errors);
        }
    }
}
```

## Supported Phone Number Formats

The library supports phone number validation for over 200 countries and territories, including:

- North America (US, Canada, Mexico)
- Europe (UK, Germany, France, etc.)
- Asia (China, Japan, India, etc.)
- South America (Brazil, Argentina, etc.)
- Africa (South Africa, Egypt, etc.)
- Oceania (Australia, New Zealand, etc.)
- Middle East (Saudi Arabia, UAE, etc.)

Phone numbers can be validated in both international format (with country code) and national format.

## Contributing

Contributions are welcome! Please feel free to submit a Pull Request.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details. 
