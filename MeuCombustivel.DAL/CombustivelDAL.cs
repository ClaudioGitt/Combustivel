using MeuCombustivel.VO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;


namespace MeuCombustivel.DAL
{
    public class CombustivelDAL
    {
        public void InserirCombustivel(Combustivel combustivel)
        {
            Conexao.Instance.Open();
            MySqlCommand cmd = Conexao.Instance.CreateCommand();
            cmd.CommandType=System.Data.CommandType.Text;
            cmd.CommandText = "INSERT INTO meucombustivel (ValorGasolina,ValorEtanol,AutomovelID) VALUES (@ValorGasolina, @ValorEtanol, @AutomovelID)";

            cmd.Parameters.AddWithValue("@ValorGasolina", combustivel.ValorGasolina);
            cmd.Parameters.AddWithValue("@ValorEtanol", combustivel.ValorEtanol);
            cmd.Parameters.AddWithValue("@AutomovelID", combustivel.AutomovelID);
            cmd.ExecuteNonQuery();
            Conexao.Instance.Close();
        }
        public static List<Combustivel> ObterCombustivel()
        {
            Conexao.Instance.Open();
            MySqlCommand comando=Conexao.Instance.CreateCommand();
            comando.CommandType=System.Data.CommandType.Text;
            comando.CommandText = "SELECT*FROM meucombustivel";
            MySqlDataReader reader = comando.ExecuteReader();
            List<Combustivel> combustivels = new List<Combustivel>();
            while (reader.Read()) 
            {
                Combustivel combustivel = new Combustivel();
                combustivel.ID = Convert.ToInt32(reader["ID"]);
                combustivel.ValorGasolina = Convert.ToInt32(reader["ValorGasolina"]);
                combustivel.ValorEtanol = Convert.ToInt32(reader["ValorEtanol"]);
                combustivel.AutomovelID = Convert.ToInt32(reader["AutomovelID"]);
            }
            reader.Close();
            Conexao.Instance.Close();
            return combustivels;

        }
    }
}
