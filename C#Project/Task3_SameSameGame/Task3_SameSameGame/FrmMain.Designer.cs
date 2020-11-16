namespace Task3_SameSameGame
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.picScore5 = new System.Windows.Forms.PictureBox();
            this.picScore4 = new System.Windows.Forms.PictureBox();
            this.picScore3 = new System.Windows.Forms.PictureBox();
            this.picScore2 = new System.Windows.Forms.PictureBox();
            this.picScore1 = new System.Windows.Forms.PictureBox();
            this.picBlock3 = new System.Windows.Forms.PictureBox();
            this.picBlock2 = new System.Windows.Forms.PictureBox();
            this.picBlock1 = new System.Windows.Forms.PictureBox();
            this.panMain = new System.Windows.Forms.Panel();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.imglstBlock = new System.Windows.Forms.ImageList(this.components);
            this.imglstSel = new System.Windows.Forms.ImageList(this.components);
            this.imglstNum = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picScore5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picScore4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picScore3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picScore2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picScore1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBlock3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBlock2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBlock1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox1.Size = new System.Drawing.Size(74, 23);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Score : ";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Control;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox2.Location = new System.Drawing.Point(239, 12);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(74, 23);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "Block : ";
            // 
            // picScore5
            // 
            this.picScore5.Location = new System.Drawing.Point(92, 10);
            this.picScore5.Name = "picScore5";
            this.picScore5.Size = new System.Drawing.Size(20, 25);
            this.picScore5.TabIndex = 2;
            this.picScore5.TabStop = false;
            // 
            // picScore4
            // 
            this.picScore4.Location = new System.Drawing.Point(118, 10);
            this.picScore4.Name = "picScore4";
            this.picScore4.Size = new System.Drawing.Size(20, 25);
            this.picScore4.TabIndex = 3;
            this.picScore4.TabStop = false;
            // 
            // picScore3
            // 
            this.picScore3.Location = new System.Drawing.Point(144, 10);
            this.picScore3.Name = "picScore3";
            this.picScore3.Size = new System.Drawing.Size(20, 25);
            this.picScore3.TabIndex = 4;
            this.picScore3.TabStop = false;
            // 
            // picScore2
            // 
            this.picScore2.Location = new System.Drawing.Point(170, 10);
            this.picScore2.Name = "picScore2";
            this.picScore2.Size = new System.Drawing.Size(20, 25);
            this.picScore2.TabIndex = 5;
            this.picScore2.TabStop = false;
            // 
            // picScore1
            // 
            this.picScore1.Location = new System.Drawing.Point(196, 10);
            this.picScore1.Name = "picScore1";
            this.picScore1.Size = new System.Drawing.Size(20, 25);
            this.picScore1.TabIndex = 6;
            this.picScore1.TabStop = false;
            // 
            // picBlock3
            // 
            this.picBlock3.Location = new System.Drawing.Point(319, 10);
            this.picBlock3.Name = "picBlock3";
            this.picBlock3.Size = new System.Drawing.Size(20, 25);
            this.picBlock3.TabIndex = 7;
            this.picBlock3.TabStop = false;
            // 
            // picBlock2
            // 
            this.picBlock2.Location = new System.Drawing.Point(345, 10);
            this.picBlock2.Name = "picBlock2";
            this.picBlock2.Size = new System.Drawing.Size(20, 25);
            this.picBlock2.TabIndex = 8;
            this.picBlock2.TabStop = false;
            // 
            // picBlock1
            // 
            this.picBlock1.Location = new System.Drawing.Point(371, 10);
            this.picBlock1.Name = "picBlock1";
            this.picBlock1.Size = new System.Drawing.Size(20, 25);
            this.picBlock1.TabIndex = 9;
            this.picBlock1.TabStop = false;
            // 
            // panMain
            // 
            this.panMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panMain.BackgroundImage")));
            this.panMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panMain.Location = new System.Drawing.Point(6, 49);
            this.panMain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panMain.Name = "panMain";
            this.panMain.Size = new System.Drawing.Size(690, 379);
            this.panMain.TabIndex = 27;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(12, 426);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(109, 36);
            this.btnNew.TabIndex = 11;
            this.btnNew.Text = "New Game";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(127, 426);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(109, 36);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Exit Game";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // imglstBlock
            // 
            this.imglstBlock.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglstBlock.ImageStream")));
            this.imglstBlock.TransparentColor = System.Drawing.Color.Transparent;
            this.imglstBlock.Images.SetKeyName(0, "b1.bmp");
            this.imglstBlock.Images.SetKeyName(1, "b2.bmp");
            this.imglstBlock.Images.SetKeyName(2, "b3.bmp");
            this.imglstBlock.Images.SetKeyName(3, "b4.bmp");
            this.imglstBlock.Images.SetKeyName(4, "b5.bmp");
            // 
            // imglstSel
            // 
            this.imglstSel.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglstSel.ImageStream")));
            this.imglstSel.TransparentColor = System.Drawing.Color.Transparent;
            this.imglstSel.Images.SetKeyName(0, "s1.bmp");
            this.imglstSel.Images.SetKeyName(1, "s2.bmp");
            this.imglstSel.Images.SetKeyName(2, "s3.bmp");
            this.imglstSel.Images.SetKeyName(3, "s4.bmp");
            this.imglstSel.Images.SetKeyName(4, "s5.bmp");
            // 
            // imglstNum
            // 
            this.imglstNum.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglstNum.ImageStream")));
            this.imglstNum.TransparentColor = System.Drawing.Color.Transparent;
            this.imglstNum.Images.SetKeyName(0, "0.bmp");
            this.imglstNum.Images.SetKeyName(1, "1.bmp");
            this.imglstNum.Images.SetKeyName(2, "2.bmp");
            this.imglstNum.Images.SetKeyName(3, "3.bmp");
            this.imglstNum.Images.SetKeyName(4, "4.bmp");
            this.imglstNum.Images.SetKeyName(5, "5.bmp");
            this.imglstNum.Images.SetKeyName(6, "6.bmp");
            this.imglstNum.Images.SetKeyName(7, "7.bmp");
            this.imglstNum.Images.SetKeyName(8, "8.bmp");
            this.imglstNum.Images.SetKeyName(9, "9.bmp");
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 469);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.panMain);
            this.Controls.Add(this.picBlock1);
            this.Controls.Add(this.picBlock2);
            this.Controls.Add(this.picBlock3);
            this.Controls.Add(this.picScore1);
            this.Controls.Add(this.picScore2);
            this.Controls.Add(this.picScore3);
            this.Controls.Add(this.picScore4);
            this.Controls.Add(this.picScore5);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "FrmMain";
            this.Text = "셈셈 게임";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmMain_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.picScore5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picScore4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picScore3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picScore2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picScore1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBlock3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBlock2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBlock1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.PictureBox picScore5;
        private System.Windows.Forms.PictureBox picScore4;
        private System.Windows.Forms.PictureBox picScore3;
        private System.Windows.Forms.PictureBox picScore2;
        private System.Windows.Forms.PictureBox picScore1;
        private System.Windows.Forms.PictureBox picBlock3;
        private System.Windows.Forms.PictureBox picBlock2;
        private System.Windows.Forms.PictureBox picBlock1;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ImageList imglstBlock;
        private System.Windows.Forms.ImageList imglstSel;
        private System.Windows.Forms.ImageList imglstNum;
        internal System.Windows.Forms.Panel panMain;
    }
}

