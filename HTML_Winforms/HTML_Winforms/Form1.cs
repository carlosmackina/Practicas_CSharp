using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HTML_Winforms
{

    public partial class Form1 : Form
    {
        
        public string direccionPagina1 = @"Pages.HTMLPage1.html";
        public string direccionPagina2 = @"Pages.HTMLPage2.html";
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string pagina1 = GetEmbeddedResource("HTML_Winforms", direccionPagina1);
            webBrowser1.DocumentText = pagina1;
        }
        public string GetEmbeddedResource(string namespacename, string filename)
        {
            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = namespacename + "." + filename;
            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            try
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    string result = reader.ReadToEnd();
                    return result;
                }
            }
            catch(Exception ex)
            {
                return "No se encontro la pagina";
            }
        }
        private void buttonPagina1_Click(object sender, EventArgs e)
        {
            string pagina1 = GetEmbeddedResource("HTML_Winforms", direccionPagina1);
            webBrowser1.DocumentText = pagina1;
        }
        private void buttonPagina2_Click(object sender, EventArgs e)
        {
            string pagina2 = GetEmbeddedResource("HTML_Winforms", direccionPagina2);
            webBrowser1.DocumentText = pagina2;
        }
    }



    


}
