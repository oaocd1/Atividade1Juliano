using System;
using System.Windows;

namespace ProgramacaoIV.Exercicios.Janelas
{
    public partial class ExercicioDois : Window
    {
        public ExercicioDois()
        {
            InitializeComponent();
        }

        private void btnConverter_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double celsius = Convert.ToDouble(txtCelsius.Text);
                double fahrenheit = (celsius * 9 / 5) + 32;
                MessageBox.Show($"Temperatura em Fahrenheit: {fahrenheit}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Por favor, insira um valor valido.");
            }
        }
    }
}
