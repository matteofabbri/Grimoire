using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Payroll
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Payroll_Payee_Ongoing_Work_Jurisdiction_Tax_ElectionOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Payroll_Payee_Ongoing_Work_Jurisdiction_Tax_Election_ResponseType Put_Payroll_Payee_Ongoing_Work_Jurisdiction_Tax_Election_Response;

		public Put_Payroll_Payee_Ongoing_Work_Jurisdiction_Tax_ElectionOutput()
		{
		}

		public Put_Payroll_Payee_Ongoing_Work_Jurisdiction_Tax_ElectionOutput(Put_Payroll_Payee_Ongoing_Work_Jurisdiction_Tax_Election_ResponseType Put_Payroll_Payee_Ongoing_Work_Jurisdiction_Tax_Election_Response)
		{
			this.Put_Payroll_Payee_Ongoing_Work_Jurisdiction_Tax_Election_Response = Put_Payroll_Payee_Ongoing_Work_Jurisdiction_Tax_Election_Response;
		}
	}
}
