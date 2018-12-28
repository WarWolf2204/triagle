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
		// khai báo sử dụng lại đối tượng
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
		{	//cv đầu tiên không có dấu + vì nó là cách gán cơ số đầu tiên
			//mỗi khoảng cách giữa 2 điểm ta cần 2 giá trị của đối tượng
			double cv =0;
			cv = Clsdiem.khoangcach(A,B);
			cv+= Clsdiem.khoangcach(B,C);
			cv+= Clsdiem.khoangcach(C,A);
			return cv;		
		}
		public static double dientich(Clsdiem A , Clsdiem B , Clsdiem C)
		{
			// dưới đây ta cần đặt giá trị mỗi cạnh = 0 trước để nhét biến vào
			// công thức diện tích
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
			// đây là sử dụng mảng (Array) để vẽ 
			// 1 tam giác có 3 cạnh nên 
			// phải sư dụng 4 điểm
			// nếu dùng 3 điểm hình sẽ bị mất 1 cạnh
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
