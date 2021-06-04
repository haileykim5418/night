
namespace CarManager0323.UI
{
    partial class DealView
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
            this.dealList = new System.Windows.Forms.ListView();
            this.deal_count = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.deal_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.deal_model = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.deal_price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.deal_seller = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.custDetail = new Sunny.UI.UISymbolButton();
            this.dealViewC = new Sunny.UI.UISymbolButton();
            this.deal_date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // dealList
            // 
            this.dealList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.deal_count,
            this.deal_name,
            this.deal_model,
            this.deal_price,
            this.deal_seller,
            this.deal_date});
            this.dealList.Font = new System.Drawing.Font("굴림체", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dealList.FullRowSelect = true;
            this.dealList.HideSelection = false;
            this.dealList.Location = new System.Drawing.Point(21, 108);
            this.dealList.Name = "dealList";
            this.dealList.Size = new System.Drawing.Size(610, 291);
            this.dealList.TabIndex = 2;
            this.dealList.UseCompatibleStateImageBehavior = false;
            this.dealList.View = System.Windows.Forms.View.Details;
            this.dealList.SelectedIndexChanged += new System.EventHandler(this.dealList_SelectedIndexChanged);
            // 
            // deal_count
            // 
            this.deal_count.Text = "번호";
            this.deal_count.Width = 46;
            // 
            // deal_name
            // 
            this.deal_name.Text = "고객이름";
            this.deal_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.deal_name.Width = 80;
            // 
            // deal_model
            // 
            this.deal_model.Text = "구매차량";
            this.deal_model.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.deal_model.Width = 140;
            // 
            // deal_price
            // 
            this.deal_price.Text = "구매가격";
            this.deal_price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.deal_price.Width = 120;
            // 
            // deal_seller
            // 
            this.deal_seller.Text = "판매자";
            this.deal_seller.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.deal_seller.Width = 100;
            // 
            // custDetail
            // 
            this.custDetail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.custDetail.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.custDetail.Location = new System.Drawing.Point(652, 137);
            this.custDetail.MinimumSize = new System.Drawing.Size(1, 1);
            this.custDetail.Name = "custDetail";
            this.custDetail.Size = new System.Drawing.Size(136, 35);
            this.custDetail.TabIndex = 4;
            this.custDetail.Text = "고객상세정보";
           /* this.custDetail.Click += new System.EventHandler(this.custDetail_Click);*/
            // 
            // dealViewC
            // 
            this.dealViewC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dealViewC.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.dealViewC.Location = new System.Drawing.Point(652, 178);
            this.dealViewC.MinimumSize = new System.Drawing.Size(1, 1);
            this.dealViewC.Name = "dealViewC";
            this.dealViewC.Size = new System.Drawing.Size(137, 35);
            this.dealViewC.TabIndex = 5;
            this.dealViewC.Text = "닫기";
            this.dealViewC.Click += new System.EventHandler(this.dealViewC_Click);
            // 
            // deal_date
            // 
            this.deal_date.Text = "거래날짜";
            this.deal_date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.deal_date.Width = 120;
            // 
            // DealView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dealViewC);
            this.Controls.Add(this.custDetail);
            this.Controls.Add(this.dealList);
            this.Name = "DealView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "거래내역보기";
            this.Load += new System.EventHandler(this.DealView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView dealList;
        private System.Windows.Forms.ColumnHeader deal_count;
        private System.Windows.Forms.ColumnHeader deal_name;
        private System.Windows.Forms.ColumnHeader deal_model;
        private System.Windows.Forms.ColumnHeader deal_price;
        private System.Windows.Forms.ColumnHeader deal_seller;
        private Sunny.UI.UISymbolButton custDetail;
        private Sunny.UI.UISymbolButton dealViewC;
        private System.Windows.Forms.ColumnHeader deal_date;
    }
}