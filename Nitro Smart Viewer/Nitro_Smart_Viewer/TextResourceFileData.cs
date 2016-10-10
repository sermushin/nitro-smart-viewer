namespace Nitro_Smart_Viewer
{
    public class TextResourceFileData : ResourceFileData
    {
        public TextResourceFileData(string fileName, string fullPath) : base(fileName, fullPath)
        {
            Type = ResourceType.Txt;
        }

        public TextResourceFileData(string fileName, string fullPath, bool isFile) : base(fileName, fullPath, isFile)
        {
            Type = ResourceType.Txt;
        }
    }
}