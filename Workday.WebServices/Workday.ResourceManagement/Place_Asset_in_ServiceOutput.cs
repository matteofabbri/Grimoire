using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Place_Asset_in_ServiceOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Place_Asset_in_Service_ResponseType Place_Asset_in_Service_Response;

		public Place_Asset_in_ServiceOutput()
		{
		}

		public Place_Asset_in_ServiceOutput(Place_Asset_in_Service_ResponseType Place_Asset_in_Service_Response)
		{
			this.Place_Asset_in_Service_Response = Place_Asset_in_Service_Response;
		}
	}
}
