using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M17A_ProjetoModelo_12T_2026_27
{
    /// <summary>
    /// Estabelece a ligação à bd
    /// Se a bd não existir tem de criar
    /// Executar comandos SQL (consultas,ações)
    /// Versão simplificada que não faz o tratamento de exceções
    /// </summary>
    public class BaseDados
    {
        string strligacao;
        string NomeBD;
        string CaminhoBD;
        SqlConnection ligacaoBD;

        public BaseDados(string NomeBD)
        {
            //abrir a ligação ao servidor de bd
            strligacao=ConfigurationManager.ConnectionStrings["sql"].ToString();
            this.NomeBD = NomeBD;
            //verificar se a bd existe
            CaminhoBD = Utils.PastaDoPrograma("M17A_12T_TrabalhoModelo");
            CaminhoBD += @"\" + NomeBD + ".mdf";
            //criar a bd e as tabelas caso não exista
            if (System.IO.File.Exists(CaminhoBD) == false)
                CriarBD();

        }
    }
}
