using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace ListaDeContatosT7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Um vetor de contatos.
        private Contato[] contatos = new Contato[1];

        private void Escrever(Contato contato)
        {
            StreamWriter escreverEmArquivo = new StreamWriter("contatos.txt");
            escreverEmArquivo.WriteLine(contatos.Length + 1);
            escreverEmArquivo.WriteLine(contato.Nome);
            escreverEmArquivo.WriteLine(contato.Sobrenome);
            escreverEmArquivo.WriteLine(contato.Telefone);

            for (int x = 0; x < contatos .Length; x++)
            {
                escreverEmArquivo.WriteLine(contatos[x].Nome);
                escreverEmArquivo.WriteLine(contatos[x].Sobrenome);
                escreverEmArquivo.WriteLine(contatos[x].Telefone);

            }

            escreverEmArquivo.Close();
        }

        private void button_Click(object sender, EventArgs e)
        {
            // Criar um objeto na classe contato.
            Contato contato = new Contato();
            contato.Nome = TextBoxNome.Text; 
            contato.Sobrenome = TextBoxSobrenome.Text;
            contato.Telefone = TextBoxTelefone.Text;

            ListBoxContato.Items.Add(contato.ToString());
        }
    }
}
