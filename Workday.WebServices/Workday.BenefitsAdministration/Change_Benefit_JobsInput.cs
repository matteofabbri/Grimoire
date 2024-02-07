using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.BenefitsAdministration
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Change_Benefit_JobsInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Change_Benefit_Jobs_RequestType Change_Benefit_Jobs_Request;

		public Change_Benefit_JobsInput()
		{
		}

		public Change_Benefit_JobsInput(Workday_Common_HeaderType Workday_Common_Header, Change_Benefit_Jobs_RequestType Change_Benefit_Jobs_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Change_Benefit_Jobs_Request = Change_Benefit_Jobs_Request;
		}
	}
}
