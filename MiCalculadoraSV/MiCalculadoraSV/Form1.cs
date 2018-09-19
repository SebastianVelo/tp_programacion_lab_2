using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiCalculadoraSV
{
    public partial class MiCalculadora : Form
    {

        /**|||||||||||||||||||||||||||||||||||||||||||||**/
        /** CONSTRUCTOR **/
        public MiCalculadora()
        {
            InitializeComponent();
        }
        /**|||||||||||||||||||||||||||||||||||||||||||||**/
        /** FUNCIONES PRIVADAS **/
        private void Clear(TextBox txt)
        {
            txt.Text = "";
        }

        /**|||||||||||||||||||||||||||||||||||||||||||||**/
        /** BUTTONS **/
        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear(txtNumber1);
            Clear(txtNumber2);
            Clear(txtResult);
            cmbOperator.SelectedIndex = 0;
        }

        private void btnExit_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnDoMath_Click(object sender, EventArgs e)
        {
            Number one = new Number(txtNumber1.Text);
            Number two = new Number(txtNumber2.Text);
            Number result = Number.GetResult(one, two, cmbOperator.Text);
            txtResult.Text = result.GetNumber();          
        }

        private void btnConvertToBin_Click(object sender, EventArgs e)
        {
            Number one = new Number(txtNumber1.Text);
            Number two = new Number(txtNumber2.Text);
            Number result = new Number(txtResult.Text);
            txtNumber1.Text = one.ToBinary();
            txtNumber2.Text = two.ToBinary();
            txtResult.Text = result.ToBinary();
        }

        private void btnConvertToDec_Click(object sender, EventArgs e)
        {
            Number one = new Number(txtNumber1.Text);
            Number two = new Number(txtNumber2.Text);
            Number result = new Number(txtResult.Text);
            txtNumber1.Text = one.ToDecimal();
            txtNumber2.Text = two.ToDecimal();
            txtResult.Text = result.ToDecimal();
        }
    }
}
