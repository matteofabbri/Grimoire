using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.StudentRecords
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Learning_OutcomeInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Learning_Outcome_RequestType Put_Learning_Outcome_Request;

		public Put_Learning_OutcomeInput()
		{
		}

		public Put_Learning_OutcomeInput(Workday_Common_HeaderType Workday_Common_Header, Put_Learning_Outcome_RequestType Put_Learning_Outcome_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Learning_Outcome_Request = Put_Learning_Outcome_Request;
		}
	}
}
