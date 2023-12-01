namespace GameZone.ViewModels
{
    public class EditGameFormViewModel : GameFormViewModel
    {
        public int Id { get; set; }
        [AllowedExtensions(FileSettings.AllowedExtensions), MaxAllowedImgSize(FileSettings.MaxSizeAllowedInBytes)]
        public string? CurrentCover { get; set; }
        public IFormFile? Cover { get; set; } = default!;
    }
}
