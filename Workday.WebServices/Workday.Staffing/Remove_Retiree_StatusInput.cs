using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Staffing
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Remove_Retiree_StatusInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Remove_Retiree_Status_RequestType Remove_Retiree_Status_Request;

		public Remove_Retiree_StatusInput()
		{
		}

		public Remove_Retiree_StatusInput(Workday_Common_HeaderType Workday_Common_Header, Remove_Retiree_Status_RequestType Remove_Retiree_Status_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Remove_Retiree_Status_Request = Remove_Retiree_Status_Request;
		}
	}
}
