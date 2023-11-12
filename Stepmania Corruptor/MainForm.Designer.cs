/*
 * Created by SharpDevelop.
 * User: Donna
 * Date: 8/17/2016
 * Time: 4:40 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Stepmania_Corruptor
{
	partial class window
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ProgressBar percent;
		
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
			this.label1 = new System.Windows.Forms.Label();
			this.percent = new System.Windows.Forms.ProgressBar();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(12, 12);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(221, 86);
			this.button1.TabIndex = 0;
			this.button1.Text = "Play";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 104);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(85, 26);
			this.label1.TabIndex = 1;
			this.label1.Text = "Loading:";
			// 
			// percent
			// 
			this.percent.Location = new System.Drawing.Point(86, 104);
			this.percent.Name = "percent";
			this.percent.Size = new System.Drawing.Size(148, 26);
			this.percent.TabIndex = 2;
			// 
			// window
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(246, 104);
			this.Controls.Add(this.percent);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.Name = "window";
			this.Text = "Stepmania Corruptor";
			this.ResumeLayout(false);

		}
	}
}
