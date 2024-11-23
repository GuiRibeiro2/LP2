using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace PContato0030482413037
{
    public partial class frmPrincipal : Form
    {
        public static SqlConnection conexao;
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection("Data Source=Felipe_Notebook\\SQLEXPRESS;Initial Catalog=LP2;Integrated Security=True");
                conexao.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao abrir o banco de dados"+ex.Message);
            }
        }

        private void cadastroContatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["frmContato"];

            if (fc != null) 
                fc.Close();

            frmContato FRMC = new frmContato();
            FRMC.MdiParent = this;
            FRMC.WindowState = FormWindowState.Maximized;
            FRMC.Show();
                
            }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["frmSobre"];

            if (fc != null)
                fc.Close();

            frmSobre FRMC = new frmSobre();
            FRMC.MdiParent = this;
            FRMC.WindowState = FormWindowState.Maximized;
            FRMC.Show();
        }
    }
    }

