
namespace wholesale
{
    partial class Inventory
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label_item = new System.Windows.Forms.Label();
            this.label_id = new System.Windows.Forms.Label();
            this.size = new System.Windows.Forms.Label();
            this.color = new System.Windows.Forms.Label();
            this.stock = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.insertB = new System.Windows.Forms.Button();
            this.update_b = new System.Windows.Forms.Button();
            this.del_b = new System.Windows.Forms.Button();
            this.textBox_stock = new System.Windows.Forms.TextBox();
            this.textBox_color = new System.Windows.Forms.TextBox();
            this.textBox_size = new System.Windows.Forms.TextBox();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.textBox_item = new System.Windows.Forms.TextBox();
            this.cust = new System.Windows.Forms.Button();
            this.orders = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(580, 267);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label_item
            // 
            this.label_item.AutoSize = true;
            this.label_item.Location = new System.Drawing.Point(21, 28);
            this.label_item.Name = "label_item";
            this.label_item.Size = new System.Drawing.Size(37, 15);
            this.label_item.TabIndex = 2;
            this.label_item.Text = "이름";
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(21, 70);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(37, 15);
            this.label_id.TabIndex = 3;
            this.label_id.Text = "품번";
            // 
            // size
            // 
            this.size.AutoSize = true;
            this.size.Location = new System.Drawing.Point(200, 27);
            this.size.Name = "size";
            this.size.Size = new System.Drawing.Size(52, 15);
            this.size.TabIndex = 4;
            this.size.Text = "사이즈";
            // 
            // color
            // 
            this.color.AutoSize = true;
            this.color.Location = new System.Drawing.Point(200, 65);
            this.color.Name = "color";
            this.color.Size = new System.Drawing.Size(37, 15);
            this.color.TabIndex = 5;
            this.color.Text = "컬러";
            // 
            // stock
            // 
            this.stock.AutoSize = true;
            this.stock.Location = new System.Drawing.Point(407, 21);
            this.stock.Name = "stock";
            this.stock.Size = new System.Drawing.Size(37, 15);
            this.stock.TabIndex = 6;
            this.stock.Text = "수량";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.insertB);
            this.groupBox1.Controls.Add(this.update_b);
            this.groupBox1.Controls.Add(this.del_b);
            this.groupBox1.Controls.Add(this.textBox_stock);
            this.groupBox1.Controls.Add(this.textBox_color);
            this.groupBox1.Controls.Add(this.textBox_size);
            this.groupBox1.Controls.Add(this.textBox_id);
            this.groupBox1.Controls.Add(this.textBox_item);
            this.groupBox1.Controls.Add(this.label_item);
            this.groupBox1.Controls.Add(this.label_id);
            this.groupBox1.Controls.Add(this.size);
            this.groupBox1.Controls.Add(this.color);
            this.groupBox1.Controls.Add(this.stock);
            this.groupBox1.Location = new System.Drawing.Point(21, 322);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(733, 116);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // insertB
            // 
            this.insertB.Location = new System.Drawing.Point(643, 17);
            this.insertB.Name = "insertB";
            this.insertB.Size = new System.Drawing.Size(75, 23);
            this.insertB.TabIndex = 14;
            this.insertB.Text = "추가";
            this.insertB.UseVisualStyleBackColor = true;
            this.insertB.Click += new System.EventHandler(this.insertB_Click);
            // 
            // update_b
            // 
            this.update_b.Location = new System.Drawing.Point(643, 46);
            this.update_b.Name = "update_b";
            this.update_b.Size = new System.Drawing.Size(75, 23);
            this.update_b.TabIndex = 10;
            this.update_b.Text = "수정";
            this.update_b.UseVisualStyleBackColor = true;
            this.update_b.Click += new System.EventHandler(this.update_b_Click);
            // 
            // del_b
            // 
            this.del_b.Location = new System.Drawing.Point(643, 77);
            this.del_b.Name = "del_b";
            this.del_b.Size = new System.Drawing.Size(75, 23);
            this.del_b.TabIndex = 11;
            this.del_b.Text = "삭제";
            this.del_b.UseVisualStyleBackColor = true;
            this.del_b.Click += new System.EventHandler(this.del_b_Click);
            // 
            // textBox_stock
            // 
            this.textBox_stock.Location = new System.Drawing.Point(480, 19);
            this.textBox_stock.Name = "textBox_stock";
            this.textBox_stock.Size = new System.Drawing.Size(100, 25);
            this.textBox_stock.TabIndex = 12;
            // 
            // textBox_color
            // 
            this.textBox_color.Location = new System.Drawing.Point(259, 62);
            this.textBox_color.Name = "textBox_color";
            this.textBox_color.Size = new System.Drawing.Size(100, 25);
            this.textBox_color.TabIndex = 11;
            this.textBox_color.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_color_KeyDown);
            // 
            // textBox_size
            // 
            this.textBox_size.Location = new System.Drawing.Point(259, 21);
            this.textBox_size.Name = "textBox_size";
            this.textBox_size.Size = new System.Drawing.Size(100, 25);
            this.textBox_size.TabIndex = 10;
            this.textBox_size.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_size_KeyDown);
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(64, 64);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(100, 25);
            this.textBox_id.TabIndex = 9;
            this.textBox_id.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_id_KeyDown);
            // 
            // textBox_item
            // 
            this.textBox_item.Location = new System.Drawing.Point(64, 23);
            this.textBox_item.Name = "textBox_item";
            this.textBox_item.Size = new System.Drawing.Size(100, 25);
            this.textBox_item.TabIndex = 0;
            this.textBox_item.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_item_KeyDown);
            // 
            // cust
            // 
            this.cust.Location = new System.Drawing.Point(670, 10);
            this.cust.Name = "cust";
            this.cust.Size = new System.Drawing.Size(118, 23);
            this.cust.TabIndex = 12;
            this.cust.Text = "거래처관리";
            this.cust.UseVisualStyleBackColor = true;
            this.cust.Click += new System.EventHandler(this.cust_Click);
            // 
            // orders
            // 
            this.orders.Location = new System.Drawing.Point(670, 39);
            this.orders.Name = "orders";
            this.orders.Size = new System.Drawing.Size(118, 23);
            this.orders.TabIndex = 16;
            this.orders.Text = "주문";
            this.orders.UseVisualStyleBackColor = true;
            this.orders.Click += new System.EventHandler(this.orders_Click);
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.orders);
            this.Controls.Add(this.cust);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.KeyPreview = true;
            this.Name = "Inventory";
            this.Text = "재고";
            this.Load += new System.EventHandler(this.Inventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label_item;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label size;
        private System.Windows.Forms.Label color;
        private System.Windows.Forms.Label stock;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button update_b;
        private System.Windows.Forms.Button del_b;
        private System.Windows.Forms.Button cust;
        private System.Windows.Forms.TextBox textBox_item;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.TextBox textBox_stock;
        private System.Windows.Forms.TextBox textBox_color;
        private System.Windows.Forms.TextBox textBox_size;
        private System.Windows.Forms.Button insertB;
        private System.Windows.Forms.Button orders;
    }
}

