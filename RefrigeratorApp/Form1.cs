using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RefrigeratorApp
{
    public partial class Refrigaretor_Calculation : Form
    {
        public Refrigaretor_Calculation()
        {
            InitializeComponent();
        }
        Refrigerator refri = new Refrigerator();

        private void saveButton_Click(object sender, EventArgs e)
        {
           refri.MaxAmount = Convert.ToDouble(maxamountTextBox.Text);
           //refri.totalCalculation((Convert.ToDouble(itemTextBox.Text)), (Convert.ToDouble(itemTextBox.Text)));
           //currentTextBox.Text = Convert.ToString((refri.TotalAmount));
        }

        private void enterButton_Click(object sender, EventArgs e)
        {

            double tempItem=Convert.ToDouble(itemTextBox.Text);
            double tempWeight = Convert.ToDouble(weightTextBox.Text);
            refri.totalCalculation(tempItem,tempWeight);
            currentTextBox.Text = Convert.ToString((refri.TotalAmount));
            remainTextBox.Text = Convert.ToString(refri.MaxAmount - refri.TotalAmount);
        }
    }
}
