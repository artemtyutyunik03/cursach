using System.Collections.Generic;
using System.IO;

namespace XMLProvider.DAL
{
    public static class API
    {
        public static void PostInfo<T>(List<T> data, string filepath)
        {
            XMLProvider<T>.XMLSerialize(data, filepath);
        }

        public static List<T> GetInfo<T>(string filepath)
        {
            List<T> list = new List<T>();

            if (File.Exists(filepath))
                list = XMLProvider<T>.XMLDeserialize(filepath);
            return list;
        }
    }
}