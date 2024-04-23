using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaDeContatosT7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            // Criar um objeto na classe contato.
            Contato contato = new Contato();
            contato.Nome = TextBoxNome.Text; 
            contato.Sobrenome = TextBoxSobrenome.Text;
            contato.Telefone = textBoxTelefone.Text;

            ListBoxContato.Itens.Add(contato);
        }
    }
}
