using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core; 


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
            comboBox_PaginasWeb.Items.Add("https://www.google.com.gt/?hl=es");


            //Selecciona el primer Item por defecto
            comboBox_PaginasWeb.SelectedIndex = 4;

        }

        private void comboBox_PaginasWeb_SelectedIndexChanged(object sender, EventArgs e)

        {

            // Navegar a la página seleccionada
            if (comboBox_PaginasWeb.SelectedIndex != -1 && webView2.CoreWebView2 != null)
            {
                var url = comboBox_PaginasWeb.SelectedItem.ToString();
                webView2.CoreWebView2.Navigate(url);
            }
        }

        private void button_ir_Click(object sender, EventArgs e)
        {
            //Ir a las paginas web
            //verificar y colocarles https a la pagina para que funciones

            string url = comboBox_PaginasWeb.Text.Trim();//.text porque estamos escribiendo

            // Verifica si la URL comienza con "http://" o "https://", si no añade "https://" para que la pagina funcione
            if (!url.StartsWith("http://", StringComparison.OrdinalIgnoreCase) &&
                !url.StartsWith("https://", StringComparison.OrdinalIgnoreCase)&& !url.StartsWith(".",StringComparison.OrdinalIgnoreCase))
            {
                url = " " + url;
            }
            if (!url.StartsWith("https://www.google.com/search?q=", StringComparison.OrdinalIgnoreCase))
            {
                url = "https://www.google.com/search?q=" + url;
            }


            webView2.CoreWebView2.Navigate(url); 

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void haciaAtrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Regresar a la pagina anterior
            //Con CanGoback verifica si podemos regresar 
            if (webView2.CoreWebView2.CanGoBack)
            {
                webView2.CoreWebView2.GoBack();
            }

        }

        private void haciaAdelanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Ir a la pagina siguiente
            if (webView2.CoreWebView2.CanGoForward)
            {
                webView2.CoreWebView2.GoForward();
            }

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Salir de la pagina
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webView2.CoreWebView2.Navigate("https://www.google.com.gt/?hl=es");
        }
    }
}
