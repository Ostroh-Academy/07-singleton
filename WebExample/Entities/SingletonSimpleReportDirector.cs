using WebExample.Entities.Interfaces;

namespace WebExample.Entities;

public class SingletonSimpleReportDirector
{
    private static SingletonSimpleReportDirector? _instance;
    private IReportBuilder _builder = new SimpleReportBuilder();

    private SingletonSimpleReportDirector() { }

    public static SingletonSimpleReportDirector Instance
    {
        get { return _instance ??= new SingletonSimpleReportDirector(); }
    }

    public void SetBuilder(IReportBuilder builder)
    {
        _builder = builder;
    }

    public Report GetReport()
    {
        return _builder.Build();
    }

    public void ConstructReport()
    {
        _builder.BuildHeader("Header")
            .BuildBody("Body")
            .BuildFooter("Footer")
            .BuildAdditionalSection("Additional Section");
    }
}