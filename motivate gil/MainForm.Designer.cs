/*
 * Created by SharpDevelop.
 * User: Lab-01
 * Date: 29/7/2024
 * Time: 20:42
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace motivate_gil
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label LBL_Main;
		private System.Windows.Forms.Button BTN_motivate;
		private System.Windows.Forms.Label LBL_frase;
		
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
			this.LBL_Main = new System.Windows.Forms.Label();
			this.BTN_motivate = new System.Windows.Forms.Button();
			this.LBL_frase = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// LBL_Main
			// 
			this.LBL_Main.AutoSize = true;
			this.LBL_Main.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LBL_Main.Location = new System.Drawing.Point(51, 23);
			this.LBL_Main.Name = "LBL_Main";
			this.LBL_Main.Size = new System.Drawing.Size(173, 37);
			this.LBL_Main.TabIndex = 0;
			this.LBL_Main.Text = "Motivate☺";
			// 
			// BTN_motivate
			// 
			this.BTN_motivate.AutoSize = true;
			this.BTN_motivate.Location = new System.Drawing.Point(85, 186);
			this.BTN_motivate.Name = "BTN_motivate";
			this.BTN_motivate.Size = new System.Drawing.Size(97, 23);
			this.BTN_motivate.TabIndex = 1;
			this.BTN_motivate.Text = "Motivacion gratis";
			this.BTN_motivate.UseVisualStyleBackColor = true;
			this.BTN_motivate.Click += new System.EventHandler(this.BTN_motivateClick);
			// 
			// LBL_frase
			// 
			this.LBL_frase.AutoSize = true;
			this.LBL_frase.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LBL_frase.Location = new System.Drawing.Point(50, 100);
			this.LBL_frase.Name = "LBL_frase";
			this.LBL_frase.Size = new System.Drawing.Size(16, 24);
			this.LBL_frase.TabIndex = 2;
			this.LBL_frase.Text = "-";
			this.LBL_frase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.LBL_frase);
			this.Controls.Add(this.BTN_motivate);
			this.Controls.Add(this.LBL_Main);
			this.Name = "MainForm";
			this.Text = "motivate gil";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
