namespace WaterBill
{
    partial class Register
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
            label1 = new Label();
            label2 = new Label();
            txtRegisterU = new TextBox();
            txtRegisterP = new TextBox();
            label3 = new Label();
            btnSubmit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(162, 137);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 0;
            label1.Text = "User Name :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(162, 221);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 1;
            label2.Text = "Passwords :";
            label2.Click += label2_Click;
            // 
            // txtRegisterU
            // 
            txtRegisterU.Location = new Point(269, 137);
            txtRegisterU.Name = "txtRegisterU";
            txtRegisterU.Size = new Size(204, 27);
            txtRegisterU.TabIndex = 2;
            // 
            // txtRegisterP
            // 
            txtRegisterP.Location = new Point(269, 218);
            txtRegisterP.Name = "txtRegisterP";
            txtRegisterP.Size = new Size(204, 27);
            txtRegisterP.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(331, 84);
            label3.Name = "label3";
            label3.Size = new Size(63, 20);
            label3.TabIndex = 4;
            label3.Text = "Register";
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(313, 307);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(94, 29);
            btnSubmit.TabIndex = 5;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Screenshot_2025_09_27_004432;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSubmit);
            Controls.Add(label3);
            Controls.Add(txtRegisterP);
            Controls.Add(txtRegisterU);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Register";
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtRegisterU;
        private TextBox txtRegisterP;
        private Label label3;
        private Button btnSubmit;
    }
}