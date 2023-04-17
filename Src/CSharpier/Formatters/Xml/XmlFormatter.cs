namespace CSharpier.Formatters.Xml;

using System.Text.Json;
using System.Xml;
using CSharpier.Formatters.Xml.XmlNodePrinters;

internal static class XmlFormatter
{
    internal static CodeFormatterResult Format(string xml, PrinterOptions printerOptions)
    {
        // TODO xml width?
        // var stringBuilder = new StringWriter();
        //
        // var settings = new XmlWriterSettings
        // {
        //     Indent = true,
        //     IndentChars = printerOptions.UseTabs ? "\t" : new string(' ', printerOptions.TabWidth),
        //     NewLineChars = PrinterOptions.GetLineEnding(code, printerOptions),
        //     OmitXmlDeclaration = !code.Trim().StartsWith("<?xml")
        // };
        //
        // var xmlTextWriter = XmlWriter.Create(stringBuilder, settings);
        var xmlDocument = new XmlDocument();
        xmlDocument.LoadXml(xml);
        // xmlDocument.Save(xmlTextWriter);


        var lineEnding = PrinterOptions.GetLineEnding(xml, printerOptions);
        var doc = Node.Print(xmlDocument);
        var formattedXml = DocPrinter.DocPrinter.Print(doc, printerOptions, lineEnding);

        return new CodeFormatterResult
        {
            Code = formattedXml,
            DocTree = printerOptions.IncludeDocTree ? DocSerializer.Serialize(doc) : string.Empty,
            AST = printerOptions.IncludeAST ? JsonSerializer.Serialize(xmlDocument) : string.Empty
        };
    }
}