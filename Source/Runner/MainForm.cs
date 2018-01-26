using SequenceAnalysis;
using SumOfMultiple;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Runner
{
    public partial class MainForm : Form
    {
        private SumOfMultiplesOf3And5 _sumOfMultiplesCalcultor;
        private UpperCaseWordsAnalyer _stringAnalyzer;

        public string ErrorText
        {
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    resultLabel.ForeColor = System.Drawing.Color.Red;
                    resultLabel.Text = value;
                }
            }
        }

        public string ResultText
        {
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    resultLabel.ForeColor = System.Drawing.Color.Green;
                    resultLabel.Text = value;
                }
            }
        }

        public MainForm()
        {
            InitializeComponent();
            _sumOfMultiplesCalcultor = new SumOfMultiplesOf3And5();
            _stringAnalyzer = new UpperCaseWordsAnalyer();

        }

        private void sumOfMultiplesButton_Click(object sender, EventArgs e)
        {
            int input = 0;
            if (int.TryParse(inputRichTextBox.Text, out input))
            {
                this.ResultText = _sumOfMultiplesCalcultor.SumOfMultiplesOfThreeAndFive(input).ToString();
            }
            else
            {
                this.ErrorText = "Given input is not a number or not withing given boundaries between 4 and 2147483647";
            }
        }

        private void sequenceAnalyzerButton_Click(object sender, EventArgs e)
        {
            var output = _stringAnalyzer.Analize(inputRichTextBox.Text);
            if (string.IsNullOrEmpty(output))
            {
                output = "Given string doesn't contain upper case words";
            }

            this.ResultText = output;
        }

        private void inputRichTextBox_Enter(object sender, EventArgs e)
        {
            inputRichTextBox.Text = string.Empty;
            resultLabel.Text = string.Empty;
        }
    }
}
