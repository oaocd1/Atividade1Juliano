using System;
using System.Windows;

namespace ProgramacaoIV.Exercicios.Janelas
{
    public partial class ExercicioNove : Window
    {
        private bool isLigado = false;

        public ExercicioNove()
        {
            InitializeComponent();
        }

        private void btnAlternar_Click(object sender, RoutedEventArgs e)
        {
            isLigado = !isLigado;
            btnAlternar.Content = isLigado ? "Ligado" : "Desligado";
            MessageBox.Show(isLigado ? "Está Ligado!" : "Está Desligado!");
        }
    }
}
