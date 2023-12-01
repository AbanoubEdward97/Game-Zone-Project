using GameZone.Settings;
using Microsoft.AspNetCore.Components.Forms;

namespace GameZone.Validations
{
    public class AllowedExtensionsAttribute: ValidationAttribute
    {
        private readonly string _allowedExtensions;

        public AllowedExtensionsAttribute(string allowedExtensions)
        {
            _allowedExtensions = allowedExtensions;
        }
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var file = value as IFormFile;
            if(file is not null )
            {
                var extension = Path.GetExtension(file.FileName);
                var isValid = _allowedExtensions.Split(',').Contains(extension,StringComparer.OrdinalIgnoreCase);
                if(!isValid)
                {
                    return new ValidationResult(errorMessage:$"Only {_allowedExtensions} are allowed!!");
                }

            }
            return ValidationResult.Success;
        }
    }
}
