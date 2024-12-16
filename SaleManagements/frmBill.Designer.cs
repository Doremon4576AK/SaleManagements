namespace SaleManagements
{
    partial class frmBill
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
            groupBox1 = new GroupBox();
            lvViewBill = new ListView();
            idbill = new ColumnHeader();
            nambill = new ColumnHeader();
            iduser = new ColumnHeader();
            groupBox2 = new GroupBox();
            btnDelete = new Button();
            btnAdd = new Button();
            Search = new Label();
            txtSearch = new TextBox();
            txtIDUser = new TextBox();
            txtNameBill = new TextBox();
            txtIDBill = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lvViewBill);
            groupBox1.Location = new Point(580, 109);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(653, 342);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "ListBill";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // lvViewBill
            // 
            lvViewBill.Columns.AddRange(new ColumnHeader[] { idbill, nambill, iduser });
            lvViewBill.Location = new Point(0, 32);
            lvViewBill.Name = "lvViewBill";
            lvViewBill.Size = new Size(653, 310);
            lvViewBill.TabIndex = 0;
            lvViewBill.UseCompatibleStateImageBehavior = false;
            lvViewBill.View = View.Details;
            lvViewBill.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // idbill
            // 
            idbill.Text = "ID Bill";
            idbill.Width = 82;
            // 
            // nambill
            // 
            nambill.Text = "Name Bill";
            // 
            // iduser
            // 
            iduser.Text = "ID User";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnDelete);
            groupBox2.Controls.Add(btnAdd);
            groupBox2.Controls.Add(Search);
            groupBox2.Controls.Add(txtSearch);
            groupBox2.Controls.Add(txtIDUser);
            groupBox2.Controls.Add(txtNameBill);
            groupBox2.Controls.Add(txtIDBill);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(55, 116);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(472, 335);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Detail formantion";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(139, 265);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(19, 262);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // Search
            // 
            Search.AutoSize = true;
            Search.Location = new Point(29, 44);
            Search.Name = "Search";
            Search.Size = new Size(56, 20);
            Search.TabIndex = 7;
            Search.Text = "Search:";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(124, 41);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(253, 27);
            txtSearch.TabIndex = 6;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // txtIDUser
            // 
            txtIDUser.Location = new Point(159, 210);
            txtIDUser.Name = "txtIDUser";
            txtIDUser.Size = new Size(184, 27);
            txtIDUser.TabIndex = 5;
            // 
            // txtNameBill
            // 
            txtNameBill.Location = new Point(159, 154);
            txtNameBill.Name = "txtNameBill";
            txtNameBill.Size = new Size(184, 27);
            txtNameBill.TabIndex = 4;
            // 
            // txtIDBill
            // 
            txtIDBill.Location = new Point(159, 104);
            txtIDBill.Name = "txtIDBill";
            txtIDBill.Size = new Size(184, 27);
            txtIDBill.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(29, 210);
            label4.Name = "label4";
            label4.Size = new Size(60, 21);
            label4.TabIndex = 2;
            label4.Text = "ID User";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(29, 154);
            label3.Name = "label3";
            label3.Size = new Size(76, 21);
            label3.TabIndex = 1;
            label3.Text = "Name Bill";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(29, 103);
            label2.Name = "label2";
            label2.Size = new Size(49, 21);
            label2.TabIndex = 0;
            label2.Text = "ID Bill";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(102, 42);
            label1.Name = "label1";
            label1.Size = new Size(296, 41);
            label1.TabIndex = 2;
            label1.Text = "MANAGEMENT BILL";
            // 
            // frmBill
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1291, 500);
            Controls.Add(label1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmBill";
            Text = "frmBill";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private ListView lvViewBill;
        private GroupBox groupBox2;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private ColumnHeader idbill;
        private ColumnHeader nambill;
        private ColumnHeader iduser;
        private Button btnAdd;
        private Label Search;
        private TextBox txtSearch;
        private TextBox txtIDUser;
        private TextBox txtNameBill;
        private TextBox txtIDBill;
        private Button btnDelete;
    }
}