using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio_de_multiplas_janelas
{
    public partial class CriarCliente : Form
    {
        public string Nome { get { return nomeCliente.Text; } }
        public string Telefone { get { return telefoneCliente.Text; } }
        public string Email { get { return emailCliente.Text; } }

        public string Endereco
        {
            get
            {
                string endereco = "";
                endereco += $"({complementoCliente.Text}), ";
                endereco += $"({numeroCliente.Text}), ";
                endereco += $"({complementoCliente.Text}), ";
                endereco += $"({cidadeCliente.Text} - {ufCliente.Text}), ";
                endereco += $"CEP: {complementoCliente.Text}";
                return endereco;
            }
        }
        public CriarCliente()
        {
            InitializeComponent();
        }

        private void CriarCliente_Load(object sender, EventArgs e)
        {

        }

        private void okbutton2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cancelarbutton1_Click(object sender, EventArgs e)
        {
            this.DialogResult= DialogResult.Cancel;
            this.Close();
        }
    }
}
