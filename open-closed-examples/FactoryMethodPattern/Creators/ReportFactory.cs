using FactoryMethodPattern.Products;

namespace FactoryMethodPattern.Creators;

public class ReportFactory
{
    private readonly Dictionary<string, Func<IReport>> _reports;

    public ReportFactory()
    {
        _reports = new Dictionary<string, Func<IReport>>(StringComparer.OrdinalIgnoreCase)
        {
            { "PDF", () => new PdfReport() },
            { "Excel", () => new ExcelReport() }
        };
    }

    public IReport CreateReport(string reportType)
    {
        if (_reports.TryGetValue(reportType, out var reportFunc))
        {
            return reportFunc();
        }
        throw new ArgumentException("Invalid report type", nameof(reportType));
    }
}