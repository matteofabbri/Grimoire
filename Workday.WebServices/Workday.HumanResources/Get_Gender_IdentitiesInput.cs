using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Gender_IdentitiesInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Gender_Identities_RequestType Get_Gender_Identities_Request;

		public Get_Gender_IdentitiesInput()
		{
		}

		public Get_Gender_IdentitiesInput(Workday_Common_HeaderType Workday_Common_Header, Get_Gender_Identities_RequestType Get_Gender_Identities_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Gender_Identities_Request = Get_Gender_Identities_Request;
		}
	}
}
