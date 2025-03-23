using System;
using System.Windows;

namespace ProgramacaoIV.Exercicios.Janelas
{
    public partial class ExercicioOito : Window
    {
        public ExercicioOito()
        {
            InitializeComponent();
        }

        private void btnVerificarDia_Click(object sender, RoutedEventArgs e)
        {
            if (dpData.SelectedDate.HasValue)
            {
                var diaSemana = dpData.SelectedDate.Value.DayOfWeek;
                MessageBox.Show($"O dia da semana é: {diaSemana}");
            }
            else
            {
                MessageBox.Show("Por favor, selecione uma data.");
            }
        }
    }
}
