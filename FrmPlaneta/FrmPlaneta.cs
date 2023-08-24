using System;
using FrmPlaneta.Properties;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;

namespace Planeta
{
    public partial class FrmPlaneta : Form
    {
        string opcion = "";
        string contenido = "";
        ColeccionProcedimientos Procesos = new ColeccionProcedimientos();

        public FrmPlaneta()
        {
            InitializeComponent();
        }

        private void FrmPlanetaCarga(object sender, EventArgs evento)
        {
            Procesos.CargarOpciones(cmb_opciones);

            pic_planeta.Visible = false;
            tlp_info_planeta.Visible = false;
        }

        private void SeleccionEnComboboxOpciones(object sender, EventArgs evento)
        {
            opcion = cmb_opciones.Text;
            Procesos.FiltrarCotenido(opcion, cmb_contenido);
        }

        private void SeleccionEnComboboxContenido(object sender, EventArgs e)
        {
            contenido = cmb_contenido.Text;
            if (contenido == "Mid-Rim") contenido = "Mid Rim";
        }

        private void BtnBuscarClick(object sender, EventArgs evento)
        {
            timer_carga.Start();
            pic_carga.Image = Resources.cargando;
        }

        private void TimerCargaTick(object sender, EventArgs evento)
        {
            timer_carga.Stop();
            pic_carga.Image = Resources.cargado;
            dgv_datos.Rows.Clear();

            if (contenido.Trim().Length < 1 || opcion.Trim().Length < 1)
            {
                Procesos.CargarPlanetas(dgv_datos);
            }
            else
            {
                Procesos.CargarPlanetas(dgv_datos);
                Procesos.FiltradoDeDatos(dgv_datos, opcion, contenido);
            }
        }

        private void SeleccionDePlaneta(object sender, EventArgs e)
        {
            Label[] Etiquetas = { lbl_longitud, lbl_latitud };
            int indice = dgv_datos.CurrentRow.Index > 0 ? dgv_datos.CurrentRow.Index : 0;

            if (dgv_datos.SelectedRows.Count > 0)
            {
                pic_planeta.Visible = true;
                tlp_info_planeta.Visible = true;

                lbl_planeta.Text = dgv_datos.Rows[indice].Cells["name"].Value.ToString();
                lbl_sector.Text  = dgv_datos.Rows[indice].Cells["sector"].Value.ToString();
                lbl_nativos.Text = dgv_datos.Rows[indice].Cells["natives"].Value.ToString();
                lbl_alianza.Text = dgv_datos.Rows[indice].Cells["filiation"].Value.ToString();

                lv_rutas.Items.Clear();
                Procesos.LlenarInfoDelPlanet(lbl_planeta.Text, Etiquetas, lv_rutas, pic_planeta);
            }
        }
    }

    public class ColeccionProcedimientos
    {
        XmlDocument Xml = new XmlDocument();

        /// <summary>
        /// Carga las opciones de las Combobox de opciones
        /// </summary>
        /// <param name="CmbOpciones"></param>
        public void CargarOpciones(ComboBox CmbOpciones)
        {
            string opcion;
            
            Xml.Load("../../FrmPlaneta/Ficheros/DataBank.xml");
            XmlNode Opciones = Xml.SelectSingleNode("SpaceData");

            CmbOpciones.Items.Add("");

            foreach (XmlNode OpcionItem in Opciones)
            {
                opcion = OpcionItem.Name;
                CmbOpciones.Items.Add(opcion);
            }
        }

        /// <summary>
        /// Genera la Combobox de contenido
        /// </summary>
        /// <param name="ListaNodos"></param>
        /// <param name="CmbContenido"></param>
        public void CargarContenido(XmlNodeList ListaNodos, ComboBox CmbContenido)
        {
            string contenido;
            CmbContenido.Items.Clear();
            CmbContenido.Text = "";

            CmbContenido.Items.Add("");

            foreach (XmlNode ContenidoItem in ListaNodos)
            {
                contenido = ContenidoItem.InnerText;
                CmbContenido.Items.Add(contenido);
            }
        }
        
        /// <summary>
        /// Filtra los item de la Combobox contenido por opción seleccionada
        /// </summary>
        /// <param name="opcion"></param>
        /// <param name="CmbContenido"></param>
        public void FiltrarCotenido(string opcion, ComboBox CmbContenido)
        {
            XmlNodeList ListaDeNodos;

            bool alianza = opcion == "filiations";
            bool region  = opcion == "regions";
            bool planeta = opcion == "planets";

            if (alianza)
            {
                ListaDeNodos = Xml.SelectNodes(string.Format("SpaceData/{0}/description", opcion));
                CargarContenido(ListaDeNodos, CmbContenido);
            }
            else if (region)
            {
                ListaDeNodos = Xml.SelectNodes(string.Format("SpaceData/{0}/Region/nameRegion", opcion));
                CargarContenido(ListaDeNodos, CmbContenido);
            }
            else
            {
                ListaDeNodos = Xml.SelectNodes(string.Format("SpaceData/{0}/planet/name", opcion));
                CargarContenido(ListaDeNodos, CmbContenido);
            }
        }

        /// <summary>
        /// Carga la información de los planetas
        /// </summary>
        /// <param name="VistaDeDatos"></param>
        public void CargarPlanetas(DataGridView VistaDeDatos)
        {
            string nombre, sector, alianzas, nativos; int iteracion;
            XmlNodeList DatosNodo = Xml.SelectNodes("SpaceData/planets/planet");
            iteracion = 0;

            foreach (XmlNode Nodo in DatosNodo)
            {
                nombre = Nodo["name"].InnerText;
                sector = SeparadorSector(Nodo["sector"].InnerText);
                alianzas = Nodo["filiation"].InnerText;
                nativos = Nodo["natives"].InnerText;

                VistaDeDatos.Rows.Add();
                VistaDeDatos.Rows[iteracion].Cells["name"].Value = nombre;
                VistaDeDatos.Rows[iteracion].Cells["sector"].Value = sector;
                VistaDeDatos.Rows[iteracion].Cells["filiation"].Value = alianzas;
                VistaDeDatos.Rows[iteracion].Cells["natives"].Value = nativos;

                iteracion++;
            }
        }

        /// <summary>
        /// Filtra las hileras por contenido seleccionado
        /// </summary>
        /// <param name="VistaDeDatos"></param>
        /// <param name="campo"></param>
        /// <param name="filtro"></param>
        public void FiltradoDeDatos(DataGridView VistaDeDatos, string campo, string filtro)
        {
            bool filtro_ok;
            int longitud = VistaDeDatos.Rows.Count - 1;

            if (campo == "planets") campo = "name";
            if (campo == "regions") campo = "sector";
            if (campo == "filiations") campo = "filiation";

            for (int i = 0; i < longitud ; i++)
            {
                filtro_ok = VistaDeDatos.Rows[i].Cells[campo].Value.ToString() != filtro;
                if (filtro_ok) VistaDeDatos.Rows[i].Visible = false;
            }
        }

        /// <summary>
        /// Separa el texto del nodo "sector"
        /// </summary>
        /// <param name="nodo"></param>
        /// <returns></returns>
        public string SeparadorSector(string nodo)
        {
            string [] nombre = nodo.Split('-');
            string sector = nombre[1];
            return sector;
        }

        /// <summary>
        /// Busca la información restante del planeta
        /// </summary>
        /// <param name="planeta"></param>
        /// <param name="Restantes"></param>
        public void LlenarInfoDelPlanet(string planeta, Label[] Restantes, ListView ListaRutas, PictureBox Imagen)
        {
            XmlNodeList DatosNodo = Xml.SelectNodes(string.Format("SpaceData/planets/planet[name=\"{0}\"]/*", planeta));

            foreach (XmlNode Nodo in DatosNodo)
            {
                if (Nodo.HasChildNodes && Nodo.Name == "situation")
                {
                    Restantes[0].Text = Nodo["long"].InnerText;
                    Restantes[1].Text = Nodo["lat"].InnerText;
                }

                if (Nodo.HasChildNodes && Nodo.Name == "hyperspaceRoute")
                {
                    XmlNodeList Rutas = Nodo.ChildNodes;
                    BuscarRutas(Rutas, ListaRutas);                  
                }
            }

            CargarImagen(planeta, Imagen);
        }

        /// <summary>
        /// Busca todas las rutas asociadad al planeta
        /// </summary>
        /// <param name="ListaDeNodos"></param>
        /// <param name="ListaDeRutas"></param>
        public void BuscarRutas(XmlNodeList ListaDeNodos, ListView ListaDeRutas)
        {
            string ruta;

            foreach (XmlNode Ruta in ListaDeNodos)
            {
                ruta = Ruta.InnerText;

                ListViewItem ItemRuta = new ListViewItem();
                ItemRuta.Text = ruta;
                ListaDeRutas.Items.Add(ItemRuta.Text);
            }
        }

        /// <summary>
        /// Carga las Imagenes de los planetes
        /// </summary>
        /// <param name="planeta"></param>
        /// <param name="ImagenPlaneta"></param>
        public void CargarImagen(string planeta, PictureBox ImagenPlaneta)
        {
            bool planeta_ok;
            string imagen;
            string ruta = "../../FrmPlaneta/Ficheros/Planetes";
            DirectoryInfo Planetes = new DirectoryInfo(ruta);
            FileInfo[] ficheros = Planetes.GetFiles();

            foreach (var item in ficheros)
            {
                planeta_ok = item.Name.Substring(0, item.Name.Length - 4) == planeta;
                if (planeta_ok)
                {
                    imagen = item.Name;
                    ImagenPlaneta.ImageLocation = string.Format("{0}/{1}", ruta, imagen);
                }
            }
        }
    }
}
