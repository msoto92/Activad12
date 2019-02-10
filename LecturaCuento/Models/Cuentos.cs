using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace Actividad12.Modelo
{
    [Serializable()]
    [System.Xml.Serialization.XmlRoot("actividad")]
    public class Cuentos
    {
        [XmlArray("cuentos")]
        [XmlArrayItem("cuento", typeof(Cuento))]
        public Cuento[] cuentos { get; set; }
    }
}