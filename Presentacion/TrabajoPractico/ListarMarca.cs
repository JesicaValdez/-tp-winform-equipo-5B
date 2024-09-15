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
    public partial class ListarMarca : Form
    {
        private List<Marca> listar;
        public ListarMarca()
        {
            InitializeComponent();
        }

        private void ListarMarca_Load(object sender, EventArgs e)
        {
            MarcaNegocio negocio = new MarcaNegocio();
            listar = negocio.ListarMarcas();
            dgv_listarM.DataSource = listar;
        }

        private void btn_atrasM_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
