using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Payroll
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Import_Payroll_InputInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Import_Payroll_Input_RequestType Import_Payroll_Input_Request;

		public Import_Payroll_InputInput()
		{
		}

		public Import_Payroll_InputInput(Workday_Common_HeaderType Workday_Common_Header, Import_Payroll_Input_RequestType Import_Payroll_Input_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Import_Payroll_Input_Request = Import_Payroll_Input_Request;
		}
	}
}
