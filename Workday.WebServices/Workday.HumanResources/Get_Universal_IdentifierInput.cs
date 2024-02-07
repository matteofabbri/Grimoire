using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Universal_IdentifierInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Universal_Identifiers_RequestType Get_Universal_Identifiers_Request;

		public Get_Universal_IdentifierInput()
		{
		}

		public Get_Universal_IdentifierInput(Workday_Common_HeaderType Workday_Common_Header, Get_Universal_Identifiers_RequestType Get_Universal_Identifiers_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Universal_Identifiers_Request = Get_Universal_Identifiers_Request;
		}
	}
}
