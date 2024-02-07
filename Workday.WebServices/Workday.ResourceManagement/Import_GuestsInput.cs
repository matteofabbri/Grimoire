using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Import_GuestsInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Guest_Header__HV__RequestType Guest_Header__HV__Request;

		public Import_GuestsInput()
		{
		}

		public Import_GuestsInput(Workday_Common_HeaderType Workday_Common_Header, Guest_Header__HV__RequestType Guest_Header__HV__Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Guest_Header__HV__Request = Guest_Header__HV__Request;
		}
	}
}
