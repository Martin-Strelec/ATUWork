using System;
class program
{
	static void Main()
	{
		int[] nums = new int[] {3,-6,1,9,-3,6,7,9,-12,45};
		int s = nums[0];
		int l = nums[0];

		for (int i = 0; i < nums.Length; i++)
		{
			if (s > nums[i])
			{
				s = nums[i];
			}
			else if (l < nums[i])
			{
				l = nums[i];
			}
		} 
		Console.WriteLine("Biggest number is: " + l);
		Console.WriteLine("Lowest number is: " + s);		
	}
}