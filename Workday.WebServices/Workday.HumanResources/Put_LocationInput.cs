using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_LocationInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Location_RequestType Put_Location_Request;

		public Put_LocationInput()
		{
		}

		public Put_LocationInput(Workday_Common_HeaderType Workday_Common_Header, Put_Location_RequestType Put_Location_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Location_Request = Put_Location_Request;
		}
	}
}
