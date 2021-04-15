using System.Linq;
using CSharpier.SyntaxPrinter;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpier
{
    public partial class Printer
    {
        private Doc PrintRelationalPatternSyntax(RelationalPatternSyntax node)
        {
            return Docs.Concat(
                SyntaxTokens.Print(node.OperatorToken),
                " ",
                this.Print(node.Expression)
            );
        }
    }
}
