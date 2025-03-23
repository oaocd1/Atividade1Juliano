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

        // M�todo que ser� chamado quando o bot�o for clicado
        private void btnContarCliques_Click(object sender, RoutedEventArgs e)
        {
            contadorCliques++;  // Incrementa o contador de cliques
            MessageBox.Show($"N�mero de cliques: {contadorCliques}");  // Exibe o contador em um MessageBox
        }
    }
}
