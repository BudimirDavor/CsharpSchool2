using System;

class Test
{
	private short XCoord;
	private static short YCoord;

	private void FCoord()
	{
		XCoord = 300;
		YCoord = 400;
	}
	
	static void Main() 
	{		
		Test Tmp = new Test();
		Tmp.XCoord = 100;		// OK
		Tmp.YCoord = 200;		// Gre�ka, ne�e se prevesti
		
		Test.XCoord = 100;		// Gre�ka, ne�e se prevesti 
		Test.YCoord = 100;		// OK

		FCoord();			// Gre�ka, ne�e se prevesti 
	}
}
