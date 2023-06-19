using System.Windows;
using MeuCombustivel.VO;
using MeuCombustivel.DAL;
using System.Windows.Controls;


namespace MeuCombustivel
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int idAutomovel;
        string nomeCombustivel;

        double distancia;
        double valor;
        int resultado;
        double consumoPorLitro;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, RoutedEventArgs e)
        {
            
        }
        public void CombustivelGrid(object sender, RoutedEventArgs e)
        {
            combustivelGrid.DataContext = CombustivelDAL.ObterCombustivel();
        }
        public void DataGrid()
        {
              
        }

        private void MeuCombustivel_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void btnCalcular_Click_1(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(txtDistancia.Text, out double distancia) &&
                double.TryParse(txtConsumo.Text, out double consumoPorLitro))
            {
                double quantidadeCombustivel = distancia / consumoPorLitro;

                MessageBox.Show($"Você irá precisar de {quantidadeCombustivel:F2} litros de combustível.");

                // Limpar os campos de entrada
                txtDistancia.Text = "";
                txtConsumo.Text = "";
            }
            else
            {
                MessageBox.Show("Por favor, insira valores numéricos válidos.");
            }
        }

    }
}
