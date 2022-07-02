using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MappingResources
{
	public partial class XYcoor : UserControl
	{
		public XYcoor()
		{
			InitializeComponent();
			this.Xcoor.Maximum = ABC_lib_01.MaxRandomW;
			this.Ycoor.Maximum = ABC_lib_01.MaxRandomH;
		}
	}
}
