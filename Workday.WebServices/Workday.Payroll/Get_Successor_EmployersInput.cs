using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Payroll
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Successor_EmployersInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Successor_Employers_RequestType Get_Successor_Employers_Request;

		public Get_Successor_EmployersInput()
		{
		}

		public Get_Successor_EmployersInput(Workday_Common_HeaderType Workday_Common_Header, Get_Successor_Employers_RequestType Get_Successor_Employers_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Successor_Employers_Request = Get_Successor_Employers_Request;
		}
	}
}
