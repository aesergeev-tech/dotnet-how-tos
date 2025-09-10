namespace FactoryMethodPattern;

public class ExcelReport : IReport
{
    public string Generate() => "Excel Report Generated";
}