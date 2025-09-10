namespace FactoryMethodPattern.Products;

public class PdfReport : IReport
{
    public string Generate() => "PDF Report Generated";
}