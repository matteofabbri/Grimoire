using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Compensation
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Update_Stock_GrantInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Update_Stock_Grant_RequestType Update_Stock_Grant_Request;

		public Update_Stock_GrantInput()
		{
		}

		public Update_Stock_GrantInput(Workday_Common_HeaderType Workday_Common_Header, Update_Stock_Grant_RequestType Update_Stock_Grant_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Update_Stock_Grant_Request = Update_Stock_Grant_Request;
		}
	}
}
