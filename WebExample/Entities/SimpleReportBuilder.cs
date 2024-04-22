using WebExample.Entities.Interfaces;

namespace WebExample.Entities;

public class SimpleReportBuilder : IReportBuilder
{
    private readonly Report _report = new();

    public IReportBuilder BuildHeader(string header)
    {
        _report.Header = header;
        return this;
    }

    public IReportBuilder BuildBody(string body)
    {
        _report.Body = body;
        return this;
    }

    public IReportBuilder BuildFooter(string footer)
    {
        _report.Footer = footer;
        return this;
    }

    public IReportBuilder BuildAdditionalSection(string section)
    {
        _report.AdditionalSections.Add(section);
        return this;
    }

    public Report Build()
    {
        return _report;
    }
}