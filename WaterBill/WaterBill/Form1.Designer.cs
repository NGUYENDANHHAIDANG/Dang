namespace WaterBill
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
            ListViewItem listViewItem1 = new ListViewItem("");
            ListViewItem listViewItem2 = new ListViewItem("");
            ListViewItem listViewItem3 = new ListViewItem("");
            ListViewItem listViewItem4 = new ListViewItem("");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            tbSearch = new TextBox();
            tbCustomerName = new TextBox();
            tbLastMonthRead = new TextBox();
            tbThisMonthRead = new TextBox();
            cbbCustomerType = new ComboBox();
            btnSearch = new Button();
            btnSubmit = new Button();
            btnChangePlace = new Button();
            lvCustomer = new ListView();
            lvcCustomerName = new ColumnHeader();
            lvcCustomerType = new ColumnHeader();
            lvcThisMonthRead = new ColumnHeader();
            lvcLastMonthRead = new ColumnHeader();
            lvcWarterConsumption = new ColumnHeader();
            lvcTotal = new ColumnHeader();
            btnEdit = new Button();
            btnDelete = new Button();
            label5 = new Label();
            tbWaterConsumtion = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 39);
            label1.Name = "label1";
            label1.Size = new Size(123, 20);
            label1.TabIndex = 0;
            label1.Text = "Customer Name :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 166);
            label2.Name = "label2";
            label2.Size = new Size(157, 20);
            label2.TabIndex = 1;
            label2.Text = "Last Month's Reading :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 119);
            label3.Name = "label3";
            label3.Size = new Size(157, 20);
            label3.TabIndex = 2;
            label3.Text = "This Month's Reading :";
            label3.Click += label3_Click_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(45, 76);
            label4.Name = "label4";
            label4.Size = new Size(114, 20);
            label4.TabIndex = 3;
            label4.Text = "Customer Type :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(795, 46);
            label6.Name = "label6";
            label6.Size = new Size(56, 20);
            label6.TabIndex = 5;
            label6.Text = "Search:";
            // 
            // tbSearch
            // 
            tbSearch.Location = new Point(857, 43);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(179, 27);
            tbSearch.TabIndex = 7;
            // 
            // tbCustomerName
            // 
            tbCustomerName.Location = new Point(174, 36);
            tbCustomerName.Name = "tbCustomerName";
            tbCustomerName.Size = new Size(220, 27);
            tbCustomerName.TabIndex = 8;
            tbCustomerName.TextChanged += tbCustomerName_TextChanged;
            // 
            // tbLastMonthRead
            // 
            tbLastMonthRead.Location = new Point(218, 159);
            tbLastMonthRead.Name = "tbLastMonthRead";
            tbLastMonthRead.Size = new Size(176, 27);
            tbLastMonthRead.TabIndex = 9;
            // 
            // tbThisMonthRead
            // 
            tbThisMonthRead.Location = new Point(218, 112);
            tbThisMonthRead.Name = "tbThisMonthRead";
            tbThisMonthRead.Size = new Size(176, 27);
            tbThisMonthRead.TabIndex = 10;
            // 
            // cbbCustomerType
            // 
            cbbCustomerType.FormattingEnabled = true;
            cbbCustomerType.Items.AddRange(new object[] { "Household", "Administrative", "Production", "Business Services" });
            cbbCustomerType.Location = new Point(174, 76);
            cbbCustomerType.Name = "cbbCustomerType";
            cbbCustomerType.Size = new Size(220, 28);
            cbbCustomerType.TabIndex = 13;
            cbbCustomerType.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(891, 84);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 16;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += button1_Click_1;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(254, 255);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(94, 29);
            btnSubmit.TabIndex = 17;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnChangePlace
            // 
            btnChangePlace.Location = new Point(1192, 321);
            btnChangePlace.Name = "btnChangePlace";
            btnChangePlace.Size = new Size(94, 80);
            btnChangePlace.TabIndex = 19;
            btnChangePlace.Text = "Change Place";
            btnChangePlace.UseVisualStyleBackColor = true;
            btnChangePlace.Click += button3_Click;
            // 
            // lvCustomer
            // 
            lvCustomer.Columns.AddRange(new ColumnHeader[] { lvcCustomerName, lvcCustomerType, lvcThisMonthRead, lvcLastMonthRead, lvcWarterConsumption, lvcTotal });
            lvCustomer.ForeColor = Color.FromArgb(255, 128, 128);
            lvCustomer.FullRowSelect = true;
            lvCustomer.GridLines = true;
            listViewItem1.StateImageIndex = 0;
            listViewItem2.StateImageIndex = 0;
            listViewItem3.StateImageIndex = 0;
            listViewItem4.StateImageIndex = 0;
            lvCustomer.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2, listViewItem3, listViewItem4 });
            lvCustomer.LabelEdit = true;
            lvCustomer.Location = new Point(12, 302);
            lvCustomer.Name = "lvCustomer";
            lvCustomer.Size = new Size(1136, 336);
            lvCustomer.TabIndex = 20;
            lvCustomer.UseCompatibleStateImageBehavior = false;
            lvCustomer.View = View.Details;
            lvCustomer.SelectedIndexChanged += lvCustomer_SelectedIndexChanged;
            // 
            // lvcCustomerName
            // 
            lvcCustomerName.Tag = "";
            lvcCustomerName.Text = "CustomerName";
            lvcCustomerName.Width = 200;
            // 
            // lvcCustomerType
            // 
            lvcCustomerType.Text = "CustomerType";
            lvcCustomerType.Width = 200;
            // 
            // lvcThisMonthRead
            // 
            lvcThisMonthRead.Text = "This Month's Read";
            lvcThisMonthRead.Width = 200;
            // 
            // lvcLastMonthRead
            // 
            lvcLastMonthRead.Text = "Last Month's Read";
            lvcLastMonthRead.Width = 200;
            // 
            // lvcWarterConsumption
            // 
            lvcWarterConsumption.Text = "Warter Consumption";
            lvcWarterConsumption.Width = 200;
            // 
            // lvcTotal
            // 
            lvcTotal.Text = "Total";
            lvcTotal.Width = 130;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(1192, 419);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 81);
            btnEdit.TabIndex = 21;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(1192, 517);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 77);
            btnDelete.TabIndex = 22;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(45, 211);
            label5.Name = "label5";
            label5.Size = new Size(152, 20);
            label5.TabIndex = 23;
            label5.Text = "Warter Consumption :";
            label5.Click += label5_Click;
            // 
            // tbWaterConsumtion
            // 
            tbWaterConsumtion.Location = new Point(218, 208);
            tbWaterConsumtion.Name = "tbWaterConsumtion";
            tbWaterConsumtion.Size = new Size(176, 27);
            tbWaterConsumtion.TabIndex = 24;
            tbWaterConsumtion.TextChanged += tbWaterConsumtion_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1298, 650);
            Controls.Add(tbWaterConsumtion);
            Controls.Add(label5);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(lvCustomer);
            Controls.Add(btnChangePlace);
            Controls.Add(btnSubmit);
            Controls.Add(btnSearch);
            Controls.Add(cbbCustomerType);
            Controls.Add(tbThisMonthRead);
            Controls.Add(tbLastMonthRead);
            Controls.Add(tbCustomerName);
            Controls.Add(tbSearch);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private TextBox tbSearch;
        private TextBox tbCustomerName;
        private TextBox tbLastMonthRead;
        private TextBox tbThisMonthRead;
        private ComboBox cbbCustomerType;
        private Button btnSearch;
        private Button btnSubmit;
        private Button btnChangePlace;
        private ListView lvCustomer;
        private Button btnEdit;
        private Button btnDelete;
        private ColumnHeader lvcCustomerName;
        private ColumnHeader lvcCustomerType;
        private ColumnHeader lvcThisMonthRead;
        private ColumnHeader lvcLastMonthRead;
        private ColumnHeader lvcWarterConsumption;
        private ColumnHeader lvcTotal;
        private Label label5;
        private TextBox tbWaterConsumtion;
    }
}
