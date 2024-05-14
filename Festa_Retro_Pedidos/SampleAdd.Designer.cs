namespace Festa_Retro_Pedidos
{
	partial class SampleAdd
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SampleAdd));
			this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
			this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
			this.label1 = new System.Windows.Forms.Label();
			this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
			this.btnClose = new Guna.UI2.WinForms.Guna2Button();
			this.btnSave = new Guna.UI2.WinForms.Guna2Button();
			this.guna2MessageDialog1 = new Guna.UI2.WinForms.Guna2MessageDialog();
			this.guna2Panel1.SuspendLayout();
			this.guna2Panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// guna2Panel1
			// 
			this.guna2Panel1.Controls.Add(this.guna2ImageButton1);
			this.guna2Panel1.Controls.Add(this.label1);
			this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
			this.guna2Panel1.Name = "guna2Panel1";
			this.guna2Panel1.Size = new System.Drawing.Size(800, 100);
			this.guna2Panel1.TabIndex = 0;
			// 
			// guna2ImageButton1
			// 
			this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
			this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(64, 64);
			this.guna2ImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton1.Image")));
			this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
			this.guna2ImageButton1.ImageRotate = 0F;
			this.guna2ImageButton1.Location = new System.Drawing.Point(27, 12);
			this.guna2ImageButton1.Name = "guna2ImageButton1";
			this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(64, 64);
			this.guna2ImageButton1.Size = new System.Drawing.Size(75, 68);
			this.guna2ImageButton1.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Transparent;
			this.label1.Location = new System.Drawing.Point(108, 39);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(104, 35);
			this.label1.TabIndex = 2;
			this.label1.Text = "Header";
			// 
			// guna2Panel2
			// 
			this.guna2Panel2.Controls.Add(this.btnClose);
			this.guna2Panel2.Controls.Add(this.btnSave);
			this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.guna2Panel2.FillColor = System.Drawing.Color.Gray;
			this.guna2Panel2.Location = new System.Drawing.Point(0, 454);
			this.guna2Panel2.Name = "guna2Panel2";
			this.guna2Panel2.Size = new System.Drawing.Size(800, 62);
			this.guna2Panel2.TabIndex = 1;
			// 
			// btnClose
			// 
			this.btnClose.AutoRoundedCorners = true;
			this.btnClose.BackColor = System.Drawing.Color.Gray;
			this.btnClose.BorderRadius = 21;
			this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.btnClose.ForeColor = System.Drawing.Color.White;
			this.btnClose.Location = new System.Drawing.Point(230, 5);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(180, 45);
			this.btnClose.TabIndex = 3;
			this.btnClose.Text = "FECHAR";
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// btnSave
			// 
			this.btnSave.AutoRoundedCorners = true;
			this.btnSave.BackColor = System.Drawing.Color.Gray;
			this.btnSave.BorderRadius = 21;
			this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.btnSave.ForeColor = System.Drawing.Color.White;
			this.btnSave.Location = new System.Drawing.Point(12, 5);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(180, 45);
			this.btnSave.TabIndex = 2;
			this.btnSave.Text = "SALVAR";
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// guna2MessageDialog1
			// 
			this.guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
			this.guna2MessageDialog1.Caption = "Festa_Retro_Pedidos";
			this.guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Question;
			this.guna2MessageDialog1.Parent = this;
			this.guna2MessageDialog1.Style = Guna.UI2.WinForms.MessageDialogStyle.Light;
			this.guna2MessageDialog1.Text = null;
			// 
			// SampleAdd
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(800, 516);
			this.Controls.Add(this.guna2Panel2);
			this.Controls.Add(this.guna2Panel1);
			this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "SampleAdd";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SampleAdd";
			this.guna2Panel1.ResumeLayout(false);
			this.guna2Panel2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		public Guna.UI2.WinForms.Guna2Button btnSave;
		public Guna.UI2.WinForms.Guna2Button btnClose;
		public System.Windows.Forms.Label label1;
		public Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
		public Guna.UI2.WinForms.Guna2Panel guna2Panel1;
		public Guna.UI2.WinForms.Guna2MessageDialog guna2MessageDialog1;
		public Guna.UI2.WinForms.Guna2Panel guna2Panel2;
	}
}