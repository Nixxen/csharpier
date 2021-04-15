using CSharpier.SyntaxPrinter;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpier
{
    public partial class Printer
    {
        private Doc PrintFinallyClauseSyntax(FinallyClauseSyntax node)
        {
            return Docs.Concat(
                SyntaxTokens.Print(node.FinallyKeyword),
                this.Print(node.Block)
            );
        }
    }
}
