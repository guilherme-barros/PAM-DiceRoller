using System.Diagnostics;

namespace DiceRoller_Correcao
{
    public partial class MainPage : ContentPage
    {
   

        public MainPage()
        {
            InitializeComponent();
            //Pré-seleciona o indice 0, para que já tenha algo selecionado ao carregar a página
            SelecionarPicker.SelectedIndex = 0;
        }

       private void RollButton_Clicked(object sender, EventArgs e)
        {
            //Conseguir pegar o número que foi selecionado pelo usuário
            //Sortear um número aleatório entre 1 e o número selecionado
            //Exibir o número na label correspondente
            //Adicionar um modificador a cada rolagem de dado
            try
            {
                int numeroSelecionado = Convert.ToInt32(SelecionarPicker.SelectedItem.ToString());
                int quantidadeDeDados = Convert.ToInt32(QuantidadeEntry.Text);
                int totalSoma = 0;
                string todosResultados = "";
                
                //Faça de 0 até a quantidade de dados
                for (int i = 0; i < quantidadeDeDados; i++)
                {
                    Dice dado = new Dice(numeroSelecionado);
                    int modificador = modificadoresPicker.SelectedIndex + 1;
                    int numeroSorteado = dado.Rolar();
                    todosResultados = todosResultados + " " + numeroSorteado + " + " + modificador + "";
                    totalSoma = totalSoma + numeroSorteado + modificador;
                }
                ResultadosLabel.Text = todosResultados.ToString();
                ResultLabel.Text = totalSoma.ToString();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }
    }
}
/*
 * //Método sem a classe
 *       int numeroSelecionado = Convert.ToInt32(SelecionarPicker.SelectedItem.ToString());
 *       int numeroSorteado = new Random().Next(1,numeroSelecionado + 1);
 *       ResultLabel.Text = numeroSorteado.ToString();
 *
 */
