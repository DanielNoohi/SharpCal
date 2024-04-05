using System;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class CalculatorForm : Form
    {
        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBox.Text += button.Text;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBox.Text = "";
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            try
            {
                var result = new System.Data.DataTable().Compute(textBox.Text, null);
                textBox.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid expression: " + ex.Message);
            }
        }
    }
}
