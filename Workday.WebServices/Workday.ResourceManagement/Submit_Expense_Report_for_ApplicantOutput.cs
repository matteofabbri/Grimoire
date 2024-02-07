using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Submit_Expense_Report_for_ApplicantOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Submit_Expense_Report_for_Applicant_ResponseType Submit_Expense_Report_for_Applicant_Response;

		public Submit_Expense_Report_for_ApplicantOutput()
		{
		}

		public Submit_Expense_Report_for_ApplicantOutput(Submit_Expense_Report_for_Applicant_ResponseType Submit_Expense_Report_for_Applicant_Response)
		{
			this.Submit_Expense_Report_for_Applicant_Response = Submit_Expense_Report_for_Applicant_Response;
		}
	}
}
