﻿namespace Festa_Retro_Pedidos
{
	partial class SampleView
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SampleView));
			this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
			this.guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
			this.label1 = new System.Windows.Forms.Label();
			this.btnAdd = new Guna.UI2.WinForms.Guna2ImageButton();
			this.label2 = new System.Windows.Forms.Label();
			this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
			this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
			this.guna2MessageDialog1 = new Guna.UI2.WinForms.Guna2MessageDialog();
			this.SuspendLayout();
			// 
			// txtSearch
			// 
			this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtSearch.DefaultText = "";
			this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtSearch.Location = new System.Drawing.Point(668, 98);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.PasswordChar = '\0';
			this.txtSearch.PlaceholderText = "Pesquise Aqui";
			this.txtSearch.SelectedText = "";
			this.txtSearch.Size = new System.Drawing.Size(230, 36);
			this.txtSearch.TabIndex = 0;
			this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
			// 
			// guna2ContextMenuStrip1
			// 
			this.guna2ContextMenuStrip1.Name = "guna2ContextMenuStrip1";
			this.guna2ContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
			this.guna2ContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
			this.guna2ContextMenuStrip1.RenderStyle.ColorTable = null;
			this.guna2ContextMenuStrip1.RenderStyle.RoundedEdges = true;
			this.guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
			this.guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
			this.guna2ContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
			this.guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
			this.guna2ContextMenuStrip1.Size = new System.Drawing.Size(61, 4);
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(675, 64);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 17);
			this.label1.TabIndex = 2;
			this.label1.Text = "Pesquisar";
			// 
			// btnAdd
			// 
			this.btnAdd.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
			this.btnAdd.HoverState.ImageSize = new System.Drawing.Size(64, 64);
			this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
			this.btnAdd.ImageOffset = new System.Drawing.Point(0, 0);
			this.btnAdd.ImageRotate = 0F;
			this.btnAdd.Location = new System.Drawing.Point(12, 68);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.PressedState.ImageSize = new System.Drawing.Size(64, 64);
			this.btnAdd.Size = new System.Drawing.Size(80, 66);
			this.btnAdd.TabIndex = 3;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 40);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(109, 25);
			this.label2.TabIndex = 4;
			this.label2.Text = "Header Box";
			// 
			// guna2BorderlessForm1
			// 
			this.guna2BorderlessForm1.ContainerControl = this;
			this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
			this.guna2BorderlessForm1.TransparentWhileDrag = true;
			// 
			// guna2Separator1
			// 
			this.guna2Separator1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.guna2Separator1.Location = new System.Drawing.Point(12, 136);
			this.guna2Separator1.Name = "guna2Separator1";
			this.guna2Separator1.Size = new System.Drawing.Size(910, 14);
			this.guna2Separator1.TabIndex = 5;
			// 
			// guna2MessageDialog1
			// 
			this.guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
			this.guna2MessageDialog1.Caption = "Festa_Retro_Pedidos";
			this.guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Question;
			this.guna2MessageDialog1.Parent = null;
			this.guna2MessageDialog1.Style = Guna.UI2.WinForms.MessageDialogStyle.Light;
			this.guna2MessageDialog1.Text = null;
			// 
			// SampleView
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(933, 588);
			this.Controls.Add(this.guna2Separator1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtSearch);
			this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.HelpButton = true;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "SampleView";
			this.Text = "SampleView";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
		private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
		private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
		public Guna.UI2.WinForms.Guna2TextBox txtSearch;
		public System.Windows.Forms.Label label1;
		public Guna.UI2.WinForms.Guna2ImageButton btnAdd;
		public System.Windows.Forms.Label label2;
		public Guna.UI2.WinForms.Guna2MessageDialog guna2MessageDialog1;
	}
}