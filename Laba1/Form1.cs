using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Text = "Calculator";
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public interface ICalculator
        {
            public static string Sum(string[] operands)
            {
                return "";
            }

            public static string Diff(string[] operands)
            {
                return "";
            }

            public static string Div(string[] operands)
            {
                return "";
            }

            public static string Mult(string[] operands)
            {
                return "";
            }

            public static string DivRemainder(string[] operands)
            {
                return "";
            }

            public static string IntDivPart(string[] operands)
            {
                return "";
            }
        }

        public class Calculator : ICalculator
        {
            public static string Sum(string[] operands)
            {
                string result;
                if (operands[0].Contains("."))
                {
                    float firstOperand = Convert.ToSingle(operands[0]);
                    float secondOperand = Convert.ToSingle(operands[2]);
                    result = $"{firstOperand + secondOperand}";
                }
                else
                {
                    int firstOperand = Convert.ToInt32(operands[0]);
                    int secondOperand = Convert.ToInt32(operands[2]);
                    result = $"{firstOperand + secondOperand}";
                }
                return result;
            }

            public static string Diff(string[] operands)
            {
                string result;
                if (operands[0].Contains("."))
                {
                    float firstOperand = Convert.ToSingle(operands[0]);
                    float secondOperand = Convert.ToSingle(operands[2]);
                    result = $"{firstOperand - secondOperand}";
                }
                else
                {
                    int firstOperand = Convert.ToInt32(operands[0]);
                    int secondOperand = Convert.ToInt32(operands[2]);
                    result = $"{firstOperand - secondOperand}";
                }
                return result;
            }

            public static string Div(string[] operands)
            {
                string result;
                if (operands[0].Contains("."))
                {
                    float firstOperand = Convert.ToSingle(operands[0]);
                    float secondOperand = Convert.ToSingle(operands[2]);
                    result = $"{firstOperand / secondOperand}";
                }
                else
                {
                    int firstOperand = Convert.ToInt32(operands[0]);
                    int secondOperand = Convert.ToInt32(operands[2]);
                    result = $"{firstOperand / secondOperand}";
                }
                return result;
            }

            public static string Mult(string[] operands)
            {
                string result;
                if (operands[0].Contains("."))
                {
                    float firstOperand = Convert.ToSingle(operands[0]);
                    float secondOperand = Convert.ToSingle(operands[2]);
                    result = $"{firstOperand * secondOperand}";
                }
                else
                {
                    int firstOperand = Convert.ToInt32(operands[0]);
                    int secondOperand = Convert.ToInt32(operands[2]);
                    result = $"{firstOperand * secondOperand}";
                }
                return result;
            }

            public static string DivRemainder(string[] operands)
            {
                string result;
                if (operands[0].Contains("."))
                {
                    float firstOperand = Convert.ToSingle(operands[0]);
                    float secondOperand = Convert.ToSingle(operands[2]);
                    result = $"{firstOperand % secondOperand}";
                }
                else
                {
                    int firstOperand = Convert.ToInt32(operands[0]);
                    int secondOperand = Convert.ToInt32(operands[2]);
                    result = $"{firstOperand % secondOperand}";
                }
                return result;
            }

            public static string IntDivPart(string[] operands)
            {
                string result;
                if (operands[0].Contains("."))
                {
                    float firstOperand = Convert.ToSingle(operands[0]);
                    float secondOperand = Convert.ToSingle(operands[2]);
                    result = $"{Math.Floor(firstOperand / secondOperand)}";
                }
                else
                {
                    int firstOperand = Convert.ToInt32(operands[0]);
                    int secondOperand = Convert.ToInt32(operands[2]);
                    result = $"{firstOperand / secondOperand}";
                }
                return result;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains(" % "))
            {
                textBox1.AppendText(" % ");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains(" // "))
            {
                textBox1.AppendText(" // ");
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains(" + "))
            {
                textBox1.AppendText(" + ");
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains(" - "))
            {
                textBox1.AppendText(" - ");
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("7");
        }
        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("8");
        }
        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("9");
        }
        private void button9_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains(" * "))
            {
                textBox1.AppendText(" * ");
            }
        }
        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("4");
        }
        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("5");
        }
        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("6");
        }
        private void button13_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains(" / "))
            {
                textBox1.AppendText(" / ");
            }
        }
        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("3");
        }
        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("2");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("1");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("0");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains("."))
            {
                textBox1.AppendText(".");
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            string[] operands = textBox1.Text.Split(" ");
            textBox1.Clear();
            switch (operands[1])
            {
                case "+":
                {
                    textBox1.AppendText(Calculator.Sum(operands));
                    break;
                }
                case "-":
                {
                    textBox1.AppendText(Calculator.Diff(operands));
                    break;
                }
                case "/":
                {
                    textBox1.AppendText(Calculator.Div(operands));
                    break;
                }
                case "*":
                {
                    textBox1.AppendText(Calculator.Mult(operands));
                    break;
                }
                case "//":
                {
                    textBox1.AppendText(Calculator.IntDivPart(operands));
                    break;
                }
                case "%":
                {
                    textBox1.AppendText(Calculator.DivRemainder(operands));
                    break;
                }
            }
        }
    }
}
