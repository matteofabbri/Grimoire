using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Compensation
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Add_Stock_GrantInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Add_Stock_Grant_RequestType Add_Stock_Grant_Request;

		public Add_Stock_GrantInput()
		{
		}

		public Add_Stock_GrantInput(Workday_Common_HeaderType Workday_Common_Header, Add_Stock_Grant_RequestType Add_Stock_Grant_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Add_Stock_Grant_Request = Add_Stock_Grant_Request;
		}
	}
}
