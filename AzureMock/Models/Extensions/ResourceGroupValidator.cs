using System.Text.RegularExpressions;

namespace AzureMock.Models.Extensions
{
    public static class ResourceGroupValidator
    {
        private static readonly Regex NamePattern = new Regex(@"^[\w\-\.\(\)]+$", RegexOptions.Compiled);

        /// <summary>
        /// Validates a resource group name according to Azure naming rules
        /// </summary>
        public static ValidationResult ValidateName(this ResourceGroup resourceGroup)
        {
            if (string.IsNullOrWhiteSpace(resourceGroup.Name))
            {
                return ValidationResult.Error("Resource group name is required");
            }

            if (!NamePattern.IsMatch(resourceGroup.Name))
            {
                return ValidationResult.Error(
                    "Resource group name can only include alphanumeric, underscore, parentheses, hyphen, and period");
            }

            if (resourceGroup.Name.EndsWith('.'))
            {
                return ValidationResult.Error("Resource group name cannot end with a period");
            }

            if (resourceGroup.Name.Length > 90)
            {
                return ValidationResult.Error("Resource group name cannot exceed 90 characters");
            }

            return ValidationResult.Success();
        }

        /// <summary>
        /// Validates the location/region of a resource group
        /// </summary>
        public static ValidationResult ValidateLocation(this ResourceGroup resourceGroup)
        {
            if (string.IsNullOrWhiteSpace(resourceGroup.Location))
            {
                return ValidationResult.Error("Region is required");
            }

            return ValidationResult.Success();
        }

        /// <summary>
        /// Validates all properties of a resource group
        /// </summary>
        public static ValidationResult Validate(this ResourceGroup resourceGroup)
        {
            var nameValidation = resourceGroup.ValidateName();
            if (!nameValidation.IsValid)
            {
                return nameValidation;
            }

            var locationValidation = resourceGroup.ValidateLocation();
            if (!locationValidation.IsValid)
            {
                return locationValidation;
            }

            return ValidationResult.Success();
        }

        /// <summary>
        /// Checks if the resource group name follows Azure naming conventions
        /// </summary>
        public static bool IsValidName(this ResourceGroup resourceGroup)
        {
            return resourceGroup.ValidateName().IsValid;
        }

        /// <summary>
        /// Checks if the resource group has a valid location
        /// </summary>
        public static bool IsValidLocation(this ResourceGroup resourceGroup)
        {
            return resourceGroup.ValidateLocation().IsValid;
        }
    }

    /// <summary>
    /// Represents the result of a validation operation
    /// </summary>
    public class ValidationResult
    {
        public bool IsValid { get; private set; }
        public string ErrorMessage { get; private set; }

        private ValidationResult(bool isValid, string errorMessage = "")
        {
            IsValid = isValid;
            ErrorMessage = errorMessage;
        }

        public static ValidationResult Success() => new ValidationResult(true);
        
        public static ValidationResult Error(string message) => new ValidationResult(false, message);

        public override string ToString()
        {
            return IsValid ? "Valid" : $"Invalid: {ErrorMessage}";
        }
    }
}
