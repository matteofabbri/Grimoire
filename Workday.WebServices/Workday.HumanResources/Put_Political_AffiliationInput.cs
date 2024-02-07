using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Political_AffiliationInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Political_Affiliation_RequestType Put_Political_Affiliation_Request;

		public Put_Political_AffiliationInput()
		{
		}

		public Put_Political_AffiliationInput(Workday_Common_HeaderType Workday_Common_Header, Put_Political_Affiliation_RequestType Put_Political_Affiliation_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Political_Affiliation_Request = Put_Political_Affiliation_Request;
		}
	}
}
