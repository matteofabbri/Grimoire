using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Talent
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Assess_TalentInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Assess_Talent_RequestType Assess_Talent_Request;

		public Assess_TalentInput()
		{
		}

		public Assess_TalentInput(Workday_Common_HeaderType Workday_Common_Header, Assess_Talent_RequestType Assess_Talent_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Assess_Talent_Request = Assess_Talent_Request;
		}
	}
}
