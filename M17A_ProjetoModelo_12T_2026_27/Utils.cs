using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M17A_ProjetoModelo_12T_2026_27
{
    internal class Utils
    {
        /// <summary>
        /// Verifica se a pasta existe se não existir cria a pasta com o nome indicado
        /// </summary>
        /// <param name="nome">Nome da pasta</param>
        /// <returns>Caminho completo para a pasta</returns>
        public static string PastaDoPrograma(string nome)
        {
            string pastainicial = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            pastainicial += @"\" + nome;
            if (System.IO.Directory.Exists(pastainicial) == false)
                System.IO.Directory.CreateDirectory(pastainicial);
            return pastainicial;
        }
    }
}
