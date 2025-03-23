using System;
using System.Windows;
using System.Windows.Controls;

namespace ProgramacaoIV.Exercicios.Janelas
{
    public partial class ExercicioSete : Window
    {
        public ExercicioSete()
        {
            InitializeComponent();
        }

        private void btnCalcularParcela_Click(object sender, RoutedEventArgs e)
        {
            // Tenta converter o valor total inserido
            if (double.TryParse(txtValorTotal.Text, out double valorTotal) &&
                cmbParcelas.SelectedItem is ComboBoxItem selectedItem && // Verifica se o item selecionado é um ComboBoxItem
                int.TryParse(selectedItem.Content.ToString(), out int numParcelas)) // Converte o conteúdo do ComboBoxItem para número de parcelas
            {
                double valorParcela = valorTotal / numParcelas;
                MessageBox.Show($"Valor da Parcela: {valorParcela:C}");
            }
            else
            {
                MessageBox.Show("Por favor, insira um valor válido e selecione o número de parcelas.");
            }
        }
    }
}
