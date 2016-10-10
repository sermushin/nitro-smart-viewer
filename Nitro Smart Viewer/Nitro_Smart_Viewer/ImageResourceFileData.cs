namespace Nitro_Smart_Viewer
{
    public class ImageResourceFileData : ResourceFileData
    {
        public ImageResourceFileData(string fileName, string fullPath) : base(fileName, fullPath)
        {
            Type = ResourceType.Image;
        }

        public ImageResourceFileData(string fileName, string fullPath, bool isFile) : base(fileName, fullPath, isFile)
        {
            Type = ResourceType.Image;
        }
    }
}