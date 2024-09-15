using Dominio;
using Manager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoPractico
{
    public partial class AgregarMarca : Form
    {
        public AgregarMarca()
        {
            InitializeComponent();
        }

        private void btn_aceptarM_Click(object sender, EventArgs e)
        {
            try
            {
               
                Marca marca = new Marca();
                MarcaNegocio negocio = new MarcaNegocio();

                List<Marca> lista = negocio.ListarMarcas();


                marca.Descripcion = txt_agregarM.Text;


                if (string.IsNullOrWhiteSpace(marca.Descripcion))
                {
                    MessageBox.Show("Complete el campo.");
                    return; 
                }

                
                var existeMarca = (from m in lista
                                   where m.Descripcion.Equals(marca.Descripcion, StringComparison.OrdinalIgnoreCase)
                                   select m).Any();

                
                if (!existeMarca)
                {
                    negocio.agregarMarcas(marca);
                    MessageBox.Show("Marca agregada correctamente");
                    Close();
                }
                else
                {
                    MessageBox.Show("Marca existente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_cancelarM_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
