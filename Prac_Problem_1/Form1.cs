using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prac_Problem_1
{
    public partial class frmConverter : Form
    {
        public frmConverter()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            try
            {
                double dAmount = double.Parse(txbAmount.Text);
                String sCurrency1 = cbx1.SelectedItem.ToString();
                String sCurrency2 = cbx2.SelectedItem.ToString();
                Converter cCurrency = new Converter(dAmount, sCurrency1, sCurrency2);
                lblOutput.Text = "Amount: " + cCurrency.getAmount();
            }
            catch (Exception){
                MessageBox.Show("Error !404 Please Try again");
            }
        }

        private void cbx1_SelectedIndexChanged(object sender, EventArgs e)
        {
            object obj1 = "ZAR";
            object obj2 = "USD";
            object obj3 = "EUR";
            switch (cbx1.SelectedItem.ToString())
            {
                case "ZAR":
                    lblSymbol.Text = "R";
                    lblOutput.Text = "";
                    cbx2.Items.Clear();
                    cbx2.Items.Add(obj2);
                    cbx2.Items.Add(obj3);
                    cbx2.Enabled = true;
                    break;

                case "USD":
                    lblSymbol.Text = "$";
                    lblOutput.Text = "";
                    cbx2.Items.Clear();
                    cbx2.Items.Add(obj1);
                    cbx2.Items.Add(obj3);
                    cbx2.Enabled = true;
                    break;

                case "EUR":
                    lblSymbol.Text = "€";
                    lblOutput.Text = "";
                    cbx2.Items.Clear();
                    cbx2.Items.Add(obj2);
                    cbx2.Items.Add(obj1);
                    cbx2.Enabled = true;
                    break;

            }
        }

        private void cbx2_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnConvert.Enabled = true;
        }

        private void lblAmount_Click(object sender, EventArgs e)
        {

        }
    }
}
