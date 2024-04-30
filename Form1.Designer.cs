namespace PressureConverter
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBoxkPa = new TextBox();
            textBoxPsi = new TextBox();
            textBoxBar = new TextBox();
            buttonCalculate = new Button();
            buttonClear = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 23);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 0;
            label1.Text = "Paine kPa";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(134, 23);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 1;
            label2.Text = "Paine psi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(243, 23);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 2;
            label3.Text = "Paine bar";
            // 
            // textBoxkPa
            // 
            textBoxkPa.Location = new Point(30, 41);
            textBoxkPa.Name = "textBoxkPa";
            textBoxkPa.Size = new Size(78, 23);
            textBoxkPa.TabIndex = 3;
            textBoxkPa.TextChanged += textBoxkPa_TextChanged;
            textBoxkPa.Leave += textBoxkPa_Leave;
            // 
            // textBoxPsi
            // 
            textBoxPsi.Enabled = false;
            textBoxPsi.Location = new Point(134, 41);
            textBoxPsi.Name = "textBoxPsi";
            textBoxPsi.Size = new Size(80, 23);
            textBoxPsi.TabIndex = 4;
            // 
            // textBoxBar
            // 
            textBoxBar.Enabled = false;
            textBoxBar.Location = new Point(243, 41);
            textBoxBar.Name = "textBoxBar";
            textBoxBar.Size = new Size(75, 23);
            textBoxBar.TabIndex = 5;
            // 
            // buttonCalculate
            // 
            buttonCalculate.Enabled = false;
            buttonCalculate.Location = new Point(243, 92);
            buttonCalculate.Name = "buttonCalculate";
            buttonCalculate.Size = new Size(75, 23);
            buttonCalculate.TabIndex = 6;
            buttonCalculate.Text = "Laske";
            buttonCalculate.UseVisualStyleBackColor = true;
            buttonCalculate.Click += buttonCalculate_Click;
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(134, 92);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(80, 23);
            buttonClear.TabIndex = 7;
            buttonClear.Text = "Tyhjennä";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(363, 180);
            Controls.Add(buttonClear);
            Controls.Add(buttonCalculate);
            Controls.Add(textBoxBar);
            Controls.Add(textBoxPsi);
            Controls.Add(textBoxkPa);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxkPa;
        private TextBox textBoxPsi;
        private TextBox textBoxBar;
        private Button buttonCalculate;
        private Button buttonClear;
    }
}
