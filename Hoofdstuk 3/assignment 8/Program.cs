using System.Diagnostics.SymbolStore;

namespace assignment_8
{
    internal class Program
    {
        static void Main(string[] args)


        {
            int aantalProcessoren = Environment.ProcessorCount;
            long geheugenInBytes = Environment.WorkingSet;
            string machineNaam = Environment.MachineName;
            string gebruikersNaam = Environment.UserName;
            bool is64Bit = Environment.Is64BitOperatingSystem;

            double geheugenInMB = geheugenInBytes / (1024.0 * 1024);
            double geheugenInGB = geheugenInBytes / (1024.0 * 1024 * 1024);

            string lijn = "---------------------------------------------";
            Console.WriteLine($"Systeeminformatie voor {gebruikersNaam} op {machineNaam}:{Environment.NewLine}{lijn}");
            Console.WriteLine($"\tAantal processors: {aantalProcessoren}");
            Console.WriteLine($"\t64-bit besturingssysteem: {is64Bit}");
            Console.WriteLine($"\tHuidig geheugengebruik: {geheugenInMB:F2} MB ({geheugenInGB:F2} GB)");
            Console.WriteLine(lijn);
        }
    }
}
