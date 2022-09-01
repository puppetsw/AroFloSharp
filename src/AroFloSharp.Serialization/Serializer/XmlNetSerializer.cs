using System;
using System.IO;
using System.Xml.Serialization;

#nullable enable

namespace AroFloSharp.Serialization.Serializer
{
    public class XmlNetSerializer<T> : IDisposable where T : class
    {
        private readonly XmlSerializer _serializer;

        public string ContentType { get; } = "application/xml";

        /// <summary>
        /// Create the new serializer that uses XmlSerializer with default settings
        /// </summary>
        public XmlNetSerializer()
        {
            _serializer = new XmlSerializer(typeof(T));
        }

        public string? Serialize(object? obj)
        {
            if (obj == null)
            {
                return null;
            }

            using var textWriter = new StringWriter();

            _serializer.Serialize(textWriter, obj);

            return textWriter.ToString();
        }

        public T? Deserialize(string? response)
        {
            if (string.IsNullOrEmpty(response))
            {
                return null;
            }

            using var textReader = new StringReader(response);

            return (T)_serializer.Deserialize(textReader);
        }

        public void Dispose() { }
    }
}
