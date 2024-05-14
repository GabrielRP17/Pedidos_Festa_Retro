using Festa_Retro_Pedidos.Model;
using Guna.UI2.WinForms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Festa_Retro_Pedidos.View
{
	public partial class frmCategoryView : SampleView
	{
		public frmCategoryView()
		{
			InitializeComponent();
		}

		public void GetData()
		{
			string qry = "Select * From category Where catName like '%"+ txtSearch.Text +"%' ";
			ListBox lb = new ListBox();
			lb.Items.Add(dgvid);
			lb.Items.Add(dgvName);

			MainClass.LoadData(qry, guna2DataGridView1, lb);
		}

		private void frmCategoryView_Load_1(object sender, EventArgs e)
		{
			GetData();
		}

		public override void btnAdd_Click(object sender, EventArgs e)
		{
			frmCategoryAdd frm = new frmCategoryAdd();
			frm.ShowDialog();
			GetData();
		}

		public override void txtSearch_TextChanged(object sender, EventArgs e)
		{
			GetData();
		}

		private void guna2DataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (guna2DataGridView1.CurrentCell.OwningColumn.Name == "dgvedit")
			{
				guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Question;
				guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.YesNo;
				frmCategoryAdd frm = new frmCategoryAdd();
				frm.id = Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells["dgvid"].Value);
				frm.txtName.Text = Convert.ToString(guna2DataGridView1.CurrentRow.Cells["dgvName"].Value);
				frm.ShowDialog();
				GetData();

			}
			if (guna2DataGridView1.CurrentCell.OwningColumn.Name == "dgvdel")
			{
				guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Question;
				guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.YesNo;
				if (guna2MessageDialog1.Show("Você tem certeza que deseja Deletar?") == DialogResult.Yes)
				{
					int id = Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells["dgvid"].Value);
					string qry = "Delete from category where catID = " + id + "";
					Hashtable ht = new Hashtable();
					MainClass.SQL(qry, ht);

					guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
					guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
					MessageBox.Show("Deletado com Sucesso");
					GetData();
				}

	
			}
		}
	}
}
