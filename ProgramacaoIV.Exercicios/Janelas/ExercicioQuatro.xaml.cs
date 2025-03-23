using System;
using System.Windows;

namespace ProgramacaoIV.Exercicios.Janelas
{
    public partial class ExercicioQuatro : Window
    {
        public ExercicioQuatro()
        {
            InitializeComponent();
        }

        private void btnVerificarMaioridade_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(txtIdade.Text, out int idade))
            {
                MessageBox.Show(idade >= 18 ? "Voc� e maior de idade." : "Voc� e menor de idade.");
            }
            else
            {
                MessageBox.Show("Digite uma idade valida.");
            }
        }
    }
}
