using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M17A_ProjetoModelo_12T_2026_27
{
    /// <summary>
    /// Interface para as classes que implementam o CRUD
    /// </summary>
    public  interface icrud
    {
        void adicionar();
        void editar();
        void apagar();
        void listar();

    }
}
