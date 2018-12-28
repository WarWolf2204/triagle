/*
 * Created by SharpDevelop.
 * User: C1-D02
 * Date: 12/25/2018
 * Time: 8:26 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace bai18
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.hdA = new System.Windows.Forms.TextBox();
			this.tbdientich = new System.Windows.Forms.TextBox();
			this.tbchuvi = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.nhap = new System.Windows.Forms.Button();
			this.thoat = new System.Windows.Forms.Button();
			this.tdA = new System.Windows.Forms.TextBox();
			this.tdB = new System.Windows.Forms.TextBox();
			this.hdB = new System.Windows.Forms.TextBox();
			this.tdC = new System.Windows.Forms.TextBox();
			this.hdC = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.show = new System.Windows.Forms.Panel();
			this.label9 = new System.Windows.Forms.Label();
			this.kcAB = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.kcAC = new System.Windows.Forms.TextBox();
			this.kcBC = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Yellow;
			this.label1.Location = new System.Drawing.Point(12, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "edge A";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Yellow;
			this.label2.Location = new System.Drawing.Point(12, 128);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "edge C";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Yellow;
			this.label3.Location = new System.Drawing.Point(12, 83);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "edge B";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// hdA
			// 
			this.hdA.Location = new System.Drawing.Point(118, 40);
			this.hdA.Multiline = true;
			this.hdA.Name = "hdA";
			this.hdA.Size = new System.Drawing.Size(44, 23);
			this.hdA.TabIndex = 3;
			// 
			// tbdientich
			// 
			this.tbdientich.Location = new System.Drawing.Point(356, 83);
			this.tbdientich.Multiline = true;
			this.tbdientich.Name = "tbdientich";
			this.tbdientich.Size = new System.Drawing.Size(100, 23);
			this.tbdientich.TabIndex = 4;
			// 
			// tbchuvi
			// 
			this.tbchuvi.Location = new System.Drawing.Point(356, 42);
			this.tbchuvi.Multiline = true;
			this.tbchuvi.Name = "tbchuvi";
			this.tbchuvi.Size = new System.Drawing.Size(100, 23);
			this.tbchuvi.TabIndex = 8;
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Yellow;
			this.label4.Location = new System.Drawing.Point(235, 83);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 9;
			this.label4.Text = "area";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Yellow;
			this.label5.Location = new System.Drawing.Point(235, 42);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 10;
			this.label5.Text = "peremeter";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// nhap
			// 
			this.nhap.Location = new System.Drawing.Point(235, 128);
			this.nhap.Name = "nhap";
			this.nhap.Size = new System.Drawing.Size(100, 23);
			this.nhap.TabIndex = 11;
			this.nhap.Text = "ADD";
			this.nhap.UseVisualStyleBackColor = true;
			this.nhap.Click += new System.EventHandler(this.NhapClick);
			// 
			// thoat
			// 
			this.thoat.Location = new System.Drawing.Point(356, 128);
			this.thoat.Name = "thoat";
			this.thoat.Size = new System.Drawing.Size(100, 23);
			this.thoat.TabIndex = 12;
			this.thoat.Text = "X";
			this.thoat.UseVisualStyleBackColor = true;
			this.thoat.Click += new System.EventHandler(this.ThoatClick);
			// 
			// tdA
			// 
			this.tdA.Location = new System.Drawing.Point(179, 42);
			this.tdA.Multiline = true;
			this.tdA.Name = "tdA";
			this.tdA.Size = new System.Drawing.Size(44, 23);
			this.tdA.TabIndex = 13;
			// 
			// tdB
			// 
			this.tdB.Location = new System.Drawing.Point(179, 85);
			this.tdB.Multiline = true;
			this.tdB.Name = "tdB";
			this.tdB.Size = new System.Drawing.Size(44, 23);
			this.tdB.TabIndex = 15;
			// 
			// hdB
			// 
			this.hdB.Location = new System.Drawing.Point(118, 85);
			this.hdB.Multiline = true;
			this.hdB.Name = "hdB";
			this.hdB.Size = new System.Drawing.Size(44, 23);
			this.hdB.TabIndex = 14;
			// 
			// tdC
			// 
			this.tdC.Location = new System.Drawing.Point(179, 130);
			this.tdC.Multiline = true;
			this.tdC.Name = "tdC";
			this.tdC.Size = new System.Drawing.Size(44, 23);
			this.tdC.TabIndex = 17;
			// 
			// hdC
			// 
			this.hdC.Location = new System.Drawing.Point(118, 130);
			this.hdC.Multiline = true;
			this.hdC.Name = "hdC";
			this.hdC.Size = new System.Drawing.Size(44, 23);
			this.hdC.TabIndex = 16;
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.Black;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label6.ForeColor = System.Drawing.Color.Black;
			this.label6.Location = new System.Drawing.Point(168, 53);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(5, 5);
			this.label6.TabIndex = 18;
			this.label6.Text = ".";
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.Black;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label7.ForeColor = System.Drawing.Color.Black;
			this.label7.Location = new System.Drawing.Point(168, 146);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(5, 5);
			this.label7.TabIndex = 19;
			this.label7.Text = ".";
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.Color.Black;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label8.ForeColor = System.Drawing.Color.Black;
			this.label8.Location = new System.Drawing.Point(168, 101);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(5, 5);
			this.label8.TabIndex = 20;
			this.label8.Text = ".";
			// 
			// show
			// 
			this.show.BackColor = System.Drawing.Color.Yellow;
			this.show.Location = new System.Drawing.Point(12, 159);
			this.show.Name = "show";
			this.show.Size = new System.Drawing.Size(675, 209);
			this.show.TabIndex = 21;
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.Color.Yellow;
			this.label9.Location = new System.Drawing.Point(481, 42);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(100, 23);
			this.label9.TabIndex = 23;
			this.label9.Text = "space AB";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// kcAB
			// 
			this.kcAB.Location = new System.Drawing.Point(587, 42);
			this.kcAB.Multiline = true;
			this.kcAB.Name = "kcAB";
			this.kcAB.Size = new System.Drawing.Size(100, 23);
			this.kcAB.TabIndex = 24;
			// 
			// label10
			// 
			this.label10.BackColor = System.Drawing.Color.Yellow;
			this.label10.Location = new System.Drawing.Point(481, 128);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(100, 23);
			this.label10.TabIndex = 25;
			this.label10.Text = "space AC";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label11
			// 
			this.label11.BackColor = System.Drawing.Color.Yellow;
			this.label11.Location = new System.Drawing.Point(481, 85);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(100, 23);
			this.label11.TabIndex = 26;
			this.label11.Text = "space BC";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// kcAC
			// 
			this.kcAC.Location = new System.Drawing.Point(587, 128);
			this.kcAC.Multiline = true;
			this.kcAC.Name = "kcAC";
			this.kcAC.Size = new System.Drawing.Size(100, 23);
			this.kcAC.TabIndex = 27;
			// 
			// kcBC
			// 
			this.kcBC.Location = new System.Drawing.Point(587, 83);
			this.kcBC.Multiline = true;
			this.kcBC.Name = "kcBC";
			this.kcBC.Size = new System.Drawing.Size(100, 25);
			this.kcBC.TabIndex = 28;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Lime;
			this.ClientSize = new System.Drawing.Size(699, 371);
			this.Controls.Add(this.kcBC);
			this.Controls.Add(this.kcAC);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.kcAB);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.show);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.tdC);
			this.Controls.Add(this.hdC);
			this.Controls.Add(this.tdB);
			this.Controls.Add(this.hdB);
			this.Controls.Add(this.tdA);
			this.Controls.Add(this.thoat);
			this.Controls.Add(this.nhap);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.tbchuvi);
			this.Controls.Add(this.tbdientich);
			this.Controls.Add(this.hdA);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "bai18";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox kcBC;
		private System.Windows.Forms.TextBox kcAC;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox kcAB;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Panel show;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox hdC;
		private System.Windows.Forms.TextBox tdC;
		private System.Windows.Forms.TextBox hdB;
		private System.Windows.Forms.TextBox tdB;
		private System.Windows.Forms.TextBox tdA;
		private System.Windows.Forms.Button thoat;
		private System.Windows.Forms.Button nhap;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox tbchuvi;
		private System.Windows.Forms.TextBox tbdientich;
		private System.Windows.Forms.TextBox hdA;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
