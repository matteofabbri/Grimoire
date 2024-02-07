using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.BenefitsAdministration
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Change_BenefitsInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Change_Benefits_RequestType Change_Benefits_Request;

		public Change_BenefitsInput()
		{
		}

		public Change_BenefitsInput(Workday_Common_HeaderType Workday_Common_Header, Change_Benefits_RequestType Change_Benefits_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Change_Benefits_Request = Change_Benefits_Request;
		}
	}
}
