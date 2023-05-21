using Linq;

class LinqDemo
{
    static void Main()
    {
        SimpleLinqExample.SimpleLinqExampleMain();
        DemonstrateWhereClause.DemonstrateWhereClauseMain();
        DemonstrateOrderBy.DemonstrateOrderByMain();
        DemonstrateSelect.DemonstrateSelectMain();
        DemonstrateNestedFrom.DemonstrateNestedFromMain();
        DemonstrateGroupClause.DemonstrateGroupClauseMain();
        DemonstrateIntoWithGroup.DemonstrateIntoWithGroupMain();
        DemostrateLetClause.DemostrateLetClauseMain();
        DemostrateJoin.DemostrateJoinMain();
        DemonstrateAnonymousType.DemonstrateAnonymousTypeMain();
        DemostrateGroupJoin.DemostrateGroupJoinMain();
        QueryMethods.QueryMethodsMain();
        ImmediateExecution.ImmediateExecutionMain();
        ExpressionTree.ExpressionTreeMain();
    }
}