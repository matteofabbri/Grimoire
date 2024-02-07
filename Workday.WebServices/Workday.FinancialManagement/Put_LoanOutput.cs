using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_LoanOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Loan_ResponseType Put_Loan_Response;

		public Put_LoanOutput()
		{
		}

		public Put_LoanOutput(Put_Loan_ResponseType Put_Loan_Response)
		{
			this.Put_Loan_Response = Put_Loan_Response;
		}
	}
}
