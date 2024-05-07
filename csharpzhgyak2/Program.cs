namespace csharpzhgyak2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Király k0 = new Király(2, 7, "fehér");
			k0.setY(3);
			Console.WriteLine(k0.ToString());
			Console.WriteLine(k0.VéletlenLép());
			List < Király > lista= new List<Király>();

			
			try
			{
				StreamReader sr = new StreamReader("C:\\Munka\\VS\\csharpzhgyak2\\csharpzhgyak2\\adat.txt");
				while (!sr.EndOfStream)
				{
					string line = sr.ReadLine();
					string[] parts = line.Split();
					string color = (parts[0]);
					int x = int.Parse(parts[1]);
					int y = int.Parse(parts[2]);
					
					Király kr=new Király(x, y, color);
					lista.Add(kr);
				}
				sr.Close();
				lista.Sort();
				foreach (var item in lista)
				{
					Console.WriteLine(item.ToString());
				}
			}
			catch(Exception ex)
			{
				Console.WriteLine(ex.ToString());
			}
			
		}
	}
}
