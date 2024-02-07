using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Service_Center_RepresentativeInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Service_Center_Representative_RequestType Put_Service_Center_Representative_Request;

		public Put_Service_Center_RepresentativeInput()
		{
		}

		public Put_Service_Center_RepresentativeInput(Workday_Common_HeaderType Workday_Common_Header, Put_Service_Center_Representative_RequestType Put_Service_Center_Representative_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Service_Center_Representative_Request = Put_Service_Center_Representative_Request;
		}
	}
}
