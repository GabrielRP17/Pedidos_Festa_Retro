using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Festa_Retro_Pedidos
{
	class MainClass
	{
		public static readonly string con_string = "Data Source=GABRIEL-PASSOS\\SQLEXPRESS;Initial Catalog=Festa_Retro;Integrated Security=True;Encrypt=False";
		public static SqlConnection con = new SqlConnection(con_string);

		public static bool IsValidUser(string user, string pass)
		{
			bool isValid = false;

			string qry = @"Select * from users where username  ='" + user + "' and upass = '" + pass + "'   ";
			SqlCommand cmd = new SqlCommand(qry, con);

			DataTable dt = new DataTable();
			SqlDataAdapter DA = new SqlDataAdapter(cmd);
			DA.Fill(dt);

			if (dt.Rows.Count > 0)
			{
				isValid = true;
				USER = dt.Rows[0]["uName"].ToString();
			}

			return isValid;

		}

		public static string user;

		public static string USER
		{
			get { return user; }
			private set { user = value; }
		}

		public static int SQL(string qry, Hashtable ht)
		{
			int res = 0;

			try
			{
				SqlCommand cmd = new SqlCommand(qry, con);
				cmd.CommandType = CommandType.Text;

				foreach(DictionaryEntry item  in ht)
				{
					cmd.Parameters.AddWithValue(item.Key.ToString(), item.Value);
				}
				if(con.State == ConnectionState.Closed) { con.Open(); }
				res = cmd.ExecuteNonQuery();
				if(con.State == ConnectionState.Open) { con.Close(); }
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
				con.Close();
			}

			return res;
		}

		public static void LoadData(string qry, DataGridView gv,ListBox lb)
		{
			//gv.CellFormatting += new DataGridViewCellFormattingEventHandler(gv_CellFormatting);

			try
			{
				SqlCommand cmd = new SqlCommand(qry, con);
				cmd.CommandType = CommandType.Text;
				SqlDataAdapter da = new SqlDataAdapter(cmd);
				DataTable dt = new DataTable();
				da.Fill(dt);


				for (int i = 0; i < lb.Items.Count; i++)
				{
					string col = ((DataGridViewColumn)lb.Items[i]).Name;
					gv.Columns[col].DataPropertyName = dt.Columns[i].ToString();
				}

				gv.DataSource = dt;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
				con.Close();
			}

			
		}
		//private static void gv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		//{
		//	Guna.UI2.WinForms.Guna2DataGridView gv = (Guna.UI2.WinForms.Guna2DataGridView)sender;
		//	int count = 0;

		//	foreach (DataGridView row in gv.Rows)
		//	{
		//		count++;
		//		//row.Cells[0].Value = count;
				
		//	}
		//}
	}
}
