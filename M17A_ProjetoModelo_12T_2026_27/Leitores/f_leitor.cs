using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M17A_ProjetoModelo_12T_2026_27.Leitores
{
    public partial class f_leitor : Form
    {
        public f_leitor()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Clique no botão para guardar o leitor na base de dados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            c_leitor novo = new c_leitor();
            novo.set_nome( tb_nome.Text);
            //recolher os dados do form
            //validar os dados do form
            //Estabelecer a ligação à base dados
            //verificar se o email é repetido
            //inserir na base de dados
            //verificar o sucesso da operação
            //desligar da base de dados
        }
    }
}
