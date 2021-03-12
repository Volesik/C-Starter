
namespace _002_Machine_Mathematics
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
            this.byteButton = new System.Windows.Forms.Button();
            this.sbyteButton = new System.Windows.Forms.Button();
            this.shortButton = new System.Windows.Forms.Button();
            this.ushortButton = new System.Windows.Forms.Button();
            this.intButton = new System.Windows.Forms.Button();
            this.uintButton = new System.Windows.Forms.Button();
            this.longButton = new System.Windows.Forms.Button();
            this.ulongButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // byteButton
            // 
            this.byteButton.Location = new System.Drawing.Point(111, 62);
            this.byteButton.Name = "byteButton";
            this.byteButton.Size = new System.Drawing.Size(181, 40);
            this.byteButton.TabIndex = 0;
            this.byteButton.Text = "byte";
            this.byteButton.UseVisualStyleBackColor = true;
            this.byteButton.Click += new System.EventHandler(this.byteButton_Click);
            // 
            // sbyteButton
            // 
            this.sbyteButton.Location = new System.Drawing.Point(357, 62);
            this.sbyteButton.Name = "sbyteButton";
            this.sbyteButton.Size = new System.Drawing.Size(181, 40);
            this.sbyteButton.TabIndex = 1;
            this.sbyteButton.Text = "sbyte";
            this.sbyteButton.UseVisualStyleBackColor = true;
            this.sbyteButton.Click += new System.EventHandler(this.sbyteButton_Click);
            // 
            // shortButton
            // 
            this.shortButton.Location = new System.Drawing.Point(111, 135);
            this.shortButton.Name = "shortButton";
            this.shortButton.Size = new System.Drawing.Size(181, 40);
            this.shortButton.TabIndex = 2;
            this.shortButton.Text = "short";
            this.shortButton.UseVisualStyleBackColor = true;
            this.shortButton.Click += new System.EventHandler(this.shortButton_Click);
            // 
            // ushortButton
            // 
            this.ushortButton.Location = new System.Drawing.Point(357, 135);
            this.ushortButton.Name = "ushortButton";
            this.ushortButton.Size = new System.Drawing.Size(181, 40);
            this.ushortButton.TabIndex = 3;
            this.ushortButton.Text = "ushort";
            this.ushortButton.UseVisualStyleBackColor = true;
            this.ushortButton.Click += new System.EventHandler(this.ushortButton_Click);
            // 
            // intButton
            // 
            this.intButton.Location = new System.Drawing.Point(111, 209);
            this.intButton.Name = "intButton";
            this.intButton.Size = new System.Drawing.Size(181, 40);
            this.intButton.TabIndex = 4;
            this.intButton.Text = "int";
            this.intButton.UseVisualStyleBackColor = true;
            this.intButton.Click += new System.EventHandler(this.intButton_Click);
            // 
            // uintButton
            // 
            this.uintButton.Location = new System.Drawing.Point(357, 209);
            this.uintButton.Name = "uintButton";
            this.uintButton.Size = new System.Drawing.Size(181, 40);
            this.uintButton.TabIndex = 5;
            this.uintButton.Text = "uint";
            this.uintButton.UseVisualStyleBackColor = true;
            this.uintButton.Click += new System.EventHandler(this.uintButton_Click);
            // 
            // longButton
            // 
            this.longButton.Location = new System.Drawing.Point(111, 285);
            this.longButton.Name = "longButton";
            this.longButton.Size = new System.Drawing.Size(181, 40);
            this.longButton.TabIndex = 6;
            this.longButton.Text = "long";
            this.longButton.UseVisualStyleBackColor = true;
            this.longButton.Click += new System.EventHandler(this.longButton_Click);
            // 
            // ulongButton
            // 
            this.ulongButton.Location = new System.Drawing.Point(357, 285);
            this.ulongButton.Name = "ulongButton";
            this.ulongButton.Size = new System.Drawing.Size(181, 40);
            this.ulongButton.TabIndex = 7;
            this.ulongButton.Text = "ulong";
            this.ulongButton.UseVisualStyleBackColor = true;
            this.ulongButton.Click += new System.EventHandler(this.ulongButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 392);
            this.Controls.Add(this.ulongButton);
            this.Controls.Add(this.longButton);
            this.Controls.Add(this.uintButton);
            this.Controls.Add(this.intButton);
            this.Controls.Add(this.ushortButton);
            this.Controls.Add(this.shortButton);
            this.Controls.Add(this.sbyteButton);
            this.Controls.Add(this.byteButton);
            this.Name = "Form1";
            this.Text = "Additional Task";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button byteButton;
        private System.Windows.Forms.Button sbyteButton;
        private System.Windows.Forms.Button shortButton;
        private System.Windows.Forms.Button ushortButton;
        private System.Windows.Forms.Button intButton;
        private System.Windows.Forms.Button uintButton;
        private System.Windows.Forms.Button longButton;
        private System.Windows.Forms.Button ulongButton;
    }
}

