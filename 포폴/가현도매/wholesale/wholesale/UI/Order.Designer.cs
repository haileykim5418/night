﻿
namespace wholesale.UI
{
    partial class Order
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.orderB = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_cust = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_stock = new System.Windows.Forms.TextBox();
            this.textBox_color = new System.Windows.Forms.TextBox();
            this.textBox_size = new System.Windows.Forms.TextBox();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.textBox_item = new System.Windows.Forms.TextBox();
            this.label_item = new System.Windows.Forms.Label();
            this.label_id = new System.Windows.Forms.Label();
            this.size = new System.Windows.Forms.Label();
            this.color = new System.Windows.Forms.Label();
            this.stock = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 31);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(473, 229);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // orderB
            // 
            this.orderB.BackColor = System.Drawing.Color.MistyRose;
            this.orderB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orderB.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.orderB.Location = new System.Drawing.Point(554, 20);
            this.orderB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.orderB.Name = "orderB";
            this.orderB.Size = new System.Drawing.Size(72, 21);
            this.orderB.TabIndex = 1;
            this.orderB.Text = "주문";
            this.orderB.UseVisualStyleBackColor = false;
            this.orderB.Click += new System.EventHandler(this.orderB_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_cust);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox_stock);
            this.groupBox1.Controls.Add(this.orderB);
            this.groupBox1.Controls.Add(this.textBox_color);
            this.groupBox1.Controls.Add(this.textBox_size);
            this.groupBox1.Controls.Add(this.textBox_id);
            this.groupBox1.Controls.Add(this.textBox_item);
            this.groupBox1.Controls.Add(this.label_item);
            this.groupBox1.Controls.Add(this.label_id);
            this.groupBox1.Controls.Add(this.size);
            this.groupBox1.Controls.Add(this.color);
            this.groupBox1.Controls.Add(this.stock);
            this.groupBox1.Location = new System.Drawing.Point(27, 264);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(641, 93);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // textBox_cust
            // 
            this.textBox_cust.Location = new System.Drawing.Point(420, 56);
            this.textBox_cust.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_cust.Name = "textBox_cust";
            this.textBox_cust.Size = new System.Drawing.Size(88, 21);
            this.textBox_cust.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(368, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 13;
            this.label3.Text = "거래처";
            // 
            // textBox_stock
            // 
            this.textBox_stock.Location = new System.Drawing.Point(420, 20);
            this.textBox_stock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_stock.Name = "textBox_stock";
            this.textBox_stock.Size = new System.Drawing.Size(88, 21);
            this.textBox_stock.TabIndex = 12;
            // 
            // textBox_color
            // 
            this.textBox_color.Location = new System.Drawing.Point(227, 55);
            this.textBox_color.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_color.Name = "textBox_color";
            this.textBox_color.Size = new System.Drawing.Size(88, 21);
            this.textBox_color.TabIndex = 11;
            // 
            // textBox_size
            // 
            this.textBox_size.Location = new System.Drawing.Point(227, 22);
            this.textBox_size.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_size.Name = "textBox_size";
            this.textBox_size.Size = new System.Drawing.Size(88, 21);
            this.textBox_size.TabIndex = 10;
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(56, 56);
            this.textBox_id.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(88, 21);
            this.textBox_id.TabIndex = 9;
            // 
            // textBox_item
            // 
            this.textBox_item.Location = new System.Drawing.Point(56, 23);
            this.textBox_item.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_item.Name = "textBox_item";
            this.textBox_item.Size = new System.Drawing.Size(88, 21);
            this.textBox_item.TabIndex = 0;
            // 
            // label_item
            // 
            this.label_item.AutoSize = true;
            this.label_item.Location = new System.Drawing.Point(18, 27);
            this.label_item.Name = "label_item";
            this.label_item.Size = new System.Drawing.Size(29, 12);
            this.label_item.TabIndex = 2;
            this.label_item.Text = "이름";
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(18, 61);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(29, 12);
            this.label_id.TabIndex = 3;
            this.label_id.Text = "품번";
            // 
            // size
            // 
            this.size.AutoSize = true;
            this.size.Location = new System.Drawing.Point(175, 27);
            this.size.Name = "size";
            this.size.Size = new System.Drawing.Size(41, 12);
            this.size.TabIndex = 4;
            this.size.Text = "사이즈";
            // 
            // color
            // 
            this.color.AutoSize = true;
            this.color.Location = new System.Drawing.Point(179, 60);
            this.color.Name = "color";
            this.color.Size = new System.Drawing.Size(29, 12);
            this.color.TabIndex = 5;
            this.color.Text = "컬러";
            // 
            // stock
            // 
            this.stock.AutoSize = true;
            this.stock.Location = new System.Drawing.Point(368, 27);
            this.stock.Name = "stock";
            this.stock.Size = new System.Drawing.Size(29, 12);
            this.stock.TabIndex = 6;
            this.stock.Text = "수량";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(527, 31);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 27;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(141, 229);
            this.dataGridView2.TabIndex = 11;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 11F);
            this.label1.Location = new System.Drawing.Point(25, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "재고";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 11F);
            this.label2.Location = new System.Drawing.Point(525, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "거래처";
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(700, 360);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Order";
            this.Text = "주문관리";
            this.Load += new System.EventHandler(this.order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button orderB;
        private System.Windows.Forms.GroupBox groupBox1;
       
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_stock;
        private System.Windows.Forms.TextBox textBox_color;
        private System.Windows.Forms.TextBox textBox_size;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.TextBox textBox_item;
        private System.Windows.Forms.Label label_item;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label size;
        private System.Windows.Forms.Label color;
        private System.Windows.Forms.Label stock;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_cust;
    }
}