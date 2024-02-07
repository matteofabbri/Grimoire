using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Change_Background_Check_StatusInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Change_Background_Check_Status_RequestType Change_Background_Check_Status_Request;

		public Change_Background_Check_StatusInput()
		{
		}

		public Change_Background_Check_StatusInput(Workday_Common_HeaderType Workday_Common_Header, Change_Background_Check_Status_RequestType Change_Background_Check_Status_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Change_Background_Check_Status_Request = Change_Background_Check_Status_Request;
		}
	}
}
