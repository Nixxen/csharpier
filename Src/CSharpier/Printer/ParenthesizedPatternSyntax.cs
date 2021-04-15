using CSharpier.DocTypes;
using CSharpier.SyntaxPrinter;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpier
{
    public partial class Printer
    {
        private Doc PrintParenthesizedPatternSyntax(
            ParenthesizedPatternSyntax node
        ) {
            return Docs.Concat(
                SyntaxTokens.Print(node.OpenParenToken),
                this.Print(node.Pattern),
                SyntaxTokens.Print(node.CloseParenToken)
            );
        }
    }
}
