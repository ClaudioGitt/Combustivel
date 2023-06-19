using System;
using MeuCombustivel.VO;
namespace MeuCombustivel.VO
{
    public class Combustivel
    {
        public int ID { get; set; }

        public string NomeCombustivel { get; set; }
        public double ValorGasolina { get; set; }
        public double ValorEtanol { get; set; }
        public int AutomovelID { get; set; }

        public Combustivel()
        {
        }

        public Combustivel(string nomeCombustivel, int iD, double valorGasolina, double valorEtanol, int automovelID)
        {
            NomeCombustivel = nomeCombustivel;
            ID = iD;
            ValorGasolina = valorGasolina;
            ValorEtanol = valorEtanol;
            AutomovelID = automovelID;
        }
        public Combustivel (string nomeCombustivel)
        {
            NomeCombustivel=nomeCombustivel;
        }
    }
}
