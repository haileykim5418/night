
namespace CarManager0323
{
    partial class MainForm
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
            this.createTB = new Sunny.UI.UIButton();
            this.dropTB = new Sunny.UI.UIButton();
            this.insertData = new Sunny.UI.UIButton();
            this.insertCar = new Sunny.UI.UIButton();
            this.insertCustomer = new Sunny.UI.UIButton();
            this.insertSalesman = new Sunny.UI.UIButton();
            this.insertDeal = new Sunny.UI.UIButton();
            this.exitProgram = new Sunny.UI.UIButton();
            this.selectDeal = new Sunny.UI.UISymbolButton();
            this.appHelp = new Sunny.UI.UISymbolButton();
            this.createTable = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.createTable)).BeginInit();
            this.SuspendLayout();
            // 
            // createTB
            // 
            this.createTB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createTB.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.createTB.Location = new System.Drawing.Point(544, 26);
            this.createTB.MinimumSize = new System.Drawing.Size(1, 1);
            this.createTB.Name = "createTB";
            this.createTB.Size = new System.Drawing.Size(100, 35);
            this.createTB.TabIndex = 0;
            this.createTB.Text = "테이블생성";
            this.createTB.Click += new System.EventHandler(this.createTB_Click);
            // 
            // dropTB
            // 
            this.dropTB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dropTB.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.dropTB.Location = new System.Drawing.Point(650, 26);
            this.dropTB.MinimumSize = new System.Drawing.Size(1, 1);
            this.dropTB.Name = "dropTB";
            this.dropTB.Size = new System.Drawing.Size(100, 35);
            this.dropTB.TabIndex = 1;
            this.dropTB.Text = "테이블삭제";
            this.dropTB.Click += new System.EventHandler(this.dropTB_Click);
            // 
            // insertData
            // 
            this.insertData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.insertData.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.insertData.Location = new System.Drawing.Point(13, 383);
            this.insertData.MinimumSize = new System.Drawing.Size(1, 1);
            this.insertData.Name = "insertData";
            this.insertData.Size = new System.Drawing.Size(107, 35);
            this.insertData.TabIndex = 4;
            this.insertData.Text = "데이터추가All";
            // 
            // insertCar
            // 
            this.insertCar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.insertCar.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.insertCar.Location = new System.Drawing.Point(126, 383);
            this.insertCar.MinimumSize = new System.Drawing.Size(1, 1);
            this.insertCar.Name = "insertCar";
            this.insertCar.Size = new System.Drawing.Size(103, 35);
            this.insertCar.TabIndex = 5;
            this.insertCar.Text = "차량정보추가";
            this.insertCar.Click += new System.EventHandler(this.insertCar_Click);
            // 
            // insertCustomer
            // 
            this.insertCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.insertCustomer.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.insertCustomer.Location = new System.Drawing.Point(235, 383);
            this.insertCustomer.MinimumSize = new System.Drawing.Size(1, 1);
            this.insertCustomer.Name = "insertCustomer";
            this.insertCustomer.Size = new System.Drawing.Size(102, 35);
            this.insertCustomer.TabIndex = 6;
            this.insertCustomer.Text = "고객정보추가";
            this.insertCustomer.Click += new System.EventHandler(this.insertCustomer_Click);
            // 
            // insertSalesman
            // 
            this.insertSalesman.Cursor = System.Windows.Forms.Cursors.Hand;
            this.insertSalesman.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.insertSalesman.Location = new System.Drawing.Point(343, 383);
            this.insertSalesman.MinimumSize = new System.Drawing.Size(1, 1);
            this.insertSalesman.Name = "insertSalesman";
            this.insertSalesman.Size = new System.Drawing.Size(121, 35);
            this.insertSalesman.TabIndex = 7;
            this.insertSalesman.Text = "판매자정보추가";
            this.insertSalesman.Click += new System.EventHandler(this.insertSalesman_Click);
            // 
            // insertDeal
            // 
            this.insertDeal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.insertDeal.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.insertDeal.Location = new System.Drawing.Point(470, 383);
            this.insertDeal.MinimumSize = new System.Drawing.Size(1, 1);
            this.insertDeal.Name = "insertDeal";
            this.insertDeal.Size = new System.Drawing.Size(103, 35);
            this.insertDeal.TabIndex = 8;
            this.insertDeal.Text = "거래정보추가";
            this.insertDeal.Click += new System.EventHandler(this.insertDeal_Click);
            // 
            // exitProgram
            // 
            this.exitProgram.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitProgram.FillColor = System.Drawing.Color.Maroon;
            this.exitProgram.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.exitProgram.Location = new System.Drawing.Point(636, 383);
            this.exitProgram.MinimumSize = new System.Drawing.Size(1, 1);
            this.exitProgram.Name = "exitProgram";
            this.exitProgram.RectColor = System.Drawing.Color.Maroon;
            this.exitProgram.Size = new System.Drawing.Size(101, 35);
            this.exitProgram.Style = Sunny.UI.UIStyle.Custom;
            this.exitProgram.TabIndex = 9;
            this.exitProgram.Text = "프로그램종료";
            this.exitProgram.Click += new System.EventHandler(this.exitProgram_Click);
            // 
            // selectDeal
            // 
            this.selectDeal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selectDeal.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.selectDeal.Location = new System.Drawing.Point(605, 67);
            this.selectDeal.MinimumSize = new System.Drawing.Size(1, 1);
            this.selectDeal.Name = "selectDeal";
            this.selectDeal.Size = new System.Drawing.Size(145, 35);
            this.selectDeal.Symbol = 61717;
            this.selectDeal.TabIndex = 10;
            this.selectDeal.Text = "거래정보보기";
            this.selectDeal.Click += new System.EventHandler(this.selectDeal_Click_1);
            // 
            // appHelp
            // 
            this.appHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.appHelp.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.appHelp.Location = new System.Drawing.Point(650, 108);
            this.appHelp.MinimumSize = new System.Drawing.Size(1, 1);
            this.appHelp.Name = "appHelp";
            this.appHelp.Size = new System.Drawing.Size(100, 35);
            this.appHelp.Symbol = 61738;
            this.appHelp.TabIndex = 11;
            this.appHelp.Text = "도움말";
            // 
            // createTable
            // 
            this.createTable.Image = global::CarManager0323.Properties.Resources.재규어_i페이스__4_;
            this.createTable.Location = new System.Drawing.Point(-1, 59);
            this.createTable.Name = "createTable";
            this.createTable.Size = new System.Drawing.Size(751, 306);
            this.createTable.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.createTable.TabIndex = 2;
            this.createTable.TabStop = false;
            this.createTable.Click += new System.EventHandler(this.createTable_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 430);
            this.Controls.Add(this.appHelp);
            this.Controls.Add(this.selectDeal);
            this.Controls.Add(this.exitProgram);
            this.Controls.Add(this.insertDeal);
            this.Controls.Add(this.insertSalesman);
            this.Controls.Add(this.insertCustomer);
            this.Controls.Add(this.insertCar);
            this.Controls.Add(this.insertData);
            this.Controls.Add(this.createTable);
            this.Controls.Add(this.dropTB);
            this.Controls.Add(this.createTB);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "차량 고객 관리 프로그램 1.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.createTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIButton createTB;
        private Sunny.UI.UIButton dropTB;
        private System.Windows.Forms.PictureBox createTable;
        private Sunny.UI.UIButton insertData;
        private Sunny.UI.UIButton insertCar;
        private Sunny.UI.UIButton insertCustomer;
        private Sunny.UI.UIButton insertSalesman;
        private Sunny.UI.UIButton insertDeal;
        private Sunny.UI.UIButton exitProgram;
        private Sunny.UI.UISymbolButton selectDeal;
        private Sunny.UI.UISymbolButton appHelp;
    }
}

