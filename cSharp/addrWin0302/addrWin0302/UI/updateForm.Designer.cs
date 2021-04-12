
namespace addrWin0302.UI
{
    partial class UpdateForm
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
            this.addCancle = new Sunny.UI.UISymbolButton();
            this.addOk = new Sunny.UI.UISymbolButton();
            this.upEmail = new Sunny.UI.UITextBox();
            this.uiSymbolLabel4 = new Sunny.UI.UISymbolLabel();
            this.upAddress = new Sunny.UI.UITextBox();
            this.uiSymbolLabel3 = new Sunny.UI.UISymbolLabel();
            this.upTel = new Sunny.UI.UITextBox();
            this.upName = new Sunny.UI.UITextBox();
            this.uiSymbolLabel2 = new Sunny.UI.UISymbolLabel();
            this.uiSymbolLabel1 = new Sunny.UI.UISymbolLabel();
            this.upList = new System.Windows.Forms.ListView();
            this.list_count = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.list_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.list_tel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lsit_addr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.list_email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // addCancle
            // 
            this.addCancle.BackColor = System.Drawing.Color.Transparent;
            this.addCancle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addCancle.FillColor = System.Drawing.Color.Red;
            this.addCancle.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.addCancle.IsCircle = true;
            this.addCancle.Location = new System.Drawing.Point(411, 408);
            this.addCancle.MinimumSize = new System.Drawing.Size(1, 1);
            this.addCancle.Name = "addCancle";
            this.addCancle.RectColor = System.Drawing.Color.Red;
            this.addCancle.Size = new System.Drawing.Size(55, 38);
            this.addCancle.Style = Sunny.UI.UIStyle.Custom;
            this.addCancle.Symbol = 61453;
            this.addCancle.TabIndex = 19;
            this.addCancle.Click += new System.EventHandler(this.addCancle_Click);
            // 
            // addOk
            // 
            this.addOk.BackColor = System.Drawing.Color.Transparent;
            this.addOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addOk.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.addOk.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.addOk.IsCircle = true;
            this.addOk.Location = new System.Drawing.Point(328, 408);
            this.addOk.MinimumSize = new System.Drawing.Size(1, 1);
            this.addOk.Name = "addOk";
            this.addOk.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.addOk.Size = new System.Drawing.Size(55, 38);
            this.addOk.Style = Sunny.UI.UIStyle.Custom;
            this.addOk.TabIndex = 18;
            this.addOk.Click += new System.EventHandler(this.addOk_Click);
            // 
            // upEmail
            // 
            this.upEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.upEmail.FillColor = System.Drawing.Color.White;
            this.upEmail.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.upEmail.Location = new System.Drawing.Point(411, 375);
            this.upEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.upEmail.Maximum = 2147483647D;
            this.upEmail.Minimum = -2147483648D;
            this.upEmail.MinimumSize = new System.Drawing.Size(1, 1);
            this.upEmail.Name = "upEmail";
            this.upEmail.Padding = new System.Windows.Forms.Padding(5);
            this.upEmail.Size = new System.Drawing.Size(169, 29);
            this.upEmail.TabIndex = 17;
            // 
            // uiSymbolLabel4
            // 
            this.uiSymbolLabel4.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel4.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel4.Location = new System.Drawing.Point(208, 375);
            this.uiSymbolLabel4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel4.Name = "uiSymbolLabel4";
            this.uiSymbolLabel4.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel4.Size = new System.Drawing.Size(175, 23);
            this.uiSymbolLabel4.Symbol = 57360;
            this.uiSymbolLabel4.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.uiSymbolLabel4.TabIndex = 16;
            this.uiSymbolLabel4.Text = "이메일";
            // 
            // upAddress
            // 
            this.upAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.upAddress.FillColor = System.Drawing.Color.White;
            this.upAddress.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.upAddress.Location = new System.Drawing.Point(411, 336);
            this.upAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.upAddress.Maximum = 2147483647D;
            this.upAddress.Minimum = -2147483648D;
            this.upAddress.MinimumSize = new System.Drawing.Size(1, 1);
            this.upAddress.Name = "upAddress";
            this.upAddress.Padding = new System.Windows.Forms.Padding(5);
            this.upAddress.Size = new System.Drawing.Size(169, 29);
            this.upAddress.TabIndex = 15;
            // 
            // uiSymbolLabel3
            // 
            this.uiSymbolLabel3.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel3.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel3.Location = new System.Drawing.Point(208, 336);
            this.uiSymbolLabel3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel3.Name = "uiSymbolLabel3";
            this.uiSymbolLabel3.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel3.Size = new System.Drawing.Size(175, 23);
            this.uiSymbolLabel3.Symbol = 57568;
            this.uiSymbolLabel3.SymbolColor = System.Drawing.Color.Blue;
            this.uiSymbolLabel3.TabIndex = 14;
            this.uiSymbolLabel3.Text = "주소";
            // 
            // upTel
            // 
            this.upTel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.upTel.FillColor = System.Drawing.Color.White;
            this.upTel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.upTel.Location = new System.Drawing.Point(411, 297);
            this.upTel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.upTel.Maximum = 2147483647D;
            this.upTel.Minimum = -2147483648D;
            this.upTel.MinimumSize = new System.Drawing.Size(1, 1);
            this.upTel.Name = "upTel";
            this.upTel.Padding = new System.Windows.Forms.Padding(5);
            this.upTel.Size = new System.Drawing.Size(169, 29);
            this.upTel.TabIndex = 13;
           
            // 
            // upName
            // 
            this.upName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.upName.FillColor = System.Drawing.Color.White;
            this.upName.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.upName.Location = new System.Drawing.Point(411, 258);
            this.upName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.upName.Maximum = 2147483647D;
            this.upName.Minimum = -2147483648D;
            this.upName.MinimumSize = new System.Drawing.Size(1, 1);
            this.upName.Name = "upName";
            this.upName.Padding = new System.Windows.Forms.Padding(5);
            this.upName.Size = new System.Drawing.Size(169, 29);
            this.upName.TabIndex = 11;
       
            // 
            // uiSymbolLabel2
            // 
            this.uiSymbolLabel2.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel2.Location = new System.Drawing.Point(208, 297);
            this.uiSymbolLabel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel2.Name = "uiSymbolLabel2";
            this.uiSymbolLabel2.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel2.Size = new System.Drawing.Size(175, 23);
            this.uiSymbolLabel2.Symbol = 57488;
            this.uiSymbolLabel2.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.uiSymbolLabel2.TabIndex = 12;
            this.uiSymbolLabel2.Text = "전화";

            // 
            // uiSymbolLabel1
            // 
            this.uiSymbolLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel1.Location = new System.Drawing.Point(208, 264);
            this.uiSymbolLabel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel1.Name = "uiSymbolLabel1";
            this.uiSymbolLabel1.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel1.Size = new System.Drawing.Size(175, 23);
            this.uiSymbolLabel1.Symbol = 62144;
            this.uiSymbolLabel1.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.uiSymbolLabel1.TabIndex = 10;
            this.uiSymbolLabel1.Text = "이름";
           
            // 
            // upList
            // 
            this.upList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.list_count,
            this.list_name,
            this.list_tel,
            this.lsit_addr,
            this.list_email});
            this.upList.Font = new System.Drawing.Font("굴림체", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.upList.FullRowSelect = true;
            this.upList.HideSelection = false;
            this.upList.Location = new System.Drawing.Point(46, 80);
            this.upList.Name = "upList";
            this.upList.Size = new System.Drawing.Size(723, 168);
            this.upList.TabIndex = 20;
            this.upList.UseCompatibleStateImageBehavior = false;
            this.upList.View = System.Windows.Forms.View.Details;
            this.upList.SelectedIndexChanged += new System.EventHandler(this.upList_SelectedIndexChanged);
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
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.upList);
            this.Controls.Add(this.addCancle);
            this.Controls.Add(this.addOk);
            this.Controls.Add(this.upEmail);
            this.Controls.Add(this.uiSymbolLabel4);
            this.Controls.Add(this.upAddress);
            this.Controls.Add(this.uiSymbolLabel3);
            this.Controls.Add(this.upTel);
            this.Controls.Add(this.upName);
            this.Controls.Add(this.uiSymbolLabel2);
            this.Controls.Add(this.uiSymbolLabel1);
            this.Name = "UpdateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "데이터수정";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UISymbolButton addCancle;
        private Sunny.UI.UISymbolButton addOk;
        private Sunny.UI.UITextBox upEmail;
        private Sunny.UI.UISymbolLabel uiSymbolLabel4;
        private Sunny.UI.UITextBox upAddress;
        private Sunny.UI.UISymbolLabel uiSymbolLabel3;
        private Sunny.UI.UITextBox upTel;
        private Sunny.UI.UITextBox upName;
        private Sunny.UI.UISymbolLabel uiSymbolLabel2;
        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
        private System.Windows.Forms.ListView upList;
        private System.Windows.Forms.ColumnHeader list_count;
        private System.Windows.Forms.ColumnHeader list_name;
        private System.Windows.Forms.ColumnHeader list_tel;
        private System.Windows.Forms.ColumnHeader lsit_addr;
        private System.Windows.Forms.ColumnHeader list_email;
    }
}