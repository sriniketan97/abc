using System; 

class IsValidDate 
{ 

	const int MAX_VALID_YR = 9999; 
	const int MIN_VALID_YR = 1800; 
 
	static bool isLeap(int year) { 

		return (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0)); 
	} 

	static bool isValidDate(int d, int m, int y) { 
 
		if (y > MAX_VALID_YR || y < MIN_VALID_YR) 
			return false; 
		if (m < 1 || m > 12) 
			return false; 
		if (d < 1 || d > 31) 
			return false; 
 
		if (m == 2) { 
			if (isLeap(y)) 
				return (d <= 29); 
			else
				return (d <= 28); 
		} 

		if (m == 4 || m == 6 || m == 9 || m == 11) 
			return (d <= 30); 

		return true; 
	} 

	public static void Main() { 
		
		if (isValidDate(1, 13, 2018)) 
			Console.WriteLine("Valid"); 
		else
			Console.WriteLine("InValid"); 
	} 
} 