using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Spend_RestrictionInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Spend_Restriction_RequestType Put_Spend_Restriction_Request;

		public Put_Spend_RestrictionInput()
		{
		}

		public Put_Spend_RestrictionInput(Workday_Common_HeaderType Workday_Common_Header, Put_Spend_Restriction_RequestType Put_Spend_Restriction_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Spend_Restriction_Request = Put_Spend_Restriction_Request;
		}
	}
}
