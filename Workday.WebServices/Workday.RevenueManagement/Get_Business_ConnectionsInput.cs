using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Business_ConnectionsInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Business_Connections_RequestType Get_Business_Connections_Request;

		public Get_Business_ConnectionsInput()
		{
		}

		public Get_Business_ConnectionsInput(Workday_Common_HeaderType Workday_Common_Header, Get_Business_Connections_RequestType Get_Business_Connections_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Business_Connections_Request = Get_Business_Connections_Request;
		}
	}
}
