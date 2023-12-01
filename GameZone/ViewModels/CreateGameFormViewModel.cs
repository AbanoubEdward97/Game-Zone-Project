
namespace GameZone.ViewModels
{
    public class CreateGameFormViewModel : GameFormViewModel
    {
        [AllowedExtensions(FileSettings.AllowedExtensions),
         MaxAllowedImgSize(FileSettings.MaxSizeAllowedInBytes)   
        ]
        public IFormFile Cover { get; set; } = default!;
    }
}
