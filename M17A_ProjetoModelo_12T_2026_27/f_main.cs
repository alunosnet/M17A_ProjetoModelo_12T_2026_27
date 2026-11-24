using M17A_ProjetoModelo_12T_2026_27.Leitores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M17A_ProjetoModelo_12T_2026_27
{
    public partial class f_main : Form
    {
        BaseDados bd=new BaseDados("Biblioteca_12T");
        public f_main()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Opção menu Editar->Leitores
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void leitoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f_leitor f = new f_leitor(bd);
            f.Show();
        }
    }
}
