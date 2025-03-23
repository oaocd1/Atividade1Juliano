using System;
using System.Windows;

namespace ProgramacaoIV.Exercicios.Janelas
{
    public partial class ExercicioTres : Window
    {
        public ExercicioTres()
        {
            InitializeComponent();
        }

        private void btnCalcularAniversario_Click(object sender, RoutedEventArgs e)
        {
            DateTime nascimento = datePickerNascimento.SelectedDate ?? DateTime.Now;
            DateTime proximoAniversario = new DateTime(DateTime.Now.Year, nascimento.Month, nascimento.Day);

            if (proximoAniversario < DateTime.Now)
                proximoAniversario = proximoAniversario.AddYears(1);


            int diasRestantes = (proximoAniversario - DateTime.Now).Days;

            MessageBox.Show($"Faltam {diasRestantes} dias para o próximo aniversário.");
        }
    }
}
