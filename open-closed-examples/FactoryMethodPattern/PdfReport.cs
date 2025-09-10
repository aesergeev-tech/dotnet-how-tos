namespace FactoryMethodPattern;

public class PdfReport : IReport
{
    public string Generate() => "PDF Report Generated";
}