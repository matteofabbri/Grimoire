using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Procurement_Mass_CloseInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Procurement_Mass_Close_RequestType Get_Procurement_Mass_Close_Request;

		public Get_Procurement_Mass_CloseInput()
		{
		}

		public Get_Procurement_Mass_CloseInput(Workday_Common_HeaderType Workday_Common_Header, Get_Procurement_Mass_Close_RequestType Get_Procurement_Mass_Close_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Procurement_Mass_Close_Request = Get_Procurement_Mass_Close_Request;
		}
	}
}
