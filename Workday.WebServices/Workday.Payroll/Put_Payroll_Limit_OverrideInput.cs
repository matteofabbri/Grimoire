using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Payroll
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Payroll_Limit_OverrideInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Payroll_Limit_Override_RequestType Put_Payroll_Limit_Override_Request;

		public Put_Payroll_Limit_OverrideInput()
		{
		}

		public Put_Payroll_Limit_OverrideInput(Workday_Common_HeaderType Workday_Common_Header, Put_Payroll_Limit_Override_RequestType Put_Payroll_Limit_Override_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Payroll_Limit_Override_Request = Put_Payroll_Limit_Override_Request;
		}
	}
}
