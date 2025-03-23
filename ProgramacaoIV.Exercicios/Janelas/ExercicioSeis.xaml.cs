using System;
using System.Windows;

namespace ProgramacaoIV.Exercicios.Janelas
{
    public partial class ExercicioSeis : Window
    {
        private int contadorCliques = 0;

        public ExercicioSeis()
        {
            InitializeComponent();
        }

        // Método que será chamado quando o botão for clicado
        private void btnContarCliques_Click(object sender, RoutedEventArgs e)
        {
            contadorCliques++;  // Incrementa o contador de cliques
            MessageBox.Show($"Número de cliques: {contadorCliques}");  // Exibe o contador em um MessageBox
        }
    }
}
