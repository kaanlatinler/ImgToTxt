namespace ImgToTxt.Forms
{
	partial class MainForm
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
			this.exitBtn = new System.Windows.Forms.Button();
			this.selectImgBtn = new System.Windows.Forms.Button();
			this.imgContainer = new System.Windows.Forms.PictureBox();
			this.convertBtn = new System.Windows.Forms.Button();
			this.deleteBtn = new System.Windows.Forms.Button();
			this.langsCB = new System.Windows.Forms.ComboBox();
			this.translateBtn = new System.Windows.Forms.Button();
			this.translatedTextHeader = new System.Windows.Forms.Label();
			this.originalTextHeader = new System.Windows.Forms.Label();
			this.originalTxtPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.originalTxt = new System.Windows.Forms.Label();
			this.translatedTxtPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.translatedTxt = new System.Windows.Forms.Label();
			this.historyPanel = new System.Windows.Forms.FlowLayoutPanel();
			((System.ComponentModel.ISupportInitialize)(this.imgContainer)).BeginInit();
			this.originalTxtPanel.SuspendLayout();
			this.translatedTxtPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// exitBtn
			// 
			this.exitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.exitBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
			this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.exitBtn.Location = new System.Drawing.Point(1334, 12);
			this.exitBtn.Name = "exitBtn";
			this.exitBtn.Size = new System.Drawing.Size(40, 25);
			this.exitBtn.TabIndex = 0;
			this.exitBtn.Text = "X";
			this.exitBtn.UseVisualStyleBackColor = true;
			this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
			// 
			// selectImgBtn
			// 
			this.selectImgBtn.Location = new System.Drawing.Point(648, 65);
			this.selectImgBtn.Name = "selectImgBtn";
			this.selectImgBtn.Size = new System.Drawing.Size(141, 49);
			this.selectImgBtn.TabIndex = 3;
			this.selectImgBtn.Text = "Resim Seçmek İçin Tıklayınız";
			this.selectImgBtn.UseVisualStyleBackColor = true;
			this.selectImgBtn.Click += new System.EventHandler(this.selectImgBtn_Click);
			// 
			// imgContainer
			// 
			this.imgContainer.BackColor = System.Drawing.Color.White;
			this.imgContainer.Location = new System.Drawing.Point(70, 76);
			this.imgContainer.Name = "imgContainer";
			this.imgContainer.Size = new System.Drawing.Size(543, 306);
			this.imgContainer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.imgContainer.TabIndex = 4;
			this.imgContainer.TabStop = false;
			// 
			// convertBtn
			// 
			this.convertBtn.Location = new System.Drawing.Point(648, 115);
			this.convertBtn.Name = "convertBtn";
			this.convertBtn.Size = new System.Drawing.Size(141, 49);
			this.convertBtn.TabIndex = 6;
			this.convertBtn.Text = "Metine Dönüştürmek İçin Tıklayınız";
			this.convertBtn.UseVisualStyleBackColor = true;
			this.convertBtn.Click += new System.EventHandler(this.convertBtn_Click);
			// 
			// deleteBtn
			// 
			this.deleteBtn.Location = new System.Drawing.Point(648, 165);
			this.deleteBtn.Name = "deleteBtn";
			this.deleteBtn.Size = new System.Drawing.Size(141, 49);
			this.deleteBtn.TabIndex = 7;
			this.deleteBtn.Text = "Sil";
			this.deleteBtn.UseVisualStyleBackColor = true;
			this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
			// 
			// langsCB
			// 
			this.langsCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.langsCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.langsCB.FormattingEnabled = true;
			this.langsCB.Location = new System.Drawing.Point(648, 307);
			this.langsCB.Name = "langsCB";
			this.langsCB.Size = new System.Drawing.Size(141, 24);
			this.langsCB.TabIndex = 8;
			// 
			// translateBtn
			// 
			this.translateBtn.Location = new System.Drawing.Point(648, 346);
			this.translateBtn.Name = "translateBtn";
			this.translateBtn.Size = new System.Drawing.Size(141, 49);
			this.translateBtn.TabIndex = 9;
			this.translateBtn.Text = "Çeviri İçin Tıklayınız";
			this.translateBtn.UseVisualStyleBackColor = true;
			this.translateBtn.Click += new System.EventHandler(this.translateBtn_Click);
			// 
			// translatedTextHeader
			// 
			this.translatedTextHeader.AutoSize = true;
			this.translatedTextHeader.BackColor = System.Drawing.Color.Transparent;
			this.translatedTextHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.translatedTextHeader.Location = new System.Drawing.Point(1172, 85);
			this.translatedTextHeader.Name = "translatedTextHeader";
			this.translatedTextHeader.Size = new System.Drawing.Size(133, 20);
			this.translatedTextHeader.TabIndex = 0;
			this.translatedTextHeader.Text = "Çevirilmiş Metin";
			this.translatedTextHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// originalTextHeader
			// 
			this.originalTextHeader.AutoSize = true;
			this.originalTextHeader.BackColor = System.Drawing.Color.Transparent;
			this.originalTextHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.originalTextHeader.Location = new System.Drawing.Point(896, 85);
			this.originalTextHeader.Name = "originalTextHeader";
			this.originalTextHeader.Size = new System.Drawing.Size(109, 20);
			this.originalTextHeader.TabIndex = 10;
			this.originalTextHeader.Text = "Orjinal Metin";
			this.originalTextHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// originalTxtPanel
			// 
			this.originalTxtPanel.AutoScroll = true;
			this.originalTxtPanel.BackColor = System.Drawing.Color.White;
			this.originalTxtPanel.Controls.Add(this.originalTxt);
			this.originalTxtPanel.Cursor = System.Windows.Forms.Cursors.Hand;
			this.originalTxtPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.originalTxtPanel.Location = new System.Drawing.Point(820, 115);
			this.originalTxtPanel.Name = "originalTxtPanel";
			this.originalTxtPanel.Size = new System.Drawing.Size(270, 267);
			this.originalTxtPanel.TabIndex = 11;
			this.originalTxtPanel.DoubleClick += new System.EventHandler(this.originalTxtPanel_DoubleClick);
			// 
			// originalTxt
			// 
			this.originalTxt.AutoSize = true;
			this.originalTxt.Cursor = System.Windows.Forms.Cursors.Hand;
			this.originalTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.originalTxt.Location = new System.Drawing.Point(3, 0);
			this.originalTxt.Name = "originalTxt";
			this.originalTxt.Size = new System.Drawing.Size(0, 18);
			this.originalTxt.TabIndex = 13;
			this.originalTxt.DoubleClick += new System.EventHandler(this.originalTxtPanel_DoubleClick);
			// 
			// translatedTxtPanel
			// 
			this.translatedTxtPanel.AutoScroll = true;
			this.translatedTxtPanel.BackColor = System.Drawing.Color.White;
			this.translatedTxtPanel.Controls.Add(this.translatedTxt);
			this.translatedTxtPanel.Cursor = System.Windows.Forms.Cursors.Hand;
			this.translatedTxtPanel.Location = new System.Drawing.Point(1093, 115);
			this.translatedTxtPanel.Name = "translatedTxtPanel";
			this.translatedTxtPanel.Size = new System.Drawing.Size(270, 267);
			this.translatedTxtPanel.TabIndex = 12;
			this.translatedTxtPanel.DoubleClick += new System.EventHandler(this.translatedTxtPanel_DoubleClick);
			// 
			// translatedTxt
			// 
			this.translatedTxt.AutoSize = true;
			this.translatedTxt.Cursor = System.Windows.Forms.Cursors.Hand;
			this.translatedTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.translatedTxt.Location = new System.Drawing.Point(3, 0);
			this.translatedTxt.Name = "translatedTxt";
			this.translatedTxt.Size = new System.Drawing.Size(0, 18);
			this.translatedTxt.TabIndex = 14;
			this.translatedTxt.DoubleClick += new System.EventHandler(this.translatedTxtPanel_DoubleClick);
			// 
			// historyPanel
			// 
			this.historyPanel.Location = new System.Drawing.Point(70, 592);
			this.historyPanel.Name = "historyPanel";
			this.historyPanel.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.historyPanel.Size = new System.Drawing.Size(1293, 140);
			this.historyPanel.TabIndex = 13;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.BackgroundImage = global::ImgToTxt.Properties.Resources.main;
			this.ClientSize = new System.Drawing.Size(1440, 810);
			this.Controls.Add(this.historyPanel);
			this.Controls.Add(this.translatedTextHeader);
			this.Controls.Add(this.originalTextHeader);
			this.Controls.Add(this.translateBtn);
			this.Controls.Add(this.langsCB);
			this.Controls.Add(this.deleteBtn);
			this.Controls.Add(this.convertBtn);
			this.Controls.Add(this.imgContainer);
			this.Controls.Add(this.selectImgBtn);
			this.Controls.Add(this.exitBtn);
			this.Controls.Add(this.originalTxtPanel);
			this.Controls.Add(this.translatedTxtPanel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MainForm";
			this.Load += new System.EventHandler(this.MainForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.imgContainer)).EndInit();
			this.originalTxtPanel.ResumeLayout(false);
			this.originalTxtPanel.PerformLayout();
			this.translatedTxtPanel.ResumeLayout(false);
			this.translatedTxtPanel.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button exitBtn;
		private System.Windows.Forms.Button selectImgBtn;
		private System.Windows.Forms.PictureBox imgContainer;
		private System.Windows.Forms.Button convertBtn;
		private System.Windows.Forms.Button deleteBtn;
		private System.Windows.Forms.ComboBox langsCB;
		private System.Windows.Forms.Button translateBtn;
		private System.Windows.Forms.Label translatedTextHeader;
		private System.Windows.Forms.Label originalTextHeader;
		private System.Windows.Forms.FlowLayoutPanel originalTxtPanel;
		private System.Windows.Forms.FlowLayoutPanel translatedTxtPanel;
		private System.Windows.Forms.Label originalTxt;
		private System.Windows.Forms.Label translatedTxt;
		private System.Windows.Forms.FlowLayoutPanel historyPanel;
	}
}