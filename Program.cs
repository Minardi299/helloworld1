using System;

namespace helloworld1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("can nang:");
			var CanNang = Console.ReadLine();
			decimal CanNangDec = Convert.ToDecimal (CanNang);
			Console.WriteLine($"can nang ={CanNangDec:0.00} kg");


			Console.WriteLine("chieu cao:");
			var ChieuCao = Console.ReadLine();
			decimal ChieuCaoDec = Convert.ToDecimal(ChieuCao);
			Console.WriteLine($"chieu cao ={ChieuCaoDec:0.00} m");


			var BMI = CanNangDec / (ChieuCaoDec*ChieuCaoDec);
			Console.WriteLine($"BMI cua ban la ={BMI}");

			if (BMI <= (decimal)18.5)
			{
				Console.WriteLine("gay om");
			}
			else if (BMI <= (decimal)24.5)
			{
				Console.WriteLine("bt");
			}
			else if (BMI <= (decimal)29.9)
            {
				Console.WriteLine("thua can");

            }
			else 
			{
				Console.WriteLine("sieu thua can");

			}


		}
	}
}
