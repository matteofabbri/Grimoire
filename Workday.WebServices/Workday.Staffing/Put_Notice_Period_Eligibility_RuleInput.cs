using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Staffing
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Notice_Period_Eligibility_RuleInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Notice_Period_Eligibility_Rule_RequestType Put_Notice_Period_Eligibility_Rule_Request;

		public Put_Notice_Period_Eligibility_RuleInput()
		{
		}

		public Put_Notice_Period_Eligibility_RuleInput(Workday_Common_HeaderType Workday_Common_Header, Put_Notice_Period_Eligibility_Rule_RequestType Put_Notice_Period_Eligibility_Rule_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Notice_Period_Eligibility_Rule_Request = Put_Notice_Period_Eligibility_Rule_Request;
		}
	}
}
