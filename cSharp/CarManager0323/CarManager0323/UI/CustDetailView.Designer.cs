
namespace CarManager0323.UI
{
    partial class CustDetailView
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
            this.custDetailList = new System.Windows.Forms.ListView();
            this.list_count = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.list_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.list_tel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lsit_addr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.list_email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // custDetailList
            // 
            this.custDetailList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.list_count,
            this.list_name,
            this.list_tel,
            this.lsit_addr,
            this.list_email});
            this.custDetailList.Font = new System.Drawing.Font("굴림체", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.custDetailList.FullRowSelect = true;
            this.custDetailList.HideSelection = false;
            this.custDetailList.Location = new System.Drawing.Point(12, 86);
            this.custDetailList.Name = "custDetailList";
            this.custDetailList.Size = new System.Drawing.Size(671, 288);
            this.custDetailList.TabIndex = 4;
            this.custDetailList.UseCompatibleStateImageBehavior = false;
            this.custDetailList.View = System.Windows.Forms.View.Details;
            this.custDetailList.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
            // 
            // list_count
            // 
            this.list_count.Text = "번호";
            // 
            // list_name
            // 
            this.list_name.Text = "이름";
            this.list_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.list_name.Width = 80;
            // 
            // list_tel
            // 
            this.list_tel.Text = "전화번호";
            this.list_tel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.list_tel.Width = 140;
            // 
            // lsit_addr
            // 
            this.lsit_addr.Text = "주소";
            this.lsit_addr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lsit_addr.Width = 200;
            // 
            // list_email
            // 
            this.list_email.Text = "이메일";
            this.list_email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.list_email.Width = 150;
            // 
            // CustDetailView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.custDetailList);
            this.Name = "CustDetailView";
            this.Text = "고객 상세 정보";
            this.Load += new System.EventHandler(this.CustDetailView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView custDetailList;
        private System.Windows.Forms.ColumnHeader list_count;
        private System.Windows.Forms.ColumnHeader list_name;
        private System.Windows.Forms.ColumnHeader list_tel;
        private System.Windows.Forms.ColumnHeader lsit_addr;
        private System.Windows.Forms.ColumnHeader list_email;
    }
}