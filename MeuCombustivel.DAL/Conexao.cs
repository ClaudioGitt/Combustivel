using MySql.Data.MySqlClient;

namespace MeuCombustivel.DAL
{
    public class Conexao
    {
        //Singleton
        //set e get
        private static MySqlConnection? _instance;
        public static MySqlConnection Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new MySqlConnection(@"Server=127.0.0.1;Database=meucombustivel;Uid=root;Pwd=");
                }

                return _instance;
            }
        }
    }
}
