/*
 * Created by SharpDevelop.
 * User: C1-D02
 * Date: 12/25/2018
 * Time: 8:26 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace bai18
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		Clsdiem A = new Clsdiem();
		Clsdiem B = new Clsdiem();
		Clsdiem C = new Clsdiem();
		tamgiac triangle = new tamgiac();
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void ThoatClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void NhapClick(object sender, EventArgs e)
		{
			A = new Clsdiem(int.Parse(hdA.Text),int.Parse(tdA.Text));
			B = new Clsdiem(int.Parse(hdB.Text),int.Parse(tdB.Text));
			C = new Clsdiem(int.Parse(hdC.Text),int.Parse(tdC.Text));
			kcAB.Text = Clsdiem.khoangcach(A,B).ToString();
			kcBC.Text = Clsdiem.khoangcach(B,C).ToString();
			kcAC.Text = Clsdiem.khoangcach(A,C).ToString();
			triangle = new tamgiac(A,B,C);
			tbdientich.Text = tamgiac.dientich(A,B,C).ToString();
			tbchuvi.Text = tamgiac.chuvi(A,B,C).ToString();
			triangle.Draw(show.CreateGraphics(),new Pen(Color.Black,3));
		}
	}
}
