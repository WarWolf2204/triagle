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
		// khai báo biến chứa 2 điểm bất kì 
		//không đặt dữ liệu = 0 vì nó sẽ xét giá trị mặc định = 0 tất cả
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
			// công thức tính khoẩng cách 2 điểm 
			// căn của bình phương hoành độ trước trừ hoành độ sau
			// cộng với bình phương tung độ trước trừ tung độ sau
			double kc = 0;
			kc = Math.Sqrt(Math.Pow(A.a - B.a,2)+Math.Pow(A.b- B.b,2));//pow(.../2) nghĩa là mũ 2
			return kc;
		}
	}
}
