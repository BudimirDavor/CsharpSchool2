using System;

public class Test 
{
	public static void Main() 
	{
		uint Plasman = 1;
		string Doseg;

		if(Plasman == 1)
			Doseg = "Svjetski prvak";
		else if(Plasman <= 2)
			Doseg = "Finale";
		else if(Plasman <= 4)
			Doseg = "Polufinale";
		else if(Plasman <= 8)
			Doseg = "Četvrtfinale";
		else if(Plasman <= 16)
			Doseg = "Osmina finala";
		else if(Plasman <= 32)
			Doseg = "Ispadanje u skupini";
		else
			Doseg = "Nisu se kvalificirali za Svjetsko prvenstvo";

		Console.WriteLine(Doseg);
	}
}
