namespace RefrigeratorApp
{
    partial class Refrigaretor_Calculation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.maxamountTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.itemTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.currentTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.remainTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.enterButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Maximum weight taken";
            // 
            // maxamountTextBox
            // 
            this.maxamountTextBox.Location = new System.Drawing.Point(143, 25);
            this.maxamountTextBox.Name = "maxamountTextBox";
            this.maxamountTextBox.Size = new System.Drawing.Size(103, 20);
            this.maxamountTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "No. of Items";
            // 
            // itemTextBox
            // 
            this.itemTextBox.Location = new System.Drawing.Point(102, 126);
            this.itemTextBox.Name = "itemTextBox";
            this.itemTextBox.Size = new System.Drawing.Size(81, 20);
            this.itemTextBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(203, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "weight(kg/unit)";
            // 
            // weightTextBox
            // 
            this.weightTextBox.Location = new System.Drawing.Point(307, 133);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(81, 20);
            this.weightTextBox.TabIndex = 1;
            // 
            // currentTextBox
            // 
            this.currentTextBox.Location = new System.Drawing.Point(102, 286);
            this.currentTextBox.Name = "currentTextBox";
            this.currentTextBox.Size = new System.Drawing.Size(81, 20);
            this.currentTextBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Cuurent(Weight)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(203, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Remaining Weight";
            // 
            // remainTextBox
            // 
            this.remainTextBox.Location = new System.Drawing.Point(317, 283);
            this.remainTextBox.Name = "remainTextBox";
            this.remainTextBox.Size = new System.Drawing.Size(81, 20);
            this.remainTextBox.TabIndex = 1;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(275, 23);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(86, 22);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // enterButton
            // 
            this.enterButton.Location = new System.Drawing.Point(302, 186);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(86, 22);
            this.enterButton.TabIndex = 2;
            this.enterButton.Text = "Enter";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // Refrigaretor_Calculation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 343);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.remainTextBox);
            this.Controls.Add(this.weightTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.currentTextBox);
            this.Controls.Add(this.itemTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.maxamountTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Refrigaretor_Calculation";
            this.Text = "Refrigerator Calculation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox maxamountTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox itemTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.TextBox currentTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox remainTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button enterButton;
    }
}

