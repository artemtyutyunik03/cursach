using System.Collections.Generic;
using System.IO;

namespace XMLProvider
{
    public static class API
    {
        public static void WriteInfo<T>(List<T> data, string filepath)
        {
            XMLProvider<T>.XMLSerialize(data, filepath);
        }

        public static List<T> ReadInfo<T>(string filepath)
        {
            List<T> list = new List<T>();

            if (File.Exists(filepath))
                list = XMLProvider<T>.XMLDeserialize(filepath);
            return list;
        }
    }
}