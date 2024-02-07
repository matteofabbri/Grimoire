using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.SettlementServices
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Escheatment_ItemsInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Escheatment_Items_RequestType Get_Escheatment_Items_Request;

		public Get_Escheatment_ItemsInput()
		{
		}

		public Get_Escheatment_ItemsInput(Workday_Common_HeaderType Workday_Common_Header, Get_Escheatment_Items_RequestType Get_Escheatment_Items_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Escheatment_Items_Request = Get_Escheatment_Items_Request;
		}
	}
}
