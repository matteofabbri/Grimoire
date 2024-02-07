using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Payroll
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Submit_Payroll_InputInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Submit_Payroll_Input_RequestType Submit_Payroll_Input_Request;

		public Submit_Payroll_InputInput()
		{
		}

		public Submit_Payroll_InputInput(Workday_Common_HeaderType Workday_Common_Header, Submit_Payroll_Input_RequestType Submit_Payroll_Input_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Submit_Payroll_Input_Request = Submit_Payroll_Input_Request;
		}
	}
}
