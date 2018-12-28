/*
 * Created by SharpDevelop.
 * User: C1-D02
 * Date: 12/25/2018
 * Time: 8:29 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace bai18
{
	/// <summary>
	/// Description of Clsdiem.
	/// </summary>
	public class Clsdiem
	{
		public int a,b;				
		public Clsdiem()
		{
		
		}
		public Clsdiem(int x , int y)
		{
			a = x;
			b = y;
		}
		public int ix
		{
			get 
			{
				return a;
			}
			set
			{
				a = value;
			}
		}
		public int iy
		{
			get
			{
				return b;
			}
			set
			{
				b = value;
			}
		}
		public static double khoangcach(Clsdiem A , Clsdiem B)
		{
			double kc = 0;
			kc = Math.Sqrt(Math.Pow(A.a - B.a,2)+Math.Pow(A.b- B.b,2));
			return kc;
		}
	}
}
