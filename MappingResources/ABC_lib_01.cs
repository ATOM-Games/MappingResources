using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MappingResources
{
	internal class ABC_lib_01
	{
		static string fileFormat = "хуйня", seed_random = "хуйня";
		static ushort seed_size = 5;
		static public int real_seed = 0;
		static public string[] bsss = { "Сгенерить сид", "Установить сид" };



		static public Random r = new Random();
		static public Random random;

		public static void generateSeed() { real_seed = r.Next(); }




	}
}
