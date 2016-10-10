using System;
using System.Collections.Generic;

namespace Nitro_Smart_Viewer
{
    public abstract class ResourceFileData
    {
        public ResourceType Type { get; set; }
        public string DisplayName { get; }

        public ResourceFileData(string fileName, string fullPath)
        {
            FileName = fileName;
            FullPath = fullPath;
            IsFile = true;

            DisplayName = fileName.Replace("Nitro_Smart_Viewer.Resources.", ""); ;
        }

        public ResourceFileData(string fileName, string fullPath, bool isFile)
        {
            FileName = fileName;
            FullPath = fullPath;
            IsFile = isFile;
        }

        public string FileName { get; set; }
        public string FullPath { get; set; }
        public bool IsFile { get; set; }

        public static List<ResourceFileData> GetList()
        {
            var list = new List<ResourceFileData>();
            foreach (ResourceType resourceType in Enum.GetValues(typeof(ResourceType)))
            {
                var files = ResourceHelper.GetResourse(resourceType);

                foreach (string file in files)
                {
                    switch (resourceType)
                    {
                        case ResourceType.Txt:
                            list.Add(new TextResourceFileData(file, "assembly::resource"));
                            break;
                        case ResourceType.Image:
                            list.Add(new ImageResourceFileData(file, "assembly::resource"));
                            break;
                        default:
                            throw new ArgumentOutOfRangeException(nameof(resourceType), resourceType, null);
                    }
                }
            }
            return list;
        }
    }
}