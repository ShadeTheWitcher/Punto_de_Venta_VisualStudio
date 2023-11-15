using CyberGear16.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CyberGear16.WindowsForms.Manual
{
    public partial class formManual : Form
    {
        private int numeroPagina;

        public formManual(int pag)
        {
            InitializeComponent();
            numeroPagina = pag;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void formManual_Load(object sender, EventArgs e)
        {
            //int numeroPagina = 3;
            //CerrarManual.Visible = true;
            panelManual.Visible = true;
            // Nombre del archivo del manual PDF
            string nombreManualPDF = "manual.pdf";

            // Obtiene la ruta del directorio de inicio de la aplicación
            string directorioBase = AppDomain.CurrentDomain.BaseDirectory;

            // Combina la ruta base con el nombre del manual PDF
            string rutaManualPDF = Path.Combine(directorioBase, nombreManualPDF);

            // Verifica si el archivo existe
            if (File.Exists(rutaManualPDF))
            {
                // Crea la URL del archivo local
                string urlArchivoLocal = new Uri(rutaManualPDF).AbsoluteUri;

                // Agrega el número de página como fragmento a la URL
                string urlConPagina = urlArchivoLocal + "#page=" + numeroPagina;

                // Crea una instancia de WebBrowser
                WebBrowser webBrowser = new WebBrowser();
                webBrowser.Dock = DockStyle.Fill;

                // Agrega el control WebBrowser al panel
                panelManual.Controls.Add(webBrowser);

                // Carga la URL con el fragmento de la página en el control WebBrowser
                webBrowser.Navigate(urlConPagina);
            }
            else
            {
                // El archivo no existe, muestra un mensaje de error
                MessageBox.Show("El manual no se encuentra en la ubicación especificada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void AccederAMetodoEnGUIPrincipal()
        {
            // Busca la instancia de GUI_Principal entre los formularios abiertos
            GUI_Principal guiPrincipal = Application.OpenForms.OfType<GUI_Principal>().FirstOrDefault();

            // Verifica si se encontró la instancia
            if (guiPrincipal != null)
            {
                // Llama al método en GUI_Principal

                //Perfil administrador
                if (numeroPagina == 5)
                {
                    guiPrincipal.abrirSectorProductos();
                }

                if (numeroPagina == 7)
                {
                    guiPrincipal.abrirSectorUsuarios();
                }
                
                if (numeroPagina == 9)
                {
                    guiPrincipal.abrirReporteCliente();
                }

                if (numeroPagina == 10)
                {
                    guiPrincipal.abrirReporteVendedores();
                }

                //Perfil vendedor
                if (numeroPagina == 11)
                {
                    guiPrincipal.abrirSectorVentas();
                }

                if (numeroPagina == 13)
                {
                    guiPrincipal.abrirSectorClientes();
                }

                if (numeroPagina == 14)
                {
                    guiPrincipal.abrirReporteVendedor();
                }

                //Perfil supervisor gerente

                if (numeroPagina == 15)
                {
                    guiPrincipal.abrirSectorBackup();
                }

                if (numeroPagina == 17)
                {
                    guiPrincipal.abrirReportSuper();
                }

            }
        }









        private readonly BdCybergearContext _context;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AccederAMetodoEnGUIPrincipal();
            this.Close();

        }
    }
}
