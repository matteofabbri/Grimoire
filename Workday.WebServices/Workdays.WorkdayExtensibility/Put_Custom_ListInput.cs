using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.WorkdayExtensibility
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Custom_ListInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Custom_List_RequestType Put_Custom_List_Request;

		public Put_Custom_ListInput()
		{
		}

		public Put_Custom_ListInput(Workday_Common_HeaderType Workday_Common_Header, Put_Custom_List_RequestType Put_Custom_List_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Custom_List_Request = Put_Custom_List_Request;
		}
	}
}
