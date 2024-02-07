using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Talent
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Position_for_SuccessionInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Position_for_Succession_RequestType Put_Position_for_Succession_Request;

		public Put_Position_for_SuccessionInput()
		{
		}

		public Put_Position_for_SuccessionInput(Workday_Common_HeaderType Workday_Common_Header, Put_Position_for_Succession_RequestType Put_Position_for_Succession_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Position_for_Succession_Request = Put_Position_for_Succession_Request;
		}
	}
}
