using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Work_ShiftsInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Work_Shifts_RequestType Get_Work_Shifts_Request;

		public Get_Work_ShiftsInput()
		{
		}

		public Get_Work_ShiftsInput(Workday_Common_HeaderType Workday_Common_Header, Get_Work_Shifts_RequestType Get_Work_Shifts_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Work_Shifts_Request = Get_Work_Shifts_Request;
		}
	}
}
