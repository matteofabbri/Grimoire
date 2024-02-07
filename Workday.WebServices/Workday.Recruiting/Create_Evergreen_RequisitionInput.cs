using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Recruiting
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Create_Evergreen_RequisitionInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Create_Evergreen_Requisition_RequestType Create_Evergreen_Requisition_Request;

		public Create_Evergreen_RequisitionInput()
		{
		}

		public Create_Evergreen_RequisitionInput(Workday_Common_HeaderType Workday_Common_Header, Create_Evergreen_Requisition_RequestType Create_Evergreen_Requisition_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Create_Evergreen_Requisition_Request = Create_Evergreen_Requisition_Request;
		}
	}
}
