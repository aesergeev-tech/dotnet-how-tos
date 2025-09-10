using FactoryMethodPattern;

Console.WriteLine("--- Factory Method Pattern Example ---");

var factory = new ReportFactory();

var pdfReport = factory.CreateReport("PDF");
Console.WriteLine(pdfReport.Generate());

var excelReport = factory.CreateReport("Excel");
Console.WriteLine(excelReport.Generate());

// To add a new report type, we would create a new report class implementing IReport
// and update the factory. The calling code (Program.cs) does not need to change.
Console.WriteLine();