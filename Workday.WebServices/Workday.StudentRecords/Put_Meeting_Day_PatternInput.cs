using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.StudentRecords
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Meeting_Day_PatternInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Meeting_Day_Pattern_RequestType Put_Meeting_Day_Pattern_Request;

		public Put_Meeting_Day_PatternInput()
		{
		}

		public Put_Meeting_Day_PatternInput(Workday_Common_HeaderType Workday_Common_Header, Put_Meeting_Day_Pattern_RequestType Put_Meeting_Day_Pattern_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Meeting_Day_Pattern_Request = Put_Meeting_Day_Pattern_Request;
		}
	}
}
