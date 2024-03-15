using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Tesseract;
using ImgToTxt.Lib;
using System.Collections.Generic;
using NAudio.Wave;
using ImgToTxt.Database;

namespace ImgToTxt.Forms
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();

			exitBtn.FlatAppearance.BorderSize = 0;
			exitBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(183, 201, 242);

			langsCB.Items.Add(new KeyValuePair<string, string>("Türkçe", "tr"));
			langsCB.Items.Add(new KeyValuePair<string, string>("İngilizce", "en"));
			langsCB.Items.Add(new KeyValuePair<string, string>("Almanca", "de"));
			langsCB.Items.Add(new KeyValuePair<string, string>("Fransızca", "fr"));
			langsCB.Items.Add(new KeyValuePair<string, string>("Japonca", "ja"));
			langsCB.Items.Add(new KeyValuePair<string, string>("Default", "tr"));
			langsCB.SelectedIndex = 5;

			langsCB.DisplayMember = "Key";
			langsCB.ValueMember = "Value";

			historyPanel.AutoScroll = true;
		}

		private void exitBtn_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			fillHistoryPanel();
		}

		private void selectImgBtn_Click(object sender, EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.Filter = "Resim Dosyaları|*.jpg;*.jpeg;*.png;*.gif;*.bmp|Tüm Dosyalar|*.*";
			ofd.Multiselect = false;

			DialogResult result = ofd.ShowDialog();

			if (result == DialogResult.OK)
			{
				string resourcesPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources");

				if (!Directory.Exists(resourcesPath))
				{
					Directory.CreateDirectory(resourcesPath);
				}

				string imgName = Path.GetFileName(ofd.FileName);
				string savePath = Path.Combine(resourcesPath, imgName);

				imgContainer.Image = new Bitmap(ofd.FileName);
				imgContainer.Image.Save(savePath);

				DBengine db = new DBengine();
				db.SaveImage(imgName);
				fillHistoryPanel();
			}
		}

		private void convertBtn_Click(object sender, EventArgs e)
		{
			if (imgContainer.Image == null)
			{
				MessageBox.Show("Lütfen önce bir resim seçin.", "Resim Seçilmedi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			using (var memoryStream = new MemoryStream())
			{
				imgContainer.Image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Png);
				memoryStream.Position = 0;

				using (var engine = new TesseractEngine(@"./tessdata", "eng", EngineMode.Default))
				{
					using (var img = Pix.LoadFromMemory(memoryStream.ToArray()))
					{
						string text = TesseractController.Tess(img);
						originalTxt.Text = text;
					}
				}
			}
		}

		private void deleteBtn_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(imgContainer.ImageLocation))
			{
				try
				{
					File.Delete(imgContainer.ImageLocation);
				}
				catch (Exception err)
				{
					MessageBox.Show("Resim dosyası silinirken bir hata oluştu: " + err.Message);
					return;
				}

				DBengine db = new DBengine();
				db.DeleteImage(imgContainer.ImageLocation);
				fillHistoryPanel();

				imgContainer.Image = null;
				originalTxt.Text = null;
				translatedTxt.Text = null;
				langsCB.SelectedIndex = 0;
			}
			else
			{
				MessageBox.Show("Silinecek bir resim bulunamadı.");
			}
		}


		private void translateBtn_Click(object sender, EventArgs e)
		{
			if (langsCB.SelectedItem != null)
			{
				KeyValuePair<string, string> selectedLanguage = (KeyValuePair<string, string>)langsCB.SelectedItem;
				string selectedLanguageValue = selectedLanguage.Value;

				string text = GoogleTranslate.Translate(originalTxt.Text, selectedLanguageValue);
				translatedTxt.Text = text;
			}
			else
			{
				MessageBox.Show("Lütfen bir dil seçin.", "Dil Seçilmedi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void fillHistoryPanel()
		{
			historyPanel.Controls.Clear();
			DBengine db = new DBengine();

			List<string> paths = db.GetAllImages();

			foreach (string path in paths)
			{
				PictureBox imgBox = new PictureBox();
				imgBox.Size = new Size(240, 135);
				imgBox.ImageLocation = path;
				imgBox.SizeMode = PictureBoxSizeMode.Zoom;
				imgBox.Click += İmgBox_Click;
				imgBox.Cursor = Cursors.Hand;
				historyPanel.Controls.Add(imgBox);
			}
		}

		private void İmgBox_Click(object sender, EventArgs e)
		{
			imgContainer.Controls.Clear();
			
			PictureBox pBox = sender as PictureBox;

			imgContainer.ImageLocation = pBox.ImageLocation;
		}

		private void originalTxtPanel_DoubleClick(object sender, EventArgs e)
		{
			Clipboard.SetText(originalTxt.Text);
			MessageBox.Show("Metin Kopyalandı");
		}

		private void translatedTxtPanel_DoubleClick(object sender, EventArgs e)
		{
			Clipboard.SetText(translatedTxt.Text);
			MessageBox.Show("Metin Kopyalandı");
		}
	}
}
