using System;

public class Test
{                  
	public static void Main() 
	{
		#if(NAPON && STRUJA)
			Console.WriteLine("Otpor se mo�e izra�unati");
		#elif(NAPON && !STRUJA)
			Console.WriteLine("Otpor se ne mo�e izra�unati");
		#elif(!NAPON && STRUJA)
			Console.WriteLine("Otpor se ne mo�e izra�unati");
		#elif(!NAPON && !STRUJA)
			Console.WriteLine("Otpor se ne mo�e izra�unati");
		#endif
	}
}
