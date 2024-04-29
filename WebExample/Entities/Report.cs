namespace WebExample.Entities;

public class Report
{
    public string Header { get; set; } = string.Empty;
    public string Body { get; set; } = string.Empty;
    public string Footer { get; set; } = string.Empty;
    public List<string> AdditionalSections { get; set; } = new();
}