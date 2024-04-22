namespace Lab7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HospitalSingleton system = HospitalSingleton.GetInstance();

            system.AddMedicalData("Patient John Doe has a fever.");
            system.AddMedicalData("Patient Jane Smith has a broken leg.");

            Console.WriteLine(system.GetMedicalData(0)); 
            Console.WriteLine(system.GetMedicalData(1));
        }
    }
}
