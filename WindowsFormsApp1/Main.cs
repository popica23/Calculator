using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Calculator
{
    public partial class Main : Form
    {

        private EnMathematicalFunctions enMathematicalFunctions;
        private string AuxTxtUserInput = "";
        private string AuxTxtUserInputLeft = "";
        private int indexComma = 1;
        private int indexMyNumbersList = 0;
        private double NumericValue = 0;
        private double NumericValueAux;
        private bool commaIsPressed = false;
        private List<double> MyNumbers = new List<double>();
        private double result = 0;


        public Main()
        {
            InitializeComponent();
        }

        private void TxtBoxUserInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void LbDisplayScreen_Click(object sender, EventArgs e)
        {

        }

        private void Btn00_Click(object sender, EventArgs e)
        {
           // SetNumericValueAux(0,true);
        }

        private void SetNumericValueAux(string ValueAux, bool DoubleOO)
        {
            LbDisplayScreen.Text += ValueAux;
        }

        private void ShowOnDisplay()
        {
            LbDisplayScreen.Text = Convert.ToString(NumericValue);
        }

        private void BtnComma_Click(object sender, EventArgs e)
        {
            commaIsPressed = true;
        }
        private void countAfterComma()
        {
            indexComma++;
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
   LbDisplayScreen.Text = "";
   TxtUserInput.Text = "";
        }

  private void BtnToggleIfElse_Click(object sender, EventArgs e)
  {
   List<KeyValuePair<Button,string>> Tags = tlpOperations.Controls.OfType<Button>().Where(t => t.Tag != null).Where(t=>t.Tag.ToString().Contains(",")).Select(s => new KeyValuePair<Button, string>(s, s.Tag.ToString())).ToList();
   foreach(KeyValuePair<Button, string> k in Tags)
   {
    string[] ops = k.Value.Split(',').ToArray();
    if (ops.Length == 2)
    {
     Button b = k.Key as Button;
     b.Text = b.Text == ops[0] ? ops[1] : ops[0];
    }
   }
  }

        private void GoToNextNumber()
        {
            MyNumbers.Add(NumericValue);
            indexMyNumbersList++;
            refreash();
        }

        private void refreash()
        {
            NumericValue = 0;
            commaIsPressed = false;
            indexComma = 1;
            ShowOnDisplay();
        }


        private void AddToUserInput_Click(object sender, EventArgs e)
        {
            string Symbol = (sender as Button).Text;
            TxtUserInput.Text += LbDisplayScreen.Text + " " + Symbol + " ";
            DoMath();
   LbDisplayScreen.Text = "";
        }

  private void DoMath()
  {
   
  }

  private void SolveEcuation()
        {
            AuxTxtUserInput = TxtUserInput.Text;
            AuxTxtUserInput = AuxTxtUserInput.Replace(" ", "");

            LbDisplayScreen.Text = Convert.ToString(result);

        }

        private void completeRefreash()
        {
            TxtUserInput.Text = "";
            refreash();
        }

        private void BtnEquals_Click(object sender, EventArgs e)
        {
            TxtUserInput.Text += Convert.ToString(NumericValue);
            SolveEcuation();
            completeRefreash();
        }

        private void BtnX_Click(object sender, EventArgs e)
        {
   if (TxtUserInput.SelectedText != "")
   {
    TxtUserInput.SelectedText = "";
   }
   else if (TxtUserInput.SelectedText == "")
   {
    TxtUserInput.Text.Se
   }
   else
   {
    LbDisplayScreen.Text = LbDisplayScreen.Text.Remove(LbDisplayScreen.Text.Length - 1);
   }
  }
  

  private void btnNumeric_Click(object sender, EventArgs e)
  {
   SetNumericValueAux((sender as Button).Tag.ToString(), false);
  }

 }
}
