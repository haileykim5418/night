
namespace CarManager0323.UI
{
    partial class CustInsForm
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
            this.carCancle = new Sunny.UI.UISymbolButton();
            this.custOk = new Sunny.UI.UISymbolButton();
            this.cu_email = new Sunny.UI.UITextBox();
            this.제조사 = new Sunny.UI.UISymbolLabel();
            this.cu_address = new Sunny.UI.UITextBox();
            this.uiSymbolLabel3 = new Sunny.UI.UISymbolLabel();
            this.cu_tel = new Sunny.UI.UITextBox();
            this.cu_name = new Sunny.UI.UITextBox();
            this.uiSymbolLabel2 = new Sunny.UI.UISymbolLabel();
            this.uiSymbolLabel1 = new Sunny.UI.UISymbolLabel();
            this.SuspendLayout();
            // 
            // carCancle
            // 
            this.carCancle.BackColor = System.Drawing.Color.Transparent;
            this.carCancle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.carCancle.FillColor = System.Drawing.Color.Red;
            this.carCancle.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.carCancle.IsCircle = true;
            this.carCancle.Location = new System.Drawing.Point(422, 336);
            this.carCancle.MinimumSize = new System.Drawing.Size(1, 1);
            this.carCancle.Name = "carCancle";
            this.carCancle.RectColor = System.Drawing.Color.Red;
            this.carCancle.Size = new System.Drawing.Size(50, 50);
            this.carCancle.Style = Sunny.UI.UIStyle.Custom;
            this.carCancle.Symbol = 61453;
            this.carCancle.TabIndex = 31;
            // 
            // custOk
            // 
            this.custOk.BackColor = System.Drawing.Color.Transparent;
            this.custOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.custOk.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.custOk.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.custOk.IsCircle = true;
            this.custOk.Location = new System.Drawing.Point(336, 336);
            this.custOk.MinimumSize = new System.Drawing.Size(1, 1);
            this.custOk.Name = "custOk";
            this.custOk.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.custOk.Size = new System.Drawing.Size(50, 50);
            this.custOk.Style = Sunny.UI.UIStyle.Custom;
            this.custOk.TabIndex = 30;
            this.custOk.Click += new System.EventHandler(this.addOk_Click);
            // 
            // cu_email
            // 
            this.cu_email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cu_email.FillColor = System.Drawing.Color.White;
            this.cu_email.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.cu_email.Location = new System.Drawing.Point(420, 236);
            this.cu_email.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cu_email.Maximum = 2147483647D;
            this.cu_email.Minimum = -2147483648D;
            this.cu_email.MinimumSize = new System.Drawing.Size(1, 1);
            this.cu_email.Name = "cu_email";
            this.cu_email.Padding = new System.Windows.Forms.Padding(5);
            this.cu_email.Size = new System.Drawing.Size(164, 29);
            this.cu_email.TabIndex = 29;
            // 
            // 제조사
            // 
            this.제조사.BackColor = System.Drawing.Color.Transparent;
            this.제조사.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.제조사.Location = new System.Drawing.Point(217, 236);
            this.제조사.MinimumSize = new System.Drawing.Size(1, 1);
            this.제조사.Name = "제조사";
            this.제조사.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.제조사.Size = new System.Drawing.Size(170, 35);
            this.제조사.Symbol = 57360;
            this.제조사.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.제조사.TabIndex = 28;
            this.제조사.Text = "메일";
            // 
            // cu_address
            // 
            this.cu_address.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cu_address.FillColor = System.Drawing.Color.White;
            this.cu_address.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.cu_address.Location = new System.Drawing.Point(420, 183);
            this.cu_address.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cu_address.Maximum = 2147483647D;
            this.cu_address.Minimum = -2147483648D;
            this.cu_address.MinimumSize = new System.Drawing.Size(1, 1);
            this.cu_address.Name = "cu_address";
            this.cu_address.Padding = new System.Windows.Forms.Padding(5);
            this.cu_address.Size = new System.Drawing.Size(164, 29);
            this.cu_address.TabIndex = 27;
            // 
            // uiSymbolLabel3
            // 
            this.uiSymbolLabel3.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel3.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel3.Location = new System.Drawing.Point(217, 183);
            this.uiSymbolLabel3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel3.Name = "uiSymbolLabel3";
            this.uiSymbolLabel3.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel3.Size = new System.Drawing.Size(170, 35);
            this.uiSymbolLabel3.Symbol = 57568;
            this.uiSymbolLabel3.SymbolColor = System.Drawing.Color.Blue;
            this.uiSymbolLabel3.TabIndex = 26;
            this.uiSymbolLabel3.Text = "주소";
            // 
            // cu_tel
            // 
            this.cu_tel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cu_tel.FillColor = System.Drawing.Color.White;
            this.cu_tel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.cu_tel.Location = new System.Drawing.Point(420, 132);
            this.cu_tel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cu_tel.Maximum = 2147483647D;
            this.cu_tel.Minimum = -2147483648D;
            this.cu_tel.MinimumSize = new System.Drawing.Size(1, 1);
            this.cu_tel.Name = "cu_tel";
            this.cu_tel.Padding = new System.Windows.Forms.Padding(5);
            this.cu_tel.Size = new System.Drawing.Size(164, 29);
            this.cu_tel.TabIndex = 25;
            // 
            // cu_name
            // 
            this.cu_name.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.cu_name.FillColor = System.Drawing.Color.White;
            this.cu_name.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.cu_name.Location = new System.Drawing.Point(420, 81);
            this.cu_name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cu_name.Maximum = 2147483647D;
            this.cu_name.Minimum = -2147483648D;
            this.cu_name.MinimumSize = new System.Drawing.Size(1, 1);
            this.cu_name.Name = "cu_name";
            this.cu_name.Padding = new System.Windows.Forms.Padding(5);
            this.cu_name.Size = new System.Drawing.Size(164, 29);
            this.cu_name.TabIndex = 23;
            this.cu_name.UseWaitCursor = true;
            // 
            // uiSymbolLabel2
            // 
            this.uiSymbolLabel2.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel2.Location = new System.Drawing.Point(217, 132);
            this.uiSymbolLabel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel2.Name = "uiSymbolLabel2";
            this.uiSymbolLabel2.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel2.Size = new System.Drawing.Size(170, 35);
            this.uiSymbolLabel2.Symbol = 57488;
            this.uiSymbolLabel2.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.uiSymbolLabel2.TabIndex = 24;
            this.uiSymbolLabel2.Text = "번호";
            // 
            // uiSymbolLabel1
            // 
            this.uiSymbolLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel1.Location = new System.Drawing.Point(217, 81);
            this.uiSymbolLabel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel1.Name = "uiSymbolLabel1";
            this.uiSymbolLabel1.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel1.Size = new System.Drawing.Size(170, 35);
            this.uiSymbolLabel1.Symbol = 62144;
            this.uiSymbolLabel1.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.uiSymbolLabel1.TabIndex = 22;
            this.uiSymbolLabel1.Text = "이름";
            // 
            // CustInsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.carCancle);
            this.Controls.Add(this.custOk);
            this.Controls.Add(this.cu_email);
            this.Controls.Add(this.제조사);
            this.Controls.Add(this.cu_address);
            this.Controls.Add(this.uiSymbolLabel3);
            this.Controls.Add(this.cu_tel);
            this.Controls.Add(this.cu_name);
            this.Controls.Add(this.uiSymbolLabel2);
            this.Controls.Add(this.uiSymbolLabel1);
            this.Name = "CustInsForm";
            this.Text = "고객 정보 추가";
            this.Load += new System.EventHandler(this.CustInsForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UISymbolButton carCancle;
        private Sunny.UI.UISymbolButton custOk;
        private Sunny.UI.UITextBox cu_email;
        private Sunny.UI.UISymbolLabel 제조사;
        private Sunny.UI.UITextBox cu_address;
        private Sunny.UI.UISymbolLabel uiSymbolLabel3;
        private Sunny.UI.UITextBox cu_tel;
        private Sunny.UI.UITextBox cu_name;
        private Sunny.UI.UISymbolLabel uiSymbolLabel2;
        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
    }
}