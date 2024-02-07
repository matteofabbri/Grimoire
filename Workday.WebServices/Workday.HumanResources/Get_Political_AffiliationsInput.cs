using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Political_AffiliationsInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Political_Affiliations_RequestType Get_Political_Affiliations_Request;

		public Get_Political_AffiliationsInput()
		{
		}

		public Get_Political_AffiliationsInput(Workday_Common_HeaderType Workday_Common_Header, Get_Political_Affiliations_RequestType Get_Political_Affiliations_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Political_Affiliations_Request = Get_Political_Affiliations_Request;
		}
	}
}
