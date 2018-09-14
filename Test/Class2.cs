using System;
using System.IO;
using System.IO.IsolatedStorage;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace Test
{
    class Class2
    {
    }

    public enum SerializedFormat
    {
        Binary,
        Document
    }

    public static class ObjectXMLSerializer<T> where T : class
    {
        public static T Load(string path)
        {
            return ObjectXMLSerializer<T>.LoadFromDocumentFormat(null, path, null);
        }

        public static T Load(string path, SerializedFormat serializedFormat)
        {
            T result = default(T);
            switch (serializedFormat)
            {
                case SerializedFormat.Binary:
                    result = ObjectXMLSerializer<T>.LoadFromBinaryFormat(path, null);
                    return result;
            }
            result = ObjectXMLSerializer<T>.LoadFromDocumentFormat(null, path, null);
            return result;
        }

        public static T Load(string path, Type[] extraTypes)
        {
            return ObjectXMLSerializer<T>.LoadFromDocumentFormat(extraTypes, path, null);
        }

        public static T Load(string fileName, IsolatedStorageFile isolatedStorageDirectory)
        {
            return ObjectXMLSerializer<T>.LoadFromDocumentFormat(null, fileName, isolatedStorageDirectory);
        }

        public static T Load(string fileName, IsolatedStorageFile isolatedStorageDirectory, SerializedFormat serializedFormat)
        {
            T result = default(T);
            switch (serializedFormat)
            {
                case SerializedFormat.Binary:
                    result = ObjectXMLSerializer<T>.LoadFromBinaryFormat(fileName, isolatedStorageDirectory);
                    return result;
            }
            result = ObjectXMLSerializer<T>.LoadFromDocumentFormat(null, fileName, isolatedStorageDirectory);
            return result;
        }

        public static T Load(string fileName, IsolatedStorageFile isolatedStorageDirectory, Type[] extraTypes)
        {
            return ObjectXMLSerializer<T>.LoadFromDocumentFormat(null, fileName, isolatedStorageDirectory);
        }

        public static void Save(T serializableObject, string path)
        {
            ObjectXMLSerializer<T>.SaveToDocumentFormat(serializableObject, null, path, null);
        }

        public static void Save(T serializableObject, string path, SerializedFormat serializedFormat)
        {
            switch (serializedFormat)
            {
                case SerializedFormat.Binary:
                    ObjectXMLSerializer<T>.SaveToBinaryFormat(serializableObject, path, null);
                    return;
            }
            ObjectXMLSerializer<T>.SaveToDocumentFormat(serializableObject, null, path, null);
        }

        public static void Save(T serializableObject, string path, Type[] extraTypes)
        {
            ObjectXMLSerializer<T>.SaveToDocumentFormat(serializableObject, extraTypes, path, null);
        }

        public static void Save(T serializableObject, string fileName, IsolatedStorageFile isolatedStorageDirectory)
        {
            ObjectXMLSerializer<T>.SaveToDocumentFormat(serializableObject, null, fileName, isolatedStorageDirectory);
        }

        public static void Save(T serializableObject, string fileName, IsolatedStorageFile isolatedStorageDirectory, SerializedFormat serializedFormat)
        {
            switch (serializedFormat)
            {
                case SerializedFormat.Binary:
                    ObjectXMLSerializer<T>.SaveToBinaryFormat(serializableObject, fileName, isolatedStorageDirectory);
                    return;
            }
            ObjectXMLSerializer<T>.SaveToDocumentFormat(serializableObject, null, fileName, isolatedStorageDirectory);
        }

        public static void Save(T serializableObject, string fileName, IsolatedStorageFile isolatedStorageDirectory, Type[] extraTypes)
        {
            ObjectXMLSerializer<T>.SaveToDocumentFormat(serializableObject, null, fileName, isolatedStorageDirectory);
        }

        private static FileStream CreateFileStream(IsolatedStorageFile isolatedStorageFolder, string path)
        {
            FileStream result;
            if (isolatedStorageFolder == null)
            {
                result = new FileStream(path, FileMode.OpenOrCreate);
            }
            else
            {
                result = new IsolatedStorageFileStream(path, FileMode.OpenOrCreate, isolatedStorageFolder);
            }
            return result;
        }

        private static T LoadFromBinaryFormat(string path, IsolatedStorageFile isolatedStorageFolder)
        {
            T result = default(T);
            using (FileStream fileStream = ObjectXMLSerializer<T>.CreateFileStream(isolatedStorageFolder, path))
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                result = (binaryFormatter.Deserialize(fileStream) as T);
            }
            return result;
        }

        private static T LoadFromDocumentFormat(Type[] extraTypes, string path, IsolatedStorageFile isolatedStorageFolder)
        {
            T result = default(T);
            using (TextReader textReader = ObjectXMLSerializer<T>.CreateTextReader(isolatedStorageFolder, path))
            {
                XmlSerializer xmlSerializer = ObjectXMLSerializer<T>.CreateXmlSerializer(extraTypes);
                result = (xmlSerializer.Deserialize(textReader) as T);
            }
            return result;
        }

        private static TextReader CreateTextReader(IsolatedStorageFile isolatedStorageFolder, string path)
        {
            TextReader result;
            if (isolatedStorageFolder == null)
            {
                result = new StreamReader(path);
            }
            else
            {
                result = new StreamReader(new IsolatedStorageFileStream(path, FileMode.Open, isolatedStorageFolder));
            }
            return result;
        }

        private static TextWriter CreateTextWriter(IsolatedStorageFile isolatedStorageFolder, string path)
        {
            TextWriter result;
            if (isolatedStorageFolder == null)
            {
                if (!File.Exists(path))
                {
                    result = new StreamWriter(path);
                }
                else
                {
                    result = new StreamWriter(new IsolatedStorageFileStream(path, FileMode.OpenOrCreate, isolatedStorageFolder));
                }
            }
            else
            {
                result = new StreamWriter(new IsolatedStorageFileStream(path, FileMode.OpenOrCreate, isolatedStorageFolder));
            }
            return result;
        }

        private static XmlSerializer CreateXmlSerializer(Type[] extraTypes)
        {
            Type typeFromHandle = typeof(T);
            XmlSerializer result;
            if (extraTypes != null)
            {
                result = new XmlSerializer(typeFromHandle, extraTypes);
            }
            else
            {
                result = new XmlSerializer(typeFromHandle);
            }
            return result;
        }

        private static void SaveToDocumentFormat(T serializableObject, Type[] extraTypes, string path, IsolatedStorageFile isolatedStorageFolder)
        {
            using (TextWriter textWriter = ObjectXMLSerializer<T>.CreateTextWriter(isolatedStorageFolder, path))
            {
                XmlSerializer xmlSerializer = ObjectXMLSerializer<T>.CreateXmlSerializer(extraTypes);
                xmlSerializer.Serialize(textWriter, serializableObject);
            }
        }

        private static void SaveToBinaryFormat(T serializableObject, string path, IsolatedStorageFile isolatedStorageFolder)
        {
            using (FileStream fileStream = ObjectXMLSerializer<T>.CreateFileStream(isolatedStorageFolder, path))
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(fileStream, serializableObject);
            }
        }
    }
}
