using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Work_ShiftInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Work_Shift_RequestType Put_Work_Shift_Request;

		public Put_Work_ShiftInput()
		{
		}

		public Put_Work_ShiftInput(Workday_Common_HeaderType Workday_Common_Header, Put_Work_Shift_RequestType Put_Work_Shift_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Work_Shift_Request = Put_Work_Shift_Request;
		}
	}
}
