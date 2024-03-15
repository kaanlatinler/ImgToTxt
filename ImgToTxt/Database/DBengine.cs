using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImgToTxt.Database
{
	public class DBengine
	{
		private readonly string connStr = "Your Database";

		public List<string> GetAllImages()
		{
			List<string> imagePaths = new List<string>();

			try
			{
				string query = "SELECT ImagePath FROM Images";

				using (SqlConnection conn = new SqlConnection(connStr))
				{
					conn.Open();

					using (SqlCommand cmd = new SqlCommand(query, conn))
					{
						using (SqlDataReader dr = cmd.ExecuteReader())
						{
							while (dr.Read())
							{
								string imagePath = dr["ImagePath"].ToString();
								imagePaths.Add(imagePath);
							}
						}
					}
				}
			}
			catch (Exception e)
			{
				MessageBox.Show("Resim Getirilirken Bir Hata Oldu.\n" + "HATA: " + e.ToString());
				Console.WriteLine(e.ToString());
			}

			return imagePaths;
		}

		public bool SaveImage(string imgName)
		{
			string resourcesPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources");
			try
			{
				string query = $"INSERT INTO Images (ImagePath) VALUES ('{resourcesPath}\\{imgName}')";

				using (SqlConnection conn = new SqlConnection(connStr))
				{
					conn.Open();

					using (SqlCommand cmd = new SqlCommand(query, conn))
					{
						int rowsAffected = cmd.ExecuteNonQuery();
						if (rowsAffected > 0)
						{
							return true;
						}
					}
				}
			}
			catch (Exception e)
			{
				MessageBox.Show("Resim Kaydedilirken Bir Hata Oluştu.\n" + "HATA: " + e.ToString());
			}

			return false;
		}

		public bool DeleteImage(string imgPath)
		{
			try
			{
				string query = $"DELETE FROM Images WHERE ImagePath = '{imgPath}' ";

				using (SqlConnection conn = new SqlConnection(connStr))
				{
					conn.Open();

					using (SqlCommand cmd = new SqlCommand(query, conn))
					{
						int rowsAffected = cmd.ExecuteNonQuery();
						if (rowsAffected > 0)
						{
							return true;
						}
					}
				}
			}
			catch (Exception e)
			{
				MessageBox.Show("Resim Kaydedilirken Bir Hata Oluştu.\n" + "HATA: " + e.ToString());
			}

			return false;
		}

		//public bool OpenConnection()
		//{
		//	SqlConnection conn = new SqlConnection(connStr);

		//	try
		//	{
		//		conn.Open();
		//		return true;
		//	}
		//	catch (Exception e)
		//	{
		//		MessageBox.Show("Veritabanına bağlanırken bir hata oluştu.\nHATA: " + e.ToString());
		//		return false;
		//	}
		//}
	}
}
