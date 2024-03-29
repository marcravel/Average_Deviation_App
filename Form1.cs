using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Average_Deviation_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            valuesListBox.Items.Clear();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (valueTextBox.Text != string.Empty)
            {
                valuesListBox.Items.Add(Convert.ToDecimal(valueTextBox.Text));
            }
            else
            {
                valueTextBox.Focus();
            }
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            decimal avg = 0;
            if (valuesListBox.Items.Count > 0)
            {
                foreach (var item in valuesListBox.Items)
                {
                    avg += Decimal.Parse(item.ToString());
                }
                avg /= valuesListBox.Items.Count;
            }

            if (averageRadio.Checked)
            {               
                resultRichText.Text = $"{avg}";
            }
            else if (deviationRadio.Checked)
            {
                if (valuesListBox.SelectedIndex < 0)
                {
                    valueTextBox.Text = "Select a value";
                }
                else
                {
                    decimal dev = Decimal.Parse(valuesListBox.Items[valuesListBox.SelectedIndex].ToString()) - avg;
                    resultRichText.Text = $"Deviation of {valuesListBox.Items[valuesListBox.SelectedIndex].ToString()} " +
                        $": {dev}";
                }

            }
            else if (deviationAvgRadio.Checked)
            {

            }
            else if (standartDeviationRadio.Checked)
            {

            }

        }

        private void valueTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!string.IsNullOrEmpty(valueTextBox.Text) && e.KeyChar == (char)Keys.Return)
            { 
                valuesListBox.Items.Add(valueTextBox.Text);
                valueTextBox.Text = string.Empty;
            }
            else if (valuesListBox.Items.Count > 0 && e.KeyChar == 'c')
            {
                calculateBtn.PerformClick();
            }
        }
    }
}
