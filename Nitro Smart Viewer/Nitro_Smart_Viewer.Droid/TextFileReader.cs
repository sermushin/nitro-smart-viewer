using System.IO;

namespace Nitro_Smart_Viewer.Droid
{
    public class TextFileReader : ITextFileReader
    {
        public string GetTxtFileContent(Stream stream)
        {
            string text = "";
            using (var reader = new System.IO.StreamReader(stream))
            {
                text = reader.ReadToEnd();
            }
            return text;
        }
    }
}