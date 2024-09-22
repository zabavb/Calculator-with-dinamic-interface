using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace Seventh_lesson_csh_wf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetButtons();
            labelOutput.Text = "0";
        }

        System.Windows.Forms.Button buttonAC = new System.Windows.Forms.Button();
        System.Windows.Forms.Button buttoIntegerDivision = new System.Windows.Forms.Button();
        System.Windows.Forms.Button buttonDevision = new System.Windows.Forms.Button();
        System.Windows.Forms.Button buttonMultiplication = new System.Windows.Forms.Button();
        System.Windows.Forms.Button buttonMinus = new System.Windows.Forms.Button();
        System.Windows.Forms.Button buttonPlus = new System.Windows.Forms.Button();
        System.Windows.Forms.Button buttonEqual = new System.Windows.Forms.Button();
        System.Windows.Forms.Button buttonEight = new System.Windows.Forms.Button();
        System.Windows.Forms.Button buttonNine = new System.Windows.Forms.Button();
        System.Windows.Forms.Button button2 = new System.Windows.Forms.Button();
        System.Windows.Forms.Button buttonFour = new System.Windows.Forms.Button();
        System.Windows.Forms.Button button5 = new System.Windows.Forms.Button();
        System.Windows.Forms.Button buttonSix = new System.Windows.Forms.Button();
        System.Windows.Forms.Button buttonOne = new System.Windows.Forms.Button();
        System.Windows.Forms.Button buttonTwo = new System.Windows.Forms.Button();
        System.Windows.Forms.Button buttonTree = new System.Windows.Forms.Button();
        System.Windows.Forms.Button buttonZero = new System.Windows.Forms.Button();
        System.Windows.Forms.Button buttonDelate = new System.Windows.Forms.Button();

        Calculator calculator = new Calculator();

        public void SetButtons()
        {
            // 
            // buttonAC
            // 
            this.buttonAC.BackColor = System.Drawing.Color.Silver;
            this.buttonAC.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.buttonAC.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonAC.Location = new System.Drawing.Point(0, 116);
            this.buttonAC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAC.Name = "buttonAC";
            this.buttonAC.Size = new System.Drawing.Size(119, 67);
            this.buttonAC.TabIndex = 1;
            this.buttonAC.Text = "AC";
            this.buttonAC.UseVisualStyleBackColor = false;
            this.buttonAC.Click += new System.EventHandler(this.buttonAC_Click);
            // 
            // buttoIntegerDivision
            // 
            this.buttoIntegerDivision.BackColor = System.Drawing.Color.Silver;
            this.buttoIntegerDivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttoIntegerDivision.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttoIntegerDivision.Location = new System.Drawing.Point(117, 116);
            this.buttoIntegerDivision.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttoIntegerDivision.Name = "buttoIntegerDivision";
            this.buttoIntegerDivision.Size = new System.Drawing.Size(62, 67);
            this.buttoIntegerDivision.TabIndex = 2;
            this.buttoIntegerDivision.Text = "%";
            this.buttoIntegerDivision.UseVisualStyleBackColor = false;
            this.buttoIntegerDivision.Click += new System.EventHandler(this.buttoIntegerDivision_Click);
            // 
            // buttonDevision
            // 
            this.buttonDevision.BackColor = System.Drawing.Color.Orange;
            this.buttonDevision.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDevision.ForeColor = System.Drawing.Color.White;
            this.buttonDevision.Location = new System.Drawing.Point(177, 116);
            this.buttonDevision.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonDevision.Name = "buttonDevision";
            this.buttonDevision.Size = new System.Drawing.Size(62, 67);
            this.buttonDevision.TabIndex = 3;
            this.buttonDevision.Text = "/";
            this.buttonDevision.UseVisualStyleBackColor = false;
            this.buttonDevision.Click += new System.EventHandler(this.buttonDevision_Click);
            // 
            // buttonMultiplication
            // 
            this.buttonMultiplication.BackColor = System.Drawing.Color.Orange;
            this.buttonMultiplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMultiplication.ForeColor = System.Drawing.Color.White;
            this.buttonMultiplication.Location = new System.Drawing.Point(177, 181);
            this.buttonMultiplication.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonMultiplication.Name = "buttonMultiplication";
            this.buttonMultiplication.Size = new System.Drawing.Size(62, 67);
            this.buttonMultiplication.TabIndex = 4;
            this.buttonMultiplication.Text = "X";
            this.buttonMultiplication.UseVisualStyleBackColor = false;
            this.buttonMultiplication.Click += new System.EventHandler(this.buttonMultiplication_Click);
            // 
            // buttonMinus
            // 
            this.buttonMinus.BackColor = System.Drawing.Color.Orange;
            this.buttonMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMinus.ForeColor = System.Drawing.Color.White;
            this.buttonMinus.Location = new System.Drawing.Point(177, 246);
            this.buttonMinus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(62, 67);
            this.buttonMinus.TabIndex = 5;
            this.buttonMinus.Text = "-";
            this.buttonMinus.UseVisualStyleBackColor = false;
            this.buttonMinus.Click += new System.EventHandler(this.buttonMinus_Click);
            // 
            // buttonPlus
            // 
            this.buttonPlus.BackColor = System.Drawing.Color.Orange;
            this.buttonPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPlus.ForeColor = System.Drawing.Color.White;
            this.buttonPlus.Location = new System.Drawing.Point(177, 311);
            this.buttonPlus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(62, 67);
            this.buttonPlus.TabIndex = 6;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = false;
            this.buttonPlus.Click += new System.EventHandler(this.buttonPlus_Click);
            // 
            // buttonEqual
            // 
            this.buttonEqual.BackColor = System.Drawing.Color.Orange;
            this.buttonEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEqual.ForeColor = System.Drawing.Color.White;
            this.buttonEqual.Location = new System.Drawing.Point(177, 376);
            this.buttonEqual.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonEqual.Name = "buttonEqual";
            this.buttonEqual.Size = new System.Drawing.Size(62, 67);
            this.buttonEqual.TabIndex = 7;
            this.buttonEqual.Text = "=";
            this.buttonEqual.UseVisualStyleBackColor = false;
            this.buttonEqual.Click += new System.EventHandler(this.buttonEqual_Click);
            // 
            // buttonEight
            // 
            this.buttonEight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonEight.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEight.ForeColor = System.Drawing.Color.White;
            this.buttonEight.Location = new System.Drawing.Point(58, 181);
            this.buttonEight.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonEight.Name = "buttonEight";
            this.buttonEight.Size = new System.Drawing.Size(62, 67);
            this.buttonEight.TabIndex = 8;
            this.buttonEight.Text = "8";
            this.buttonEight.UseVisualStyleBackColor = false;
            this.buttonEight.Click += new System.EventHandler(this.buttonEight_Click);
            // 
            // buttonNine
            // 
            this.buttonNine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonNine.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNine.ForeColor = System.Drawing.Color.White;
            this.buttonNine.Location = new System.Drawing.Point(117, 181);
            this.buttonNine.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonNine.Name = "buttonNine";
            this.buttonNine.Size = new System.Drawing.Size(62, 67);
            this.buttonNine.TabIndex = 9;
            this.buttonNine.Text = "9";
            this.buttonNine.UseVisualStyleBackColor = false;
            this.buttonNine.Click += new System.EventHandler(this.buttonNine_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(0, 181);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(62, 67);
            this.button2.TabIndex = 10;
            this.button2.Text = "7";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonFour
            // 
            this.buttonFour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonFour.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFour.ForeColor = System.Drawing.Color.White;
            this.buttonFour.Location = new System.Drawing.Point(0, 246);
            this.buttonFour.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonFour.Name = "buttonFour";
            this.buttonFour.Size = new System.Drawing.Size(62, 67);
            this.buttonFour.TabIndex = 11;
            this.buttonFour.Text = "4";
            this.buttonFour.UseVisualStyleBackColor = false;
            this.buttonFour.Click += new System.EventHandler(this.buttonFour_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(58, 246);
            this.button5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(62, 67);
            this.button5.TabIndex = 12;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // buttonSix
            // 
            this.buttonSix.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonSix.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSix.ForeColor = System.Drawing.Color.White;
            this.buttonSix.Location = new System.Drawing.Point(117, 246);
            this.buttonSix.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSix.Name = "buttonSix";
            this.buttonSix.Size = new System.Drawing.Size(62, 67);
            this.buttonSix.TabIndex = 13;
            this.buttonSix.Text = "6";
            this.buttonSix.UseVisualStyleBackColor = false;
            this.buttonSix.Click += new System.EventHandler(this.buttonSix_Click);
            // 
            // buttonOne
            // 
            this.buttonOne.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOne.ForeColor = System.Drawing.Color.White;
            this.buttonOne.Location = new System.Drawing.Point(0, 311);
            this.buttonOne.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonOne.Name = "buttonOne";
            this.buttonOne.Size = new System.Drawing.Size(62, 67);
            this.buttonOne.TabIndex = 14;
            this.buttonOne.Text = "1";
            this.buttonOne.UseVisualStyleBackColor = false;
            this.buttonOne.Click += new System.EventHandler(this.buttonOne_Click);
            // 
            // buttonTwo
            // 
            this.buttonTwo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTwo.ForeColor = System.Drawing.Color.White;
            this.buttonTwo.Location = new System.Drawing.Point(58, 311);
            this.buttonTwo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonTwo.Name = "buttonTwo";
            this.buttonTwo.Size = new System.Drawing.Size(62, 67);
            this.buttonTwo.TabIndex = 15;
            this.buttonTwo.Text = "2";
            this.buttonTwo.UseVisualStyleBackColor = false;
            this.buttonTwo.Click += new System.EventHandler(this.buttonTwo_Click);
            // 
            // buttonTree
            // 
            this.buttonTree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonTree.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTree.ForeColor = System.Drawing.Color.White;
            this.buttonTree.Location = new System.Drawing.Point(117, 311);
            this.buttonTree.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonTree.Name = "buttonTree";
            this.buttonTree.Size = new System.Drawing.Size(62, 67);
            this.buttonTree.TabIndex = 16;
            this.buttonTree.Text = "3";
            this.buttonTree.UseVisualStyleBackColor = false;
            this.buttonTree.Click += new System.EventHandler(buttonTree_Click);
            // 
            // buttonZero
            // 
            this.buttonZero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonZero.ForeColor = System.Drawing.Color.White;
            this.buttonZero.Location = new System.Drawing.Point(0, 376);
            this.buttonZero.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonZero.Name = "buttonZero";
            this.buttonZero.Size = new System.Drawing.Size(178, 67);
            this.buttonZero.TabIndex = 17;
            this.buttonZero.Text = "0";
            this.buttonZero.UseVisualStyleBackColor = false;
            this.buttonZero.Click += new System.EventHandler(this.buttonZero_Click);
            // 
            // buttonDelate
            // 
            this.buttonDelate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonDelate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelate.ForeColor = System.Drawing.Color.White;
            this.buttonDelate.Location = new System.Drawing.Point(177, 39);
            this.buttonDelate.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDelate.Name = "buttonDelate";
            this.buttonDelate.Size = new System.Drawing.Size(62, 40);
            this.buttonDelate.TabIndex = 20;
            this.buttonDelate.Text = "<";
            this.buttonDelate.UseVisualStyleBackColor = false;
            this.buttonDelate.Click += new System.EventHandler(this.buttonDelate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(238, 441);
            this.Controls.Add(this.buttonDelate);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.buttonZero);
            this.Controls.Add(this.buttonTree);
            this.Controls.Add(this.buttonTwo);
            this.Controls.Add(this.buttonOne);
            this.Controls.Add(this.buttonSix);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.buttonFour);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonNine);
            this.Controls.Add(this.buttonEight);
            this.Controls.Add(this.buttonEqual);
            this.Controls.Add(this.buttonPlus);
            this.Controls.Add(this.buttonMinus);
            this.Controls.Add(this.buttonMultiplication);
            this.Controls.Add(this.buttonDevision);
            this.Controls.Add(this.buttoIntegerDivision);
            this.Controls.Add(this.buttonAC);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

            this.Controls.Add(button2);
            this.Controls.Add(button5);
            this.Controls.Add(buttonAC);
            this.Controls.Add(buttonDelate);
            this.Controls.Add(buttonDevision);
            this.Controls.Add(buttonEight);
            this.Controls.Add(buttonEqual);
            this.Controls.Add(buttonFour);
            this.Controls.Add(buttonMinus);
            this.Controls.Add(buttonMultiplication);
            this.Controls.Add(buttonNine);
            this.Controls.Add(buttonOne);
            this.Controls.Add(buttonPlus);
            this.Controls.Add(buttonSix);
            this.Controls.Add(buttonTree);
            this.Controls.Add(buttonTwo);
            this.Controls.Add(buttonZero);
        }

        private void buttonDelate_Click(object sender, EventArgs e)
        {
            if (calculator.Text.Count != 0)
                calculator.Text.RemoveAt(calculator.Text.Count - 1);

            if (calculator.Text.Count == 0)
                labelOutput.Text = "0";
            else
                labelOutput.Text = calculator.ToString();
        }
        private void buttonZero_Click(object sender, EventArgs e)
        {
            calculator.Text.Add("0");
            labelOutput.Text = calculator.ToString();
        }
        private void buttonTree_Click(object sender, EventArgs e)
        {
            calculator.Text.Add("3");
            labelOutput.Text = calculator.ToString();
        }
        private void buttonTwo_Click(object sender, EventArgs e)
        {
            calculator.Text.Add("2");
            labelOutput.Text = calculator.ToString();
        }
        private void buttonOne_Click(object sender, EventArgs e)
        {
            calculator.Text.Add("1");
            labelOutput.Text = calculator.ToString();
        }
        private void buttonSix_Click(object sender, EventArgs e)
        {
            calculator.Text.Add("6");
            labelOutput.Text = calculator.ToString();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            calculator.Text.Add("5");
            labelOutput.Text = calculator.ToString();
        }
        private void buttonFour_Click(object sender, EventArgs e)
        {
            calculator.Text.Add("4");
            labelOutput.Text = calculator.ToString();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            calculator.Text.Add("7");
            labelOutput.Text = calculator.ToString();
        }
        private void buttonNine_Click(object sender, EventArgs e)
        {
            calculator.Text.Add("9");
            labelOutput.Text = calculator.ToString();
        }
        private void buttonEight_Click(object sender, EventArgs e)
        {
            calculator.Text.Add("8");
            labelOutput.Text = calculator.ToString();
        }
        private void buttonEqual_Click(object sender, EventArgs e)
        {
            if (labelOutput.Text != "0")
            {
                calculator.IsSignFunction();
                if (calculator.IsSign[calculator.IsSign.Count - 1])
                {
                    calculator.Text.RemoveAt(calculator.Text.Count - 1);
                    labelOutput.Text = calculator.ToString();
                }

                string text = calculator.BeforeAndAfterSign();

                if (calculator.IsSmaller)
                {
                    MessageBox.Show("Devision by a smaller number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    calculator.Text.RemoveRange(0, calculator.Text.Count);
                    labelOutput.ResetText();

                    calculator.IsSmaller = false;
                }
                else
                    labelOutput.Text = calculator.ToString();
            }
        }
        private void buttonPlus_Click(object sender, EventArgs e)
        {
            calculator.Text.Add("+");
            labelOutput.Text = calculator.ToString();
        }
        private void buttonMinus_Click(object sender, EventArgs e)
        {
            calculator.Text.Add("-");
            labelOutput.Text = calculator.ToString();
        }
        private void buttonMultiplication_Click(object sender, EventArgs e)
        {
            calculator.Text.Add("*");
            labelOutput.Text = calculator.ToString();
        }
        private void buttonDevision_Click(object sender, EventArgs e)
        {
            calculator.Text.Add("/");
            labelOutput.Text = calculator.ToString();
        }
        private void buttoIntegerDivision_Click(object sender, EventArgs e)
        {
            calculator.Text.Add("%");
            labelOutput.Text = calculator.ToString();
        }
        private void buttonAC_Click(object sender, EventArgs e)
        {
            calculator.Text.RemoveRange(0, calculator.Text.Count);
            labelOutput.ResetText();
            labelOutput.Text = "0";
        }
        private void labelOutput_TextChanged(object sender, EventArgs e)
        {
            calculator.IsSignFunction();
            for (int i = 0; i < calculator.Text.Count; i++)
            {
                if (labelOutput.Text.Length > 0 && calculator.IsSign[0])
                {
                    calculator.Text.RemoveAt(calculator.Text.Count - 1);
                    labelOutput.Text = calculator.ToString();

                    calculator.IsSignFunction();
                    MessageBox.Show("Signs can not be placed first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            for (int i = 0; i < calculator.Text.Count; i++)
            {
                if (calculator.Text.Count >= 2)
                {
                    if (calculator.IsSign[i] && calculator.IsSign[i - 1])
                    {
                        calculator.Text.RemoveAt(calculator.Text.Count - 1);
                        labelOutput.Text = calculator.ToString();

                        calculator.IsSignFunction();
                        MessageBox.Show("Signs can not be repeated", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                    if (i != 0)
                    {
                        if (calculator.Text[i] == "0" && calculator.Text[i - 1] == "/")
                        {
                            calculator.Text.RemoveAt(calculator.Text.Count - 1);
                            labelOutput.Text = calculator.ToString();

                            calculator.IsSignFunction();
                            MessageBox.Show("Can not be devided by zero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                    }
                }
            }
        }
    }
}
