using WebExample.Entities.Interfaces;

namespace WebExample.Entities;

public class ReportDirector
{
    private IReportBuilder _builder;

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