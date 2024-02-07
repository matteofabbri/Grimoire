using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Committee_MeetingInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Committee_Meeting_RequestType Put_Committee_Meeting_Request;

		public Put_Committee_MeetingInput()
		{
		}

		public Put_Committee_MeetingInput(Workday_Common_HeaderType Workday_Common_Header, Put_Committee_Meeting_RequestType Put_Committee_Meeting_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Committee_Meeting_Request = Put_Committee_Meeting_Request;
		}
	}
}
