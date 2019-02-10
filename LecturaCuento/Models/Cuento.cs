using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace Actividad12
{
    [Serializable()]
    public class Cuento
    {

        [System.Xml.Serialization.XmlElement("id")]
        public string ID { get; set; }

        [System.Xml.Serialization.XmlElement("titulo")]
        public string Titulo { get; set; }

        [System.Xml.Serialization.XmlElement("texto")]
        public string Texto { get; set; }

    }
}