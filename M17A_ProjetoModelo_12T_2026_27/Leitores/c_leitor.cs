using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M17A_ProjetoModelo_12T_2026_27.Leitores
{
    /// <summary>
    /// Responsável pelo CRUD na tabela leitores
    /// Implementa pesquisa do leitor por nome e email
    /// </summary>
    public class c_leitor : icrud
    {
        public int id;
        public string nome;
        public string email;
        public DateTime data_nasc;
        public bool estado;        //0-bloqueado 1-ativo
        
        /// <summary>
        /// Função para validar os dados antes de inserir na bd
        /// </summary>
        /// <returns>String vazia se não tiver erros ou mensagem com erros</returns>
        public string ValidarDados()
        {
            return "";
        }
        //CRUD
        public void adicionar() 
        {
            string sql = $@"INSERT INTO Leitores(nome,email,datanascimento) 
                        VALUES (@nome,@email,@datanascimento)";
            //definir os valores dos parâmetros
            //executar comando sql na base de dados

        }

        public void apagar()
        {
            throw new NotImplementedException();
        }

        public void editar()
        {
            throw new NotImplementedException();
        }

        public void listar()
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Para mostrar o nome e o id do leitor na combo box
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return nome + $" - {id}";
        }
    }
}
