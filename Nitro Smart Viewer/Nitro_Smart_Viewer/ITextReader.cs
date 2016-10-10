using System.IO;

namespace Nitro_Smart_Viewer
{
    public interface ITextFileReader
    {
        string GetTxtFileContent(Stream stream);
    }
}