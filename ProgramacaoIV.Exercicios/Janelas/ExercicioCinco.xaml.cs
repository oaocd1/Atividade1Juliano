using System;
using System.Windows;

namespace ProgramacaoIV.Exercicios.Janelas
{
    public enum TipoUsuario
    {
        Administrador,
        UsuarioComum,
        Visitante
    }

    public partial class ExercicioCinco : Window
    {
        public ExercicioCinco()
        {
            InitializeComponent();
            comboBoxTipoUsuario.ItemsSource = Enum.GetValues(typeof(TipoUsuario));
        }

        private void btnExibirDescricao_Click(object sender, RoutedEventArgs e)
        {
            if (comboBoxTipoUsuario.SelectedItem != null)
            {
                var tipoUsuario = (TipoUsuario)comboBoxTipoUsuario.SelectedItem;
                MessageBox.Show($"Descricao: {tipoUsuario}");
            }
        }
    }
}
