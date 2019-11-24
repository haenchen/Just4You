﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Just4You.Modules.BasicCalculator;

namespace Just4You.Modules.InputModule
{
    public partial class InputForm : Form
    {

        private double Result;
        public InputForm()
        {
            InitializeComponent();
        }

        public void SetLabel(String labelText)
        {
            labelParam.Text = labelText;
        }

        public Double GetValue()
        {
            return Result;
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            textInput.Text += "7";
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            textInput.Text += "8";
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            textInput.Text += "9";
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            textInput.Text += " % ";
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            textInput.Text += "4";
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            textInput.Text += "5";
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            textInput.Text += "6";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            textInput.Text += " / ";
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            textInput.Text += "1";
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            textInput.Text += "2";
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            textInput.Text += "3";
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            textInput.Text += " * ";
        }

        private void btnComma_Click(object sender, EventArgs e)
        {
            textInput.Text += ",";
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            textInput.Text += "0";
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            textInput.Text += " + ";
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            textInput.Text += " - ";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (textInput.Text.Length > 0)
                textInput.Text.Remove(textInput.Text.Length - 1);
        }

        private void btnParopen_Click(object sender, EventArgs e)
        {
            textInput.Text += "(";
        }

        private void btnParclose_Click(object sender, EventArgs e)
        {
            textInput.Text += ")";
        }

        private void btnAbort_Click(object sender, EventArgs e)
        {
            textInput.Text = "";
            this.Close();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            Result = BasicCalculator.BasicCalculator.Evaluate(textInput.Text);
            if (!GlobalLogger.NewErrorsExist())
            {
                textInput.Text = Result.ToString().Replace(".", ",");
                this.Close();
            }
            btnAbort_Click(sender, e);
        }

        private void btnSidecalc_Click(object sender, EventArgs e)
        {
            var SideForm = new InputForm();
            SideForm.SetLabel("Nebenrechnung");
            SideForm.ShowDialog();
            double sideValue = SideForm.GetValue();
            if (!textInput.Text[textInput.Text.Length - 1].Equals(" "))
                textInput.Text += " ";
            textInput.Text += sideValue.ToString().Replace(".", ",");
        }
    }
}
