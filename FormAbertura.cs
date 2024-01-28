using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Organizador_2._0
{
    partial class FormAbertura : Form
    {
        // Adicione isso se não existir
        internal FormAbertura()
        {
            InitializeComponent();
            // Configurações adicionais, se houver...
        } 

        private async void FormAbertura_Shown(object sender, EventArgs e)
        {
            // Aguarde 3 segundos
            await Task.Delay(1000);

            // Inicie o Form2
            Form2 form2 = new Form2();
            form2.Show();

            // Feche o formulário atual
            this.Hide(); // Use Hide() para ocultar, em vez de Close()
        }
    }
}