using Data;
using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms
{
    public partial class Form1 : Form
    {

        private ProductDbContext context;//Instancia o dbcontext

        public Form1()
        {
            InitializeComponent();

            context = new ProductDbContext();//inicializa o ProductDbContext
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Loja loja = new Loja()//instancia um novo objeto loja
            {
                Nome = "Loja Teste DevMedia"//parametro nome recebe o valor
            };
            context.Lojas.Add(loja);//adiciona o objeto loja no context

            Produto produto = new Produto()
            {
                Nome = "Produto de teste DevMedia",
                Valor = 20m,
                Loja = loja
            };
            context.Produtos.Add(produto);

            context.SaveChanges();//salva as alterações no context
        }
    }
}
