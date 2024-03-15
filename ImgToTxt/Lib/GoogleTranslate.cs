using Google.Cloud.Translation.V2;
using System;

namespace ImgToTxt.Lib
{
	public class GoogleTranslate
	{
	 	public static string Translate(string text, string lang)
		{
			string apiKey = "Your Api Key";

			TranslationClient client = TranslationClient.CreateFromApiKey(apiKey);

			string textToTranslate = text;

			TranslationResult result = client.TranslateText(
				text: textToTranslate,
				targetLanguage: lang
			);

			return result.TranslatedText;
		}
	}
}


