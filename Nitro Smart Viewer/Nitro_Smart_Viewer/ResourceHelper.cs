using System;
using System.IO;
using System.Linq;
using System.Reflection;

namespace Nitro_Smart_Viewer
{
    public static class ResourceHelper
    {
        public static string[] GetResourse(ResourceType resourceType)
        {
            string value;
            switch (resourceType)
            {
                case ResourceType.Txt:
                {
                    value = ".txt";
                    break;
                }
                case ResourceType.Image:
                {
                    value = ".png";
                    break;
                }
                default:
                {
                    throw new ArgumentOutOfRangeException(nameof(resourceType), resourceType, null);
                }
            }

            var assembly = typeof(ResourceHelper).GetTypeInfo().Assembly;
            var resources = assembly.GetManifestResourceNames().Where(name => name.Contains(value));

            return resources.ToArray();
        }

        public static Stream GetResourceStream(string resourceName)
        {
            var assembly = typeof(ResourceHelper).GetTypeInfo().Assembly;
            Stream stream = assembly.GetManifestResourceStream(resourceName);
            return stream;
        }
    }
}