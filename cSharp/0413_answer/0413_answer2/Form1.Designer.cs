
namespace _0413_answer2
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
            this.scissors = new System.Windows.Forms.Button();
            this.rock = new System.Windows.Forms.Button();
            this.paper = new System.Windows.Forms.Button();
            this.label_myR = new System.Windows.Forms.Label();
            this.label_pcR = new System.Windows.Forms.Label();
            this.label_R = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // scissors
            // 
            this.scissors.Location = new System.Drawing.Point(91, 47);
            this.scissors.Name = "scissors";
            this.scissors.Size = new System.Drawing.Size(75, 23);
            this.scissors.TabIndex = 0;
            this.scissors.Text = "가위";
            this.scissors.UseVisualStyleBackColor = true;
            this.scissors.Click += new System.EventHandler(this.button1_Click);
            // 
            // rock
            // 
            this.rock.Location = new System.Drawing.Point(172, 47);
            this.rock.Name = "rock";
            this.rock.Size = new System.Drawing.Size(75, 23);
            this.rock.TabIndex = 1;
            this.rock.Text = "바위";
            this.rock.UseVisualStyleBackColor = true;
            this.rock.Click += new System.EventHandler(this.button2_Click);
            // 
            // paper
            // 
            this.paper.Location = new System.Drawing.Point(253, 47);
            this.paper.Name = "paper";
            this.paper.Size = new System.Drawing.Size(75, 23);
            this.paper.TabIndex = 2;
            this.paper.Text = "보";
            this.paper.UseVisualStyleBackColor = true;
            this.paper.Click += new System.EventHandler(this.button3_Click);
            // 
            // label_myR
            // 
            this.label_myR.AutoSize = true;
            this.label_myR.Location = new System.Drawing.Point(204, 155);
            this.label_myR.Name = "label_myR";
            this.label_myR.Size = new System.Drawing.Size(11, 12);
            this.label_myR.TabIndex = 3;
            this.label_myR.Text = "-";
            // 
            // label_pcR
            // 
            this.label_pcR.AutoSize = true;
            this.label_pcR.Location = new System.Drawing.Point(202, 189);
            this.label_pcR.Name = "label_pcR";
            this.label_pcR.Size = new System.Drawing.Size(11, 12);
            this.label_pcR.TabIndex = 4;
            this.label_pcR.Text = "-";
            // 
            // label_R
            // 
            this.label_R.AutoSize = true;
            this.label_R.Location = new System.Drawing.Point(203, 218);
            this.label_R.Name = "label_R";
            this.label_R.Size = new System.Drawing.Size(11, 12);
            this.label_R.TabIndex = 5;
            this.label_R.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "나:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(89, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "컴퓨터:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(89, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 12);
            this.label6.TabIndex = 8;
            this.label6.Text = "결과:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label_R);
            this.Controls.Add(this.label_pcR);
            this.Controls.Add(this.label_myR);
            this.Controls.Add(this.paper);
            this.Controls.Add(this.rock);
            this.Controls.Add(this.scissors);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button scissors;
        private System.Windows.Forms.Button rock;
        private System.Windows.Forms.Button paper;
        private System.Windows.Forms.Label label_myR;
        private System.Windows.Forms.Label label_pcR;
        private System.Windows.Forms.Label label_R;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

