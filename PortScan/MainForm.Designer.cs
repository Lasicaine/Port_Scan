/*
 * Created by SharpDevelop.
 * User: aau
 * Date: 14.10.2011
 * Time: 16:17
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace PortScan
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.button1 = new System.Windows.Forms.Button();
			this.listView1 = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.tIPAddress = new System.Windows.Forms.TextBox();
			this.nBeginPort = new System.Windows.Forms.NumericUpDown();
			this.nEndPort = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.nBeginPort)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nEndPort)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(197, 10);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(120, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "Сканировать";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// listView1
			// 
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.columnHeader1,
									this.columnHeader2});
			this.listView1.FullRowSelect = true;
			this.listView1.GridLines = true;
			this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.listView1.Location = new System.Drawing.Point(12, 64);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(305, 284);
			this.listView1.TabIndex = 1;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Порт";
			this.columnHeader1.Width = 151;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Статус";
			this.columnHeader2.Width = 145;
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(12, 354);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(305, 23);
			this.progressBar1.TabIndex = 2;
			// 
			// tIPAddress
			// 
			this.tIPAddress.Location = new System.Drawing.Point(12, 12);
			this.tIPAddress.Name = "tIPAddress";
			this.tIPAddress.Size = new System.Drawing.Size(120, 20);
			this.tIPAddress.TabIndex = 3;
			this.tIPAddress.Text = "192.168.1.2";
			// 
			// nBeginPort
			// 
			this.nBeginPort.Location = new System.Drawing.Point(12, 38);
			this.nBeginPort.Name = "nBeginPort";
			this.nBeginPort.Size = new System.Drawing.Size(120, 20);
			this.nBeginPort.TabIndex = 4;
			// 
			// nEndPort
			// 
			this.nEndPort.Location = new System.Drawing.Point(197, 39);
			this.nEndPort.Maximum = new decimal(new int[] {
									1000000,
									0,
									0,
									0});
			this.nEndPort.Name = "nEndPort";
			this.nEndPort.Size = new System.Drawing.Size(120, 20);
			this.nEndPort.TabIndex = 5;
			this.nEndPort.Value = new decimal(new int[] {
									100,
									0,
									0,
									0});
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(329, 389);
			this.Controls.Add(this.nEndPort);
			this.Controls.Add(this.nBeginPort);
			this.Controls.Add(this.tIPAddress);
			this.Controls.Add(this.progressBar1);
			this.Controls.Add(this.listView1);
			this.Controls.Add(this.button1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Сканер портов";
			((System.ComponentModel.ISupportInitialize)(this.nBeginPort)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nEndPort)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.NumericUpDown nEndPort;
		private System.Windows.Forms.NumericUpDown nBeginPort;
		private System.Windows.Forms.TextBox tIPAddress;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.Button button1;
	}
}
