using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Organization_Reference_IDsInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Organization_Reference_IDs_RequestType Get_Organization_Reference_IDs_Request;

		public Get_Organization_Reference_IDsInput()
		{
		}

		public Get_Organization_Reference_IDsInput(Workday_Common_HeaderType Workday_Common_Header, Get_Organization_Reference_IDs_RequestType Get_Organization_Reference_IDs_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Organization_Reference_IDs_Request = Get_Organization_Reference_IDs_Request;
		}
	}
}
