namespace Factorial{
	public class Solution{
		public void solve(int num){
			Console.Write(fact(num));
			// Console.WriteLine("\n"+ fact(Convert.ToInt64(num)));
		}

		//brute force
		// public long fact(long num){
		// 	long prod = 1;
		// 	for(int i = 1; i <= num; i++ ){
		// 		prod = prod*i;
		// 	}
		// 	return prod;
		// }

		public string fact(int num){
			string ans = "1";
			
			for(int i = 2; i <= num; i++){
				List<long> temp = ans.ToArray().Select(a => Int64.Parse(a.ToString())).ToList();
				temp = Prod(i, temp);
				temp.Reverse();
				ans = string.Join('.', temp).Replace(".", "");
			}
			return ans;
		}

		public List<long> Prod(int a, List<long> ans){
			long carry = 0;
			List<long> arr = new List<long>();
			int N = ans.Count();
			for(int i = N-1; i >= 0; i--){
				long prod = 1L*a*ans[i] + carry;
				int digit = (int)prod%10;
				carry = (int)prod/10;
				arr.Add(digit);
			}
			if(carry > 0){
				arr.Add(carry);
			}
			return arr;
		}
	}
}
