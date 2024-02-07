using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_EthnicitiesInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Ethnicities_RequestType Get_Ethnicities_Request;

		public Get_EthnicitiesInput()
		{
		}

		public Get_EthnicitiesInput(Workday_Common_HeaderType Workday_Common_Header, Get_Ethnicities_RequestType Get_Ethnicities_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Ethnicities_Request = Get_Ethnicities_Request;
		}
	}
}
