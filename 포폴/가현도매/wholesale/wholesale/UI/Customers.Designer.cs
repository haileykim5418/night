﻿
namespace wholesale
{
    partial class Customers
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
            this.dataGridView_cus = new System.Windows.Forms.DataGridView();
            this.c_ubdateB = new System.Windows.Forms.Button();
            this.c_delB = new System.Windows.Forms.Button();
            this.c_insertB = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_mail = new System.Windows.Forms.TextBox();
            this.textBox_phone = new System.Windows.Forms.TextBox();
            this.textBox_addr = new System.Windows.Forms.TextBox();
            this.textBox_bnum = new System.Windows.Forms.TextBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label_item = new System.Windows.Forms.Label();
            this.label_id = new System.Windows.Forms.Label();
            this.size = new System.Windows.Forms.Label();
            this.color = new System.Windows.Forms.Label();
            this.stock = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_cus)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_cus
            // 
            this.dataGridView_cus.AllowUserToAddRows = false;
            this.dataGridView_cus.AllowUserToDeleteRows = false;
            this.dataGridView_cus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_cus.Location = new System.Drawing.Point(22, 20);
            this.dataGridView_cus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView_cus.Name = "dataGridView_cus";
            this.dataGridView_cus.ReadOnly = true;
            this.dataGridView_cus.RowHeadersWidth = 51;
            this.dataGridView_cus.RowTemplate.Height = 27;
            this.dataGridView_cus.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_cus.Size = new System.Drawing.Size(641, 217);
            this.dataGridView_cus.TabIndex = 0;
            this.dataGridView_cus.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_cus_CellClick);
            // 
            // c_ubdateB
            // 
            this.c_ubdateB.BackColor = System.Drawing.Color.MistyRose;
            this.c_ubdateB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.c_ubdateB.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.c_ubdateB.Location = new System.Drawing.Point(563, 16);
            this.c_ubdateB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.c_ubdateB.Name = "c_ubdateB";
            this.c_ubdateB.Size = new System.Drawing.Size(72, 21);
            this.c_ubdateB.TabIndex = 1;
            this.c_ubdateB.Text = "수정";
            this.c_ubdateB.UseVisualStyleBackColor = false;
            this.c_ubdateB.Click += new System.EventHandler(this.c_dbupdateB_Click);
            // 
            // c_delB
            // 
            this.c_delB.BackColor = System.Drawing.Color.MistyRose;
            this.c_delB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.c_delB.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.c_delB.Location = new System.Drawing.Point(563, 40);
            this.c_delB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.c_delB.Name = "c_delB";
            this.c_delB.Size = new System.Drawing.Size(72, 21);
            this.c_delB.TabIndex = 2;
            this.c_delB.Text = "삭제";
            this.c_delB.UseVisualStyleBackColor = false;
            this.c_delB.Click += new System.EventHandler(this.c_delB_Click);
            // 
            // c_insertB
            // 
            this.c_insertB.BackColor = System.Drawing.Color.MistyRose;
            this.c_insertB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.c_insertB.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.c_insertB.Location = new System.Drawing.Point(563, 64);
            this.c_insertB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.c_insertB.Name = "c_insertB";
            this.c_insertB.Size = new System.Drawing.Size(72, 21);
            this.c_insertB.TabIndex = 3;
            this.c_insertB.Text = "추가";
            this.c_insertB.UseVisualStyleBackColor = false;
            this.c_insertB.Click += new System.EventHandler(this.c_insertB_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_mail);
            this.groupBox1.Controls.Add(this.c_insertB);
            this.groupBox1.Controls.Add(this.textBox_phone);
            this.groupBox1.Controls.Add(this.c_delB);
            this.groupBox1.Controls.Add(this.c_ubdateB);
            this.groupBox1.Controls.Add(this.textBox_addr);
            this.groupBox1.Controls.Add(this.textBox_bnum);
            this.groupBox1.Controls.Add(this.textBox_name);
            this.groupBox1.Controls.Add(this.label_item);
            this.groupBox1.Controls.Add(this.label_id);
            this.groupBox1.Controls.Add(this.size);
            this.groupBox1.Controls.Add(this.color);
            this.groupBox1.Controls.Add(this.stock);
            this.groupBox1.Location = new System.Drawing.Point(22, 258);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(641, 93);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // textBox_mail
            // 
            this.textBox_mail.Location = new System.Drawing.Point(430, 21);
            this.textBox_mail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_mail.Name = "textBox_mail";
            this.textBox_mail.Size = new System.Drawing.Size(88, 21);
            this.textBox_mail.TabIndex = 12;
            // 
            // textBox_phone
            // 
            this.textBox_phone.Location = new System.Drawing.Point(283, 54);
            this.textBox_phone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_phone.Name = "textBox_phone";
            this.textBox_phone.Size = new System.Drawing.Size(88, 21);
            this.textBox_phone.TabIndex = 11;
            // 
            // textBox_addr
            // 
            this.textBox_addr.Location = new System.Drawing.Point(283, 22);
            this.textBox_addr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_addr.Name = "textBox_addr";
            this.textBox_addr.Size = new System.Drawing.Size(88, 21);
            this.textBox_addr.TabIndex = 10;
            // 
            // textBox_bnum
            // 
            this.textBox_bnum.Location = new System.Drawing.Point(101, 54);
            this.textBox_bnum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_bnum.Name = "textBox_bnum";
            this.textBox_bnum.Size = new System.Drawing.Size(88, 21);
            this.textBox_bnum.TabIndex = 9;
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(101, 22);
            this.textBox_name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(88, 21);
            this.textBox_name.TabIndex = 0;
            // 
            // label_item
            // 
            this.label_item.AutoSize = true;
            this.label_item.Location = new System.Drawing.Point(37, 25);
            this.label_item.Name = "label_item";
            this.label_item.Size = new System.Drawing.Size(53, 12);
            this.label_item.TabIndex = 2;
            this.label_item.Text = "거래처명";
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(24, 56);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(65, 12);
            this.label_id.TabIndex = 3;
            this.label_id.Text = "사업자번호";
            // 
            // size
            // 
            this.size.AutoSize = true;
            this.size.Location = new System.Drawing.Point(235, 22);
            this.size.Name = "size";
            this.size.Size = new System.Drawing.Size(29, 12);
            this.size.TabIndex = 4;
            this.size.Text = "주소";
            // 
            // color
            // 
            this.color.AutoSize = true;
            this.color.Location = new System.Drawing.Point(206, 56);
            this.color.Name = "color";
            this.color.Size = new System.Drawing.Size(65, 12);
            this.color.TabIndex = 5;
            this.color.Text = "휴대폰번호";
            // 
            // stock
            // 
            this.stock.AutoSize = true;
            this.stock.Location = new System.Drawing.Point(392, 23);
            this.stock.Name = "stock";
            this.stock.Size = new System.Drawing.Size(29, 12);
            this.stock.TabIndex = 6;
            this.stock.Text = "메일";
            // 
            // Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(700, 360);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView_cus);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Customers";
            this.Text = "거래처관리";
            this.Load += new System.EventHandler(this.Customers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_cus)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_cus;
        private System.Windows.Forms.Button c_ubdateB;
        private System.Windows.Forms.Button c_delB;
        private System.Windows.Forms.Button c_insertB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_mail;
        private System.Windows.Forms.TextBox textBox_phone;
        private System.Windows.Forms.TextBox textBox_addr;
        private System.Windows.Forms.TextBox textBox_bnum;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label_item;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label size;
        private System.Windows.Forms.Label color;
        private System.Windows.Forms.Label stock;
    }
}