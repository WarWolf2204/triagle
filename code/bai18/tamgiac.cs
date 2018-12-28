/*
 * Created by SharpDevelop.
 * User: C1-D02
 * Date: 12/25/2018
 * Time: 8:29 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
namespace bai18
{
	/// <summary>
	/// Description of tamgiac.
	/// </summary>
	public class tamgiac 
	{
		Clsdiem A = new Clsdiem();
		Clsdiem B = new Clsdiem();
		Clsdiem C = new Clsdiem();
		
		public tamgiac()
		{
			
		}
		public tamgiac (Clsdiem a,Clsdiem b,Clsdiem c)
		{
			A = a;
			B = b;
			C = c;
		}
		public static double chuvi(Clsdiem A , Clsdiem B , Clsdiem C)
		{
			double cv =0;
			cv = Clsdiem.khoangcach(A,B);
			cv+= Clsdiem.khoangcach(B,C);
			cv+= Clsdiem.khoangcach(C,A);
			return cv;		
		}
		public static double dientich(Clsdiem A , Clsdiem B , Clsdiem C)
		{
			double AB=0,BC=0,CA=0,dt=0;
			double p;
			AB = Clsdiem.khoangcach(A,B);
			BC = Clsdiem.khoangcach(B,C);
			CA = Clsdiem.khoangcach(C,A);
			p =(AB+BC+CA)/2;
			dt = Math.Sqrt(p*(p-AB)*(p-BC)*(p-CA));
			return dt;
		}
		public void Draw(Graphics g, Pen p)
		{
			g.Clear(Color.White);
			Point [] a = new Point[4];
			a[0] = new Point(A.ix,A.iy);
			a[1] = new Point(B.ix,B.iy);
			a[2] = new Point(C.ix,C.iy);
			a[3] = new Point(A.ix,A.iy);
			g.DrawLines(p,a);
		
		}
	}
}
