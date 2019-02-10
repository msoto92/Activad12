using Actividad12.Modelo;
using System;
using System.Linq;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Xml.Serialization;

namespace Actividad12
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CR_Click(object sender, ImageClickEventArgs e)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Cuentos));

                String ID = obtenerID(sender);

                String Path = WebConfigurationManager.AppSettings["archivoXML"];
                XmlReader reader = XmlReader.Create(Path);
                Cuentos cuento = (Cuentos)serializer.Deserialize(reader);

                Cuento c = cuento.cuentos.Where(x => x.ID.Equals(ID)).ToList().FirstOrDefault();

                if (c != null)
                {
                    txtCuento.Text = c.Texto;
                    txtTituloCuento.Text = c.Titulo;
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public string obtenerID(object sender)
        {
            ImageButton image = (ImageButton)sender;

            String x = image.UniqueID;

            return x;
        }
    }
}