using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Place_Asset_in_ServiceInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Place_Asset_in_Service_RequestType Place_Asset_in_Service_Request;

		public Place_Asset_in_ServiceInput()
		{
		}

		public Place_Asset_in_ServiceInput(Workday_Common_HeaderType Workday_Common_Header, Place_Asset_in_Service_RequestType Place_Asset_in_Service_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Place_Asset_in_Service_Request = Place_Asset_in_Service_Request;
		}
	}
}
