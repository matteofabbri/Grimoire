using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Account_Posting_Rule_SetInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Account_Posting_Rule_Set_RequestType Put_Account_Posting_Rule_Set_Request;

		public Put_Account_Posting_Rule_SetInput()
		{
		}

		public Put_Account_Posting_Rule_SetInput(Workday_Common_HeaderType Workday_Common_Header, Put_Account_Posting_Rule_Set_RequestType Put_Account_Posting_Rule_Set_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Account_Posting_Rule_Set_Request = Put_Account_Posting_Rule_Set_Request;
		}
	}
}
