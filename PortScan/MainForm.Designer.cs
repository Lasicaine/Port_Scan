
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
            this.buttonRun = new System.Windows.Forms.Button();
            this.listViewPortStatus = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.progressBarCheck = new System.Windows.Forms.ProgressBar();
            this.tIPAddress = new System.Windows.Forms.TextBox();
            this.nBeginPort = new System.Windows.Forms.NumericUpDown();
            this.nEndPort = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nBeginPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nEndPort)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonRun
            // 
            this.buttonRun.Location = new System.Drawing.Point(197, 10);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(120, 23);
            this.buttonRun.TabIndex = 0;
            this.buttonRun.Text = "Run";
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.Button1Click);
            // 
            // listViewPortStatus
            // 
            this.listViewPortStatus.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listViewPortStatus.FullRowSelect = true;
            this.listViewPortStatus.GridLines = true;
            this.listViewPortStatus.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewPortStatus.Location = new System.Drawing.Point(12, 64);
            this.listViewPortStatus.Name = "listViewPortStatus";
            this.listViewPortStatus.Size = new System.Drawing.Size(305, 284);
            this.listViewPortStatus.TabIndex = 1;
            this.listViewPortStatus.UseCompatibleStateImageBehavior = false;
            this.listViewPortStatus.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Port";
            this.columnHeader1.Width = 151;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Status";
            this.columnHeader2.Width = 145;
            // 
            // progressBarCheck
            // 
            this.progressBarCheck.Location = new System.Drawing.Point(12, 354);
            this.progressBarCheck.Name = "progressBarCheck";
            this.progressBarCheck.Size = new System.Drawing.Size(305, 23);
            this.progressBarCheck.TabIndex = 2;
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
            this.nBeginPort.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nBeginPort.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nBeginPort.Name = "nBeginPort";
            this.nBeginPort.Size = new System.Drawing.Size(120, 20);
            this.nBeginPort.TabIndex = 4;
            this.nBeginPort.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nEndPort
            // 
            this.nEndPort.Location = new System.Drawing.Point(197, 39);
            this.nEndPort.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nEndPort.Minimum = new decimal(new int[] {
            1,
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
            this.Controls.Add(this.progressBarCheck);
            this.Controls.Add(this.listViewPortStatus);
            this.Controls.Add(this.buttonRun);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Port Scanner";
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
		private System.Windows.Forms.ProgressBar progressBarCheck;
		private System.Windows.Forms.ListView listViewPortStatus;
		private System.Windows.Forms.Button buttonRun;
	}
}
