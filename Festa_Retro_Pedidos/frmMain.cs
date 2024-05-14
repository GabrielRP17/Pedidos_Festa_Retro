using Festa_Retro_Pedidos.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Festa_Retro_Pedidos
{
	public partial class frmMain : Form
	{
		public frmMain()
		{
			InitializeComponent();
		}

		public void AddControls(Form f )
		{
			ControlsPanel.Controls.Clear();
			f.Dock = DockStyle.Fill;
			f.TopLevel = false;
			ControlsPanel.Controls.Add( f );
			f.Show();
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void frmMain_Load_1(object sender, EventArgs e)
		{
			lblUser.Text = MainClass.USER;
		}

		private void btnHome_Click(object sender, EventArgs e)
		{
			AddControls(new frmHome());
		}

		private void btnCategory_Click(object sender, EventArgs e)
		{
			AddControls(new frmCategoryView());
		}
	}
}
