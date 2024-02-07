using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Payroll
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Payroll_Payee_Ongoing_Work_Jurisdiction_Tax_ElectionOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Payroll_Payee_Ongoing_Work_Jurisdiction_Tax_Election_ResponseType Get_Payroll_Payee_Ongoing_Work_Jurisdiction_Tax_Election_Response;

		public Get_Payroll_Payee_Ongoing_Work_Jurisdiction_Tax_ElectionOutput()
		{
		}

		public Get_Payroll_Payee_Ongoing_Work_Jurisdiction_Tax_ElectionOutput(Get_Payroll_Payee_Ongoing_Work_Jurisdiction_Tax_Election_ResponseType Get_Payroll_Payee_Ongoing_Work_Jurisdiction_Tax_Election_Response)
		{
			this.Get_Payroll_Payee_Ongoing_Work_Jurisdiction_Tax_Election_Response = Get_Payroll_Payee_Ongoing_Work_Jurisdiction_Tax_Election_Response;
		}
	}
}
