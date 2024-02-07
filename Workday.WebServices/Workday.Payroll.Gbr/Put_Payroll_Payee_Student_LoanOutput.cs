using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Payroll.Gbr
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Payroll_Payee_Student_LoanOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Payroll_Payee_Student_Loan_ResponseType Put_Payroll_Payee_Student_Loan_Response;

		public Put_Payroll_Payee_Student_LoanOutput()
		{
		}

		public Put_Payroll_Payee_Student_LoanOutput(Put_Payroll_Payee_Student_Loan_ResponseType Put_Payroll_Payee_Student_Loan_Response)
		{
			this.Put_Payroll_Payee_Student_Loan_Response = Put_Payroll_Payee_Student_Loan_Response;
		}
	}
}
