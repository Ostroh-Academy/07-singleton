namespace WebExample.Entities.Interfaces;

public interface IReportBuilder
{
    IReportBuilder BuildHeader(string header);
    IReportBuilder BuildBody(string body);
    IReportBuilder BuildFooter(string footer);
    IReportBuilder BuildAdditionalSection(string section);
    Report Build();
}