using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NavegadorWeb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            comboBox_PaginasWeb.Items.Add("https://espanol.yahoo.com/");
            comboBox_PaginasWeb.Items.Add("https://es.wikipedia.org/wiki/Wikipedia:Portada");
            comboBox_PaginasWeb.Items.Add("https://www.youtube.com/");
            comboBox_PaginasWeb.Items.Add("https://www.bing.com/?setlang=es");


            //Selecciona el primer Item por defecto
            comboBox_PaginasWeb.SelectedIndex = 1;



        }

        private void comboBox_PaginasWeb_SelectedIndexChanged(object sender, EventArgs e)

        {

            //Mostrar la primera pagina por defecto
            if (comboBox_PaginasWeb.SelectedIndex != -1)
            {
                var url = comboBox_PaginasWeb.SelectedItem.ToString();
                webBrowser1.Navigate(url);
            }

        }

        private void button_ir_Click(object sender, EventArgs e)
        {
            //Ir a las paginas web
            //verificar y colocarles https a la pagina para que funciones

            string url = comboBox_PaginasWeb.Text.Trim();//.text porque estamos escribiendo

            // Verifica si la URL comienza con "http://" o "https://", si no añade "https://" para que la pagina funcione
            if (!url.StartsWith("http://", StringComparison.OrdinalIgnoreCase) &&
                !url.StartsWith("https://", StringComparison.OrdinalIgnoreCase))
            {
                url = "https://" + url;
            }
            if (!url.StartsWith("https://www.google.com/search?q=", StringComparison.OrdinalIgnoreCase))
            {
                url = "https://www.google.com/search?q=" + url;
            }


            webBrowser1.Navigate(url);

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void haciaAtrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Regresar a la pagina anterior
            //Con CanGoback verifica si podemos regresar 
            if (webBrowser1.CanGoBack)
            {
                webBrowser1.GoBack();
            }

        }

        private void haciaAdelanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Ir a la pagina siguiente
            if (webBrowser1.CanGoForward)
            {
                webBrowser1.GoForward();    
            }
            
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Salir de la pagina
            this.Close();
        }
    }
}
