using GameZone.Settings;

namespace GameZone.Validations
{
    public class MaxAllowedImgSizeAttribute : ValidationAttribute
    {
        private readonly int _maxAllowedImgSize;

        public MaxAllowedImgSizeAttribute(int maxAllowedImgSize)
        {
            _maxAllowedImgSize = maxAllowedImgSize;
        }
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {

            var file = value as IFormFile;
            if (file is not null)
            {
                var FileSize = file.Length;
                if (FileSize > _maxAllowedImgSize)
                {
                    return new ValidationResult(errorMessage: $"Only Files with max size {FileSettings.MaxSizeAllowedInMB} MB are allowed!!");
                }

            }
            return ValidationResult.Success;
        }
    }
}
