using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Submit_RequisitionInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Submit_Requisition_RequestType Submit_Requisition_Request;

		public Submit_RequisitionInput()
		{
		}

		public Submit_RequisitionInput(Workday_Common_HeaderType Workday_Common_Header, Submit_Requisition_RequestType Submit_Requisition_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Submit_Requisition_Request = Submit_Requisition_Request;
		}
	}
}
