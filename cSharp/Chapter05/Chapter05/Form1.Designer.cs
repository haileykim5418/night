
namespace Chapter05
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1_num1 = new System.Windows.Forms.Label();
            this.label2_num2 = new System.Windows.Forms.Label();
            this.label3_num3 = new System.Windows.Forms.Label();
            this.label4_num4 = new System.Windows.Forms.Label();
            this.label5_num5 = new System.Windows.Forms.Label();
            this.label6_num6 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.image = new Sunny.UI.UIImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            this.SuspendLayout();
            // 
            // label1_num1
            // 
            this.label1_num1.AutoSize = true;
            this.label1_num1.BackColor = System.Drawing.Color.Transparent;
            this.label1_num1.Location = new System.Drawing.Point(242, 161);
            this.label1_num1.Name = "label1_num1";
            this.label1_num1.Size = new System.Drawing.Size(11, 12);
            this.label1_num1.TabIndex = 1;
            this.label1_num1.Text = "-";
            this.label1_num1.Click += new System.EventHandler(this.label1_num1_Click);
            // 
            // label2_num2
            // 
            this.label2_num2.AutoSize = true;
            this.label2_num2.Location = new System.Drawing.Point(306, 161);
            this.label2_num2.Name = "label2_num2";
            this.label2_num2.Size = new System.Drawing.Size(11, 12);
            this.label2_num2.TabIndex = 2;
            this.label2_num2.Text = "-";
            // 
            // label3_num3
            // 
            this.label3_num3.AutoSize = true;
            this.label3_num3.Location = new System.Drawing.Point(374, 161);
            this.label3_num3.Name = "label3_num3";
            this.label3_num3.Size = new System.Drawing.Size(11, 12);
            this.label3_num3.TabIndex = 3;
            this.label3_num3.Text = "-";
            // 
            // label4_num4
            // 
            this.label4_num4.AutoSize = true;
            this.label4_num4.Location = new System.Drawing.Point(446, 161);
            this.label4_num4.Name = "label4_num4";
            this.label4_num4.Size = new System.Drawing.Size(11, 12);
            this.label4_num4.TabIndex = 4;
            this.label4_num4.Text = "-";
            // 
            // label5_num5
            // 
            this.label5_num5.AutoSize = true;
            this.label5_num5.Location = new System.Drawing.Point(513, 161);
            this.label5_num5.Name = "label5_num5";
            this.label5_num5.Size = new System.Drawing.Size(11, 12);
            this.label5_num5.TabIndex = 5;
            this.label5_num5.Text = "-";
            // 
            // label6_num6
            // 
            this.label6_num6.AutoSize = true;
            this.label6_num6.Location = new System.Drawing.Point(583, 161);
            this.label6_num6.Name = "label6_num6";
            this.label6_num6.Size = new System.Drawing.Size(11, 12);
            this.label6_num6.TabIndex = 6;
            this.label6_num6.Text = "-";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(212, 141);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(277, 141);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(70, 55);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(343, 141);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(70, 55);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(483, 141);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(70, 55);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(412, 141);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(70, 55);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 13;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(550, 141);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(70, 55);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 14;
            this.pictureBox6.TabStop = false;
            // 
            // image
            // 
            this.image.Cursor = System.Windows.Forms.Cursors.Hand;
            this.image.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.image.ForeColor = System.Drawing.Color.Blue;
            this.image.Image = ((System.Drawing.Image)(resources.GetObject("image.Image")));
            this.image.Location = new System.Drawing.Point(61, 111);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(131, 115);
            this.image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.image.TabIndex = 15;
            this.image.TabStop = false;
            this.image.Text = "Click Here!";
            this.image.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.image.Click += new System.EventHandler(this.image_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.image);
            this.Controls.Add(this.label6_num6);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.label5_num5);
            this.Controls.Add(this.label4_num4);
            this.Controls.Add(this.label3_num3);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label2_num2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1_num1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1_num1;
        private System.Windows.Forms.Label label2_num2;
        private System.Windows.Forms.Label label3_num3;
        private System.Windows.Forms.Label label4_num4;
        private System.Windows.Forms.Label label5_num5;
        private System.Windows.Forms.Label label6_num6;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private Sunny.UI.UIImageButton image;
    }
}

