using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using UnityEngine.Experimental.U2D;

namespace UnityEditor.Experimental.U2D.Animation
{
    public class SkinningXMLSerializer : ISkinningSerializer
    {
        public bool CanDeserialize(string data)
        {
            bool result = false;
            try
            {
                using (TextReader textReader = new StringReader(data))
                {
                    using (XmlTextReader xmlReader = new XmlTextReader(textReader))
                    {
                        var xmlSerializer = new XmlSerializer(typeof(List<SpriteBone>));
                        result = xmlSerializer.CanDeserialize(xmlReader);
                    }
                }
            }
            catch
            {
            }
            return result;
        }

        public SkinningCopyData Deserialize(string data)
        {
            SkinningCopyData skinningCopyData;
            using (TextReader textReader = new StringReader(data))
            {
                using (XmlTextReader xmlReader = new XmlTextReader(textReader))
                {
                    var xmlSerializer = new XmlSerializer(typeof(SkinningCopyData));
                    if (!xmlSerializer.CanDeserialize(xmlReader))
                    {
                        throw new InvalidOperationException(
                            "Unable to deserialize system copy buffer to Skinning Copy Data");
                    }
                    skinningCopyData = (SkinningCopyData)xmlSerializer.Deserialize(xmlReader);
                }
            }
            return skinningCopyData;
        }

        public string Serialize(SkinningCopyData skinningData)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(skinningData.GetType());
            using (StringWriter textWriter = new StringWriter())
            {
                xmlSerializer.Serialize(textWriter, skinningData);
                return textWriter.ToString();
            }
        }
    }
}
