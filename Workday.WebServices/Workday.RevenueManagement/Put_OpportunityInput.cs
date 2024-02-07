using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_OpportunityInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Opportunity_RequestType Put_Opportunity_Request;

		public Put_OpportunityInput()
		{
		}

		public Put_OpportunityInput(Workday_Common_HeaderType Workday_Common_Header, Put_Opportunity_RequestType Put_Opportunity_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Opportunity_Request = Put_Opportunity_Request;
		}
	}
}
