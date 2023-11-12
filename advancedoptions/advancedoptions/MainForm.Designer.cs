/*
 * Created by SharpDevelop.
 * User: KEVIN
 * Date: 9/17/2016
 * Time: 2:39 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace advancedoptions
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.go = new System.Windows.Forms.Button();
			this.thingstocorrupt = new System.Windows.Forms.CheckedListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.crptvaluestart = new System.Windows.Forms.NumericUpDown();
			this.crptvalueend = new System.Windows.Forms.NumericUpDown();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.crptvaluestart)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.crptvalueend)).BeginInit();
			this.SuspendLayout();
			// 
			// go
			// 
			this.go.Font = new System.Drawing.Font("Arial Narrow", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.go.Location = new System.Drawing.Point(349, 204);
			this.go.Name = "go";
			this.go.Size = new System.Drawing.Size(80, 48);
			this.go.TabIndex = 0;
			this.go.Text = "Run";
			this.go.UseVisualStyleBackColor = true;
			// 
			// thingstocorrupt
			// 
			this.thingstocorrupt.FormattingEnabled = true;
			this.thingstocorrupt.Items.AddRange(new object[] {
									"\\themes\\<theme name>\\Metrics.ini",
									"\\data\\Stepmania.ini",
									"\\data\\ai.ini"});
			this.thingstocorrupt.Location = new System.Drawing.Point(12, 30);
			this.thingstocorrupt.Name = "thingstocorrupt";
			this.thingstocorrupt.Size = new System.Drawing.Size(191, 49);
			this.thingstocorrupt.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(113, 23);
			this.label1.TabIndex = 2;
			this.label1.Text = "Select files to corrupt:";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 93);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(118, 16);
			this.label2.TabIndex = 3;
			this.label2.Text = "Corruption value range:";
			// 
			// crptvaluestart
			// 
			this.crptvaluestart.AllowDrop = true;
			this.crptvaluestart.Location = new System.Drawing.Point(12, 112);
			this.crptvaluestart.Maximum = new decimal(new int[] {
									2048,
									0,
									0,
									0});
			this.crptvaluestart.Minimum = new decimal(new int[] {
									2048,
									0,
									0,
									-2147483648});
			this.crptvaluestart.Name = "crptvaluestart";
			this.crptvaluestart.Size = new System.Drawing.Size(59, 20);
			this.crptvaluestart.TabIndex = 4;
			this.crptvaluestart.Value = new decimal(new int[] {
									320,
									0,
									0,
									0});
			// 
			// crptvalueend
			// 
			this.crptvalueend.AllowDrop = true;
			this.crptvalueend.Location = new System.Drawing.Point(77, 112);
			this.crptvalueend.Maximum = new decimal(new int[] {
									2049,
									0,
									0,
									0});
			this.crptvalueend.Minimum = new decimal(new int[] {
									2047,
									0,
									0,
									-2147483648});
			this.crptvalueend.Name = "crptvalueend";
			this.crptvalueend.Size = new System.Drawing.Size(59, 20);
			this.crptvalueend.TabIndex = 4;
			this.crptvalueend.Value = new decimal(new int[] {
									240,
									0,
									0,
									0});
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(269, 203);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(74, 49);
			this.button1.TabIndex = 5;
			this.button1.Text = "Uncorrupt (restore)";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(12, 139);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(59, 23);
			this.button2.TabIndex = 6;
			this.button2.Text = "Random";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(77, 138);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(59, 23);
			this.button3.TabIndex = 6;
			this.button3.Text = "Random";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(441, 264);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.crptvalueend);
			this.Controls.Add(this.crptvaluestart);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.thingstocorrupt);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.go);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.ShowIcon = false;
			this.Text = "Stepmania Corruptor: Advanced Options";
			((System.ComponentModel.ISupportInitialize)(this.crptvaluestart)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.crptvalueend)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.NumericUpDown crptvalueend;
		private System.Windows.Forms.NumericUpDown crptvaluestart;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.CheckedListBox thingstocorrupt;
		private System.Windows.Forms.Button go;
	}
}
