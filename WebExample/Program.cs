using WebExample.Entities;

namespace WebExample
{
    public static class Program
    {
        public static void Main()
        {
            var director = SingletonSimpleReportDirector.Instance;
            director.SetBuilder(new SimpleReportBuilder());

            director.ConstructReport();
            var report = director.GetReport();
            
            Console.WriteLine(report.Header);
            Console.WriteLine(report.Body);
            Console.WriteLine(report.Footer);
            Console.WriteLine("Additional Sections:");
            foreach (var section in report.AdditionalSections)
            {
                Console.WriteLine(section);
            }
        }
    }
}