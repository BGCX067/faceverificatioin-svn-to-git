namespace PCterminal
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.OpenServerBtn = new System.Windows.Forms.Button();
            this.CapturedpictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.getRecentpic = new System.Windows.Forms.Button();
            this.namelabel = new System.Windows.Forms.Label();
            this.sexlabel = new System.Windows.Forms.Label();
            this.ethniclabel = new System.Windows.Forms.Label();
            this.birthdatelabel = new System.Windows.Forms.Label();
            this.addresslabel = new System.Windows.Forms.Label();
            this.idlabel = new System.Windows.Forms.Label();
            this.authorizelabel = new System.Windows.Forms.Label();
            this.validdatelabel = new System.Windows.Forms.Label();
            this.photolabel = new System.Windows.Forms.Label();
            this.nametextBox = new System.Windows.Forms.TextBox();
            this.sextextBox = new System.Windows.Forms.TextBox();
            this.ethnictextBox = new System.Windows.Forms.TextBox();
            this.birthdaytextBox = new System.Windows.Forms.TextBox();
            this.addresstextBox = new System.Windows.Forms.TextBox();
            this.idnumtextBox = new System.Windows.Forms.TextBox();
            this.authorizetextBox = new System.Windows.Forms.TextBox();
            this.validdatetextBox = new System.Windows.Forms.TextBox();
            this.cardpictureBox = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.errorNumtextBox = new System.Windows.Forms.TextBox();
            this.errorinfotextBox = new System.Windows.Forms.TextBox();
            this.readinfobutton = new System.Windows.Forms.Button();
            this.errorNumlabel = new System.Windows.Forms.Label();
            this.errorInfolabel = new System.Windows.Forms.Label();
            this.sendImgBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CapturedpictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardpictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // OpenServerBtn
            // 
            this.OpenServerBtn.Location = new System.Drawing.Point(613, 24);
            this.OpenServerBtn.Name = "OpenServerBtn";
            this.OpenServerBtn.Size = new System.Drawing.Size(122, 39);
            this.OpenServerBtn.TabIndex = 0;
            this.OpenServerBtn.Text = "打开侦听接口";
            this.OpenServerBtn.UseVisualStyleBackColor = true;
            this.OpenServerBtn.Click += new System.EventHandler(this.OpenServerBtn_Click);
            // 
            // CapturedpictureBox
            // 
            this.CapturedpictureBox.Location = new System.Drawing.Point(613, 163);
            this.CapturedpictureBox.Name = "CapturedpictureBox";
            this.CapturedpictureBox.Size = new System.Drawing.Size(320, 240);
            this.CapturedpictureBox.TabIndex = 1;
            this.CapturedpictureBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(611, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "拍摄图片";
            // 
            // getRecentpic
            // 
            this.getRecentpic.Location = new System.Drawing.Point(716, 412);
            this.getRecentpic.Name = "getRecentpic";
            this.getRecentpic.Size = new System.Drawing.Size(110, 40);
            this.getRecentpic.TabIndex = 3;
            this.getRecentpic.Text = "获取拍摄图片";
            this.getRecentpic.UseVisualStyleBackColor = true;
            this.getRecentpic.Click += new System.EventHandler(this.GetRecentpicBtn_Click);
            // 
            // namelabel
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.Location = new System.Drawing.Point(31, 96);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(29, 12);
            this.namelabel.TabIndex = 4;
            this.namelabel.Text = "姓名";
            // 
            // sexlabel
            // 
            this.sexlabel.AutoSize = true;
            this.sexlabel.Location = new System.Drawing.Point(31, 146);
            this.sexlabel.Name = "sexlabel";
            this.sexlabel.Size = new System.Drawing.Size(29, 12);
            this.sexlabel.TabIndex = 5;
            this.sexlabel.Text = "性别";
            // 
            // ethniclabel
            // 
            this.ethniclabel.AutoSize = true;
            this.ethniclabel.Location = new System.Drawing.Point(31, 195);
            this.ethniclabel.Name = "ethniclabel";
            this.ethniclabel.Size = new System.Drawing.Size(29, 12);
            this.ethniclabel.TabIndex = 6;
            this.ethniclabel.Text = "民族";
            // 
            // birthdatelabel
            // 
            this.birthdatelabel.AutoSize = true;
            this.birthdatelabel.Location = new System.Drawing.Point(31, 246);
            this.birthdatelabel.Name = "birthdatelabel";
            this.birthdatelabel.Size = new System.Drawing.Size(53, 12);
            this.birthdatelabel.TabIndex = 7;
            this.birthdatelabel.Text = "出生日期";
            // 
            // addresslabel
            // 
            this.addresslabel.AutoSize = true;
            this.addresslabel.Location = new System.Drawing.Point(31, 299);
            this.addresslabel.Name = "addresslabel";
            this.addresslabel.Size = new System.Drawing.Size(29, 12);
            this.addresslabel.TabIndex = 8;
            this.addresslabel.Text = "地址";
            // 
            // idlabel
            // 
            this.idlabel.AutoSize = true;
            this.idlabel.Location = new System.Drawing.Point(31, 357);
            this.idlabel.Name = "idlabel";
            this.idlabel.Size = new System.Drawing.Size(65, 12);
            this.idlabel.TabIndex = 9;
            this.idlabel.Text = "身份证号码";
            // 
            // authorizelabel
            // 
            this.authorizelabel.AutoSize = true;
            this.authorizelabel.Location = new System.Drawing.Point(31, 412);
            this.authorizelabel.Name = "authorizelabel";
            this.authorizelabel.Size = new System.Drawing.Size(53, 12);
            this.authorizelabel.TabIndex = 10;
            this.authorizelabel.Text = "签发机关";
            // 
            // validdatelabel
            // 
            this.validdatelabel.AutoSize = true;
            this.validdatelabel.Location = new System.Drawing.Point(31, 464);
            this.validdatelabel.Name = "validdatelabel";
            this.validdatelabel.Size = new System.Drawing.Size(53, 12);
            this.validdatelabel.TabIndex = 11;
            this.validdatelabel.Text = "有效期限";
            // 
            // photolabel
            // 
            this.photolabel.AutoSize = true;
            this.photolabel.Location = new System.Drawing.Point(380, 127);
            this.photolabel.Name = "photolabel";
            this.photolabel.Size = new System.Drawing.Size(65, 12);
            this.photolabel.TabIndex = 13;
            this.photolabel.Text = "身份证照片";
            // 
            // nametextBox
            // 
            this.nametextBox.Location = new System.Drawing.Point(125, 93);
            this.nametextBox.Name = "nametextBox";
            this.nametextBox.Size = new System.Drawing.Size(68, 21);
            this.nametextBox.TabIndex = 14;
            // 
            // sextextBox
            // 
            this.sextextBox.Location = new System.Drawing.Point(125, 143);
            this.sextextBox.Name = "sextextBox";
            this.sextextBox.Size = new System.Drawing.Size(42, 21);
            this.sextextBox.TabIndex = 15;
            // 
            // ethnictextBox
            // 
            this.ethnictextBox.Location = new System.Drawing.Point(125, 192);
            this.ethnictextBox.Name = "ethnictextBox";
            this.ethnictextBox.Size = new System.Drawing.Size(68, 21);
            this.ethnictextBox.TabIndex = 16;
            // 
            // birthdaytextBox
            // 
            this.birthdaytextBox.Location = new System.Drawing.Point(125, 243);
            this.birthdaytextBox.Name = "birthdaytextBox";
            this.birthdaytextBox.Size = new System.Drawing.Size(197, 21);
            this.birthdaytextBox.TabIndex = 17;
            // 
            // addresstextBox
            // 
            this.addresstextBox.Location = new System.Drawing.Point(125, 296);
            this.addresstextBox.Name = "addresstextBox";
            this.addresstextBox.Size = new System.Drawing.Size(251, 21);
            this.addresstextBox.TabIndex = 18;
            // 
            // idnumtextBox
            // 
            this.idnumtextBox.Location = new System.Drawing.Point(125, 354);
            this.idnumtextBox.Name = "idnumtextBox";
            this.idnumtextBox.Size = new System.Drawing.Size(251, 21);
            this.idnumtextBox.TabIndex = 19;
            // 
            // authorizetextBox
            // 
            this.authorizetextBox.Location = new System.Drawing.Point(125, 412);
            this.authorizetextBox.Name = "authorizetextBox";
            this.authorizetextBox.Size = new System.Drawing.Size(251, 21);
            this.authorizetextBox.TabIndex = 20;
            // 
            // validdatetextBox
            // 
            this.validdatetextBox.Location = new System.Drawing.Point(125, 461);
            this.validdatetextBox.Name = "validdatetextBox";
            this.validdatetextBox.Size = new System.Drawing.Size(251, 21);
            this.validdatetextBox.TabIndex = 21;
            // 
            // cardpictureBox
            // 
            this.cardpictureBox.Location = new System.Drawing.Point(401, 163);
            this.cardpictureBox.Name = "cardpictureBox";
            this.cardpictureBox.Size = new System.Drawing.Size(161, 190);
            this.cardpictureBox.TabIndex = 22;
            this.cardpictureBox.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(328, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "初始化设备";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ReadCardBtn_Click);
            // 
            // errorNumtextBox
            // 
            this.errorNumtextBox.Location = new System.Drawing.Point(299, 503);
            this.errorNumtextBox.Name = "errorNumtextBox";
            this.errorNumtextBox.Size = new System.Drawing.Size(100, 21);
            this.errorNumtextBox.TabIndex = 24;
            // 
            // errorinfotextBox
            // 
            this.errorinfotextBox.Location = new System.Drawing.Point(564, 503);
            this.errorinfotextBox.Name = "errorinfotextBox";
            this.errorinfotextBox.Size = new System.Drawing.Size(148, 21);
            this.errorinfotextBox.TabIndex = 25;
            // 
            // readinfobutton
            // 
            this.readinfobutton.Location = new System.Drawing.Point(328, 61);
            this.readinfobutton.Name = "readinfobutton";
            this.readinfobutton.Size = new System.Drawing.Size(75, 23);
            this.readinfobutton.TabIndex = 26;
            this.readinfobutton.Text = "读取信息";
            this.readinfobutton.UseVisualStyleBackColor = true;
            this.readinfobutton.Click += new System.EventHandler(this.ReadInfoBtn_Click);
            // 
            // errorNumlabel
            // 
            this.errorNumlabel.AutoSize = true;
            this.errorNumlabel.Location = new System.Drawing.Point(209, 506);
            this.errorNumlabel.Name = "errorNumlabel";
            this.errorNumlabel.Size = new System.Drawing.Size(53, 12);
            this.errorNumlabel.TabIndex = 27;
            this.errorNumlabel.Text = "错误代码";
            // 
            // errorInfolabel
            // 
            this.errorInfolabel.AutoSize = true;
            this.errorInfolabel.Location = new System.Drawing.Point(479, 506);
            this.errorInfolabel.Name = "errorInfolabel";
            this.errorInfolabel.Size = new System.Drawing.Size(53, 12);
            this.errorInfolabel.TabIndex = 28;
            this.errorInfolabel.Text = "错误信息";
            // 
            // sendImgBtn
            // 
            this.sendImgBtn.Location = new System.Drawing.Point(832, 412);
            this.sendImgBtn.Name = "sendImgBtn";
            this.sendImgBtn.Size = new System.Drawing.Size(101, 40);
            this.sendImgBtn.TabIndex = 29;
            this.sendImgBtn.Text = "发送图片";
            this.sendImgBtn.UseVisualStyleBackColor = true;
            this.sendImgBtn.Click += new System.EventHandler(this.SendImgBtn_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(938, 164);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(30, 238);
            this.button2.TabIndex = 30;
            this.button2.Text = ">>";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ShowRecentPicBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 559);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.sendImgBtn);
            this.Controls.Add(this.errorInfolabel);
            this.Controls.Add(this.errorNumlabel);
            this.Controls.Add(this.readinfobutton);
            this.Controls.Add(this.errorinfotextBox);
            this.Controls.Add(this.errorNumtextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cardpictureBox);
            this.Controls.Add(this.validdatetextBox);
            this.Controls.Add(this.authorizetextBox);
            this.Controls.Add(this.idnumtextBox);
            this.Controls.Add(this.addresstextBox);
            this.Controls.Add(this.birthdaytextBox);
            this.Controls.Add(this.ethnictextBox);
            this.Controls.Add(this.sextextBox);
            this.Controls.Add(this.nametextBox);
            this.Controls.Add(this.photolabel);
            this.Controls.Add(this.validdatelabel);
            this.Controls.Add(this.authorizelabel);
            this.Controls.Add(this.idlabel);
            this.Controls.Add(this.addresslabel);
            this.Controls.Add(this.birthdatelabel);
            this.Controls.Add(this.ethniclabel);
            this.Controls.Add(this.sexlabel);
            this.Controls.Add(this.namelabel);
            this.Controls.Add(this.getRecentpic);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CapturedpictureBox);
            this.Controls.Add(this.OpenServerBtn);
            this.Name = "MainForm";
            this.Text = "身份证终端验证系统";
            ((System.ComponentModel.ISupportInitialize)(this.CapturedpictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardpictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OpenServerBtn;
        private System.Windows.Forms.PictureBox CapturedpictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button getRecentpic;
        private System.Windows.Forms.Label namelabel;
        private System.Windows.Forms.Label sexlabel;
        private System.Windows.Forms.Label ethniclabel;
        private System.Windows.Forms.Label birthdatelabel;
        private System.Windows.Forms.Label addresslabel;
        private System.Windows.Forms.Label idlabel;
        private System.Windows.Forms.Label authorizelabel;
        private System.Windows.Forms.Label validdatelabel;
        private System.Windows.Forms.Label photolabel;
        private System.Windows.Forms.TextBox nametextBox;
        private System.Windows.Forms.TextBox sextextBox;
        private System.Windows.Forms.TextBox ethnictextBox;
        private System.Windows.Forms.TextBox birthdaytextBox;
        private System.Windows.Forms.TextBox addresstextBox;
        private System.Windows.Forms.TextBox idnumtextBox;
        private System.Windows.Forms.TextBox authorizetextBox;
        private System.Windows.Forms.TextBox validdatetextBox;
        private System.Windows.Forms.PictureBox cardpictureBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox errorNumtextBox;
        private System.Windows.Forms.TextBox errorinfotextBox;
        private System.Windows.Forms.Button readinfobutton;
        private System.Windows.Forms.Label errorNumlabel;
        private System.Windows.Forms.Label errorInfolabel;
        private System.Windows.Forms.Button sendImgBtn;
        private System.Windows.Forms.Button button2;
    }
}

