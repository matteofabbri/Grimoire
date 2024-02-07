using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Service_Center_RepresentativesInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Service_Center_Representatives_RequestType Get_Service_Center_Representatives_Request;

		public Get_Service_Center_RepresentativesInput()
		{
		}

		public Get_Service_Center_RepresentativesInput(Workday_Common_HeaderType Workday_Common_Header, Get_Service_Center_Representatives_RequestType Get_Service_Center_Representatives_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Service_Center_Representatives_Request = Get_Service_Center_Representatives_Request;
		}
	}
}
