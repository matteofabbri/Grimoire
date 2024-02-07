using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Payroll.Interface
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_PayeesInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Payees_RequestType Get_Payees_Request;

		public Get_PayeesInput()
		{
		}

		public Get_PayeesInput(Workday_Common_HeaderType Workday_Common_Header, Get_Payees_RequestType Get_Payees_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Payees_Request = Get_Payees_Request;
		}
	}
}
