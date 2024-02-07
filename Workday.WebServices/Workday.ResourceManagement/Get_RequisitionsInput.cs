using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_RequisitionsInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Requisitions_RequestType Get_Requisitions_Request;

		public Get_RequisitionsInput()
		{
		}

		public Get_RequisitionsInput(Workday_Common_HeaderType Workday_Common_Header, Get_Requisitions_RequestType Get_Requisitions_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Requisitions_Request = Get_Requisitions_Request;
		}
	}
}
