namespace GameZone.Settings
{
    public static class FileSettings
    {
        public const string ImgPath = "/assets/images/games";
        public const string AllowedExtensions = ".png,.jpg,.jpeg";
        public const int MaxSizeAllowedInMB = 1;
        public const int MaxSizeAllowedInBytes = MaxSizeAllowedInMB* 1024*1024;
    }
}
