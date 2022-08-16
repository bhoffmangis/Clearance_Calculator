using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Clearance_Calculator
{
    public partial class ClearanceCalculator : Form
    {
        public ClearanceCalculator()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal mClear; // measured clearance
            decimal cShim;  // current shim
            decimal rShim;  // replacement shim
            decimal rClear; // resulting clearance
            bool areValidInputs;

            areValidInputs = SetInputs(out mClear, out cShim, out rShim);

            if (areValidInputs == true)
            {
                rClear = (mClear + cShim) - rShim;
                DisplayResult(rClear);
            }
        }

        private bool SetInputs(out decimal mC, out decimal cS, out decimal rS)
        {
            bool allValid = true;
            bool mCValid;
            bool cSValid;
            bool rSValid;

            mCValid = Decimal.TryParse(txtMeasuredClearance.Text, out mC) && (mC >= 0);
            cSValid = Decimal.TryParse(txtCurrentShim.Text, out cS) && (cS >= 0);
            rSValid = Decimal.TryParse(txtReplacementShim.Text, out rS) && (rS >= 0);

            if (mCValid == false)
            {
                allValid = false;
                MessageBox.Show("Measured clearance must be a non-negative number!",
                    "Invalid Measured Clearance", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMeasuredClearance.Focus();
                txtMeasuredClearance.SelectAll();
            }

            else if (cSValid == false)
            {
                allValid = false;
                MessageBox.Show("Current shim size must be a non-negative number!",
                    "Invalid Current Shim Size", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCurrentShim.Focus();
                txtCurrentShim.SelectAll();
            }

            else if (rSValid == false)
            {
                allValid = false;
                MessageBox.Show("Replacement shim size must be a non-negative number!",
                    "Invalid Replacement Shim Size", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtReplacementShim.Focus();
                txtReplacementShim.SelectAll();
            }

            return allValid;
        }

        private void DisplayResult(decimal rC)
        {
            lblResultingClearance.Text = rC.ToString("f3");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMeasuredClearance.Text = String.Empty;
            txtCurrentShim.Text = String.Empty;
            txtReplacementShim.Text = String.Empty;
            lblResultingClearance.Text = String.Empty;
        }

        private void txtReplacementShim_TextChanged(object sender, EventArgs e)
        {
            lblResultingClearance.Text = String.Empty;
        }

        private void txtMeasuredClearance_TextChanged(object sender, EventArgs e)
        {
            txtCurrentShim.Text = String.Empty;
            txtReplacementShim.Text = String.Empty;
            lblResultingClearance.Text = String.Empty;
        }
    }
}
