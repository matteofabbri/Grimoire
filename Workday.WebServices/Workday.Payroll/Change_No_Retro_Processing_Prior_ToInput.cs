using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Payroll
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Change_No_Retro_Processing_Prior_ToInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Change_No_Retro_Processing_Prior_To_RequestType Change_No_Retro_Processing_Prior_To_Request;

		public Change_No_Retro_Processing_Prior_ToInput()
		{
		}

		public Change_No_Retro_Processing_Prior_ToInput(Workday_Common_HeaderType Workday_Common_Header, Change_No_Retro_Processing_Prior_To_RequestType Change_No_Retro_Processing_Prior_To_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Change_No_Retro_Processing_Prior_To_Request = Change_No_Retro_Processing_Prior_To_Request;
		}
	}
}
