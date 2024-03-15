using System;
using System.Drawing;
using Tesseract;

namespace ImgToTxt.Lib
{
	public class TesseractController
	{
		public static string Tess(Pix img)
		{
			using (var engine = new TesseractEngine(@"./tessdata", "eng", EngineMode.Default))
			{
				using (var page = engine.Process(img))
				{
					var text = page.GetText();
					return text;
				}
			}
		}
	}
}