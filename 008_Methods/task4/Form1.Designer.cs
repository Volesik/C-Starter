
namespace task4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.firstValue = new System.Windows.Forms.TextBox();
            this.secondValue = new System.Windows.Forms.TextBox();
            this.addition = new System.Windows.Forms.RadioButton();
            this.subtraction = new System.Windows.Forms.RadioButton();
            this.multiplication = new System.Windows.Forms.RadioButton();
            this.division = new System.Windows.Forms.RadioButton();
            this.remainder = new System.Windows.Forms.RadioButton();
            this.calculate = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // firstValue
            // 
            this.firstValue.Location = new System.Drawing.Point(45, 63);
            this.firstValue.Name = "firstValue";
            this.firstValue.Size = new System.Drawing.Size(208, 23);
            this.firstValue.TabIndex = 0;
            // 
            // secondValue
            // 
            this.secondValue.Location = new System.Drawing.Point(323, 63);
            this.secondValue.Name = "secondValue";
            this.secondValue.Size = new System.Drawing.Size(208, 23);
            this.secondValue.TabIndex = 1;
            // 
            // addition
            // 
            this.addition.AutoSize = true;
            this.addition.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.addition.Location = new System.Drawing.Point(45, 161);
            this.addition.Name = "addition";
            this.addition.Size = new System.Drawing.Size(71, 19);
            this.addition.TabIndex = 2;
            this.addition.TabStop = true;
            this.addition.Text = "Addition";
            this.addition.UseVisualStyleBackColor = true;
            this.addition.CheckedChanged += new System.EventHandler(this.addition_CheckedChanged);
            // 
            // subtraction
            // 
            this.subtraction.AutoSize = true;
            this.subtraction.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.subtraction.Location = new System.Drawing.Point(45, 202);
            this.subtraction.Name = "subtraction";
            this.subtraction.Size = new System.Drawing.Size(87, 19);
            this.subtraction.TabIndex = 3;
            this.subtraction.TabStop = true;
            this.subtraction.Text = "Subtraction";
            this.subtraction.UseVisualStyleBackColor = true;
            this.subtraction.CheckedChanged += new System.EventHandler(this.subtraction_CheckedChanged);
            // 
            // multiplication
            // 
            this.multiplication.AutoSize = true;
            this.multiplication.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.multiplication.Location = new System.Drawing.Point(197, 161);
            this.multiplication.Name = "multiplication";
            this.multiplication.Size = new System.Drawing.Size(98, 19);
            this.multiplication.TabIndex = 4;
            this.multiplication.TabStop = true;
            this.multiplication.Text = "Multiplication";
            this.multiplication.UseVisualStyleBackColor = true;
            this.multiplication.CheckedChanged += new System.EventHandler(this.multiplication_CheckedChanged);
            // 
            // division
            // 
            this.division.AutoSize = true;
            this.division.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.division.Location = new System.Drawing.Point(197, 206);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(68, 19);
            this.division.TabIndex = 5;
            this.division.TabStop = true;
            this.division.Text = "Division";
            this.division.UseVisualStyleBackColor = true;
            this.division.CheckedChanged += new System.EventHandler(this.division_CheckedChanged);
            // 
            // remainder
            // 
            this.remainder.AutoSize = true;
            this.remainder.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.remainder.Location = new System.Drawing.Point(369, 161);
            this.remainder.Name = "remainder";
            this.remainder.Size = new System.Drawing.Size(84, 19);
            this.remainder.TabIndex = 6;
            this.remainder.TabStop = true;
            this.remainder.Text = "Remainder";
            this.remainder.UseVisualStyleBackColor = true;
            this.remainder.CheckedChanged += new System.EventHandler(this.remainder_CheckedChanged);
            // 
            // calculate
            // 
            this.calculate.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.calculate.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.calculate.FlatAppearance.BorderSize = 0;
            this.calculate.Location = new System.Drawing.Point(197, 355);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(153, 41);
            this.calculate.TabIndex = 7;
            this.calculate.Text = "Calculate";
            this.calculate.UseVisualStyleBackColor = false;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(45, 289);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(486, 23);
            this.result.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(45, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "Result:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(45, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "First Argument";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(323, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 21);
            this.label3.TabIndex = 11;
            this.label3.Text = "Second Argument";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(45, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 21);
            this.label4.TabIndex = 12;
            this.label4.Text = "Select operation below:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(371, 407);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(195, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "2021 @ developed by Viktor Kyselov";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(578, 426);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.result);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.remainder);
            this.Controls.Add(this.division);
            this.Controls.Add(this.multiplication);
            this.Controls.Add(this.subtraction);
            this.Controls.Add(this.addition);
            this.Controls.Add(this.secondValue);
            this.Controls.Add(this.firstValue);
            this.Name = "Form1";
            this.Text = "Simple Calculate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstValue;
        private System.Windows.Forms.TextBox secondValue;
        private System.Windows.Forms.RadioButton addition;
        private System.Windows.Forms.RadioButton subtraction;
        private System.Windows.Forms.RadioButton multiplication;
        private System.Windows.Forms.RadioButton division;
        private System.Windows.Forms.RadioButton remainder;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

