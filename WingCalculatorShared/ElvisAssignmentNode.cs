﻿namespace WingCalculatorShared;

internal record ElvisAssignmentNode(IAssignable A, INode B) : INode
{
	public double Solve()
	{
		double a = ((INode)A).Solve();
		if (a == 0) A.Assign(B);

		if (A is MacroNode) return 1;
		else return a;
	}
}