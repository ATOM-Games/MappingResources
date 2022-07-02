using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MappingResources
{
	internal class ABC_lib_01
	{
		static public string fileFormat_map = "map files (*.map)|*.map",
			fileFormat_img = "bmp files (*.bmp)|*.bmp| jpg files (*.jpg)|*.jpg| jpeg files(*.jpeg)| *.jpeg| png files(*.png)| *.png";
		static public int real_seed = 0;
		static public string[] bsss = { "Сгенерить сид", "Установить сид" };
		public static int MaxRandomW, MaxRandomH;


		static public Random r = new Random();
		static public Random random;


		public static string MYMetka = " [ (c) A.B.C. ] ";


		public static string BitMapToString (Bitmap btm) {
			MemoryStream memoryStream = new MemoryStream();
			btm.Save(memoryStream, ImageFormat.Bmp);
			memoryStream.Position = 0;
			byte[] byteBuffer = memoryStream.ToArray();
			memoryStream.Close();
			string base64String = Convert.ToBase64String(byteBuffer);
			byteBuffer = null;
			return base64String;
		}

		public static Bitmap StringToMapBit(string str) {
			byte[] byteBuffer = Convert.FromBase64String(str);
			MemoryStream memoryStream = new MemoryStream(byteBuffer);
			memoryStream.Position = 0;
			Bitmap btm = (Bitmap)Bitmap.FromStream(memoryStream);
			memoryStream.Close();
			memoryStream = null;
			byteBuffer = null;
			return btm;
		}

		static public Color Summ_method_3(Color c1, Color c2)
		{
			float aa = c2.A * 1f / 255f;
			float na = 1 - aa;

			int r = (int)(c1.R * na + c2.R * aa);
			int g = (int)(c1.G * na + c2.G * aa);
			int b = (int)(c1.B * na + c2.B * aa);
			return Color.FromArgb(255, r, g, b);
		}




	}
}
