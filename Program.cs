//driver code
using System;
using System.IO;

namespace Factorial{
	public class Program{
		public static void Main(string[] args){
			Solution s = new Solution();

			s.solve(Convert.ToInt32(args[0]));
		}
	}
}
