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
        /// <summary>
        /// Cria a base de dados e as respetivas tabelas
        /// </summary>
        private void CriarBD()
        {
            //Ligar ao servidor de bd
            ligacaoBD = new SqlConnection(strligacao);
            ligacaoBD.Open();
            //Verificar se já existe uma bd com o mesmo nome
            string sql = $@"
                    IF EXISTS(SELECT * FROM master.sys.databases WHERE name='{this.NomeBD}' )
                    BEGIN
                        USE [master];
                        EXEC sp_detach_db {this.NomeBD};
                    END
                ";
            SqlCommand comando = new SqlCommand(sql,ligacaoBD);
            comando.ExecuteNonQuery();
            //criar a bd
            sql = $"CREATE DATABASE {this.NomeBD} ON PRIMARY (NAME={this.NomeBD},FILENAME='{this.CaminhoBD}')";
            comando = new SqlCommand(sql, ligacaoBD);
            comando.ExecuteNonQuery();

            CriarTabelas();
        }
        void CriarTabelas()
        {
            //Selecionar a base de dados
            ligacaoBD.ChangeDatabase(this.NomeBD);
            //criar a tabela livros

            //criar a tabela leitores
            string sql = @"
                IF (OBJECT_ID('Leitores') IS NULL)
                BEGIN
                    CREATE TABLE Leitores(
                        id INT IDENTITY PRIMARY KEY,
                        Nome VARCHAR(40) NOT NULL CHECK (LEN(Nome)>=3),
                        Email VARCHAR(60) NOT NULL CHECK (Email Like '%@%.%'),
                        DataNascimento DATE NOT NULL CHECK (DataNascimento<GETDATE()),
                        Estado BIT DEFAULT (1)
                    )
                END
            ";
            SqlCommand comando = new SqlCommand(sql, ligacaoBD);
            comando.ExecuteNonQuery();
            comando.Dispose();
            //criar a tabela emprestimos
        }
    }
}
