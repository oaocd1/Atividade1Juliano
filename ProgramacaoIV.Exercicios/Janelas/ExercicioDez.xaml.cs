using System;
using System.Windows;

namespace ProgramacaoIV.Exercicios.Janelas
{
    public partial class ExercicioDez : Window
    {
        private Random random = new Random();

        public ExercicioDez()
        {
            InitializeComponent();
        }

        private void btnSortear_Click(object sender, RoutedEventArgs e)
        {
            int numeroSorteado = random.Next(1, 7);
            string mensagem = numeroSorteado == 6 ? "Você ganhou!" : "Tente novamente!";
            MessageBox.Show($"Número sorteado: {numeroSorteado}\n{mensagem}");
        }
    }
}
