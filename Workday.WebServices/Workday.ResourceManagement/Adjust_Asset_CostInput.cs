using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Adjust_Asset_CostInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Adjust_Asset_Cost_RequestType Adjust_Asset_Cost_Request;

		public Adjust_Asset_CostInput()
		{
		}

		public Adjust_Asset_CostInput(Workday_Common_HeaderType Workday_Common_Header, Adjust_Asset_Cost_RequestType Adjust_Asset_Cost_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Adjust_Asset_Cost_Request = Adjust_Asset_Cost_Request;
		}
	}
}
