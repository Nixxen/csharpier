using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpier
{
    public partial class Printer
    {
        private Doc PrintBreakStatementSyntax(BreakStatementSyntax node)
        {
            return Concat(
                this.PrintSyntaxToken(node.BreakKeyword),
                this.PrintSyntaxToken(node.SemicolonToken)
            );
        }
    }
}
