using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    internal static class MethodsSerialization<T>
    {
        public static List<T> ReadJson1(string path)
        {
            if (!File.Exists(path))
            {
                return new List<T>();
            }

            using (FileStream stream = new FileStream(path, FileMode.Open))
            {
                if (stream.Length == 0)
                {
                    return new List<T>();
                }

                var jsonFormatter = new DataContractJsonSerializer(typeof(List<List<T>>));

                var nestedList = (List<List<T>>?)jsonFormatter.ReadObject(stream);

                return nestedList?.SelectMany(x => x).ToList() ?? new List<T>();
            }
        }
        public static List<T> ReadJson(string path)
        {
            if (!File.Exists(path))
            {
                return new List<T>();
            }

            using (FileStream stream = new FileStream(path, FileMode.Open))
            {
                if (stream.Length == 0)
                {
                    return new List<T>();
                }
                var jsonFormatter = new DataContractJsonSerializer(typeof(List<T>));
                var list = (List<T>?)jsonFormatter.ReadObject(stream);
                return list ?? new List<T>();
            }
        }
        public static void AddToJson(string path, T obj)
        {
            var list = ReadJson(path);
            list.Add(obj);
            using (FileStream stream = new FileStream(path, FileMode.Create, FileAccess.Write))
            {
                var jsonFormatter = new DataContractJsonSerializer(typeof(List<T>));

                jsonFormatter.WriteObject(stream, list);
            }

        }
        public static void UpdateJson(string path, List<T> updatedList)
        {
            using (FileStream stream = new FileStream(path, FileMode.Create, FileAccess.Write))
            {
                var jsonFormatter = new DataContractJsonSerializer(typeof(List<T>));
                jsonFormatter.WriteObject(stream, updatedList);
            }
        }
    }
}
