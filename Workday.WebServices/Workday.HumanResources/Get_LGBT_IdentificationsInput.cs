using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_LGBT_IdentificationsInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_LGBT_Identifications_RequestType Get_LGBT_Identifications_Request;

		public Get_LGBT_IdentificationsInput()
		{
		}

		public Get_LGBT_IdentificationsInput(Workday_Common_HeaderType Workday_Common_Header, Get_LGBT_Identifications_RequestType Get_LGBT_Identifications_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_LGBT_Identifications_Request = Get_LGBT_Identifications_Request;
		}
	}
}
