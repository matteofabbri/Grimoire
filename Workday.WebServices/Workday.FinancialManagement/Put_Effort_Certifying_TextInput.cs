using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Effort_Certifying_TextInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Effort_Certifying_Text_RequestType Put_Effort_Certifying_Text_Request;

		public Put_Effort_Certifying_TextInput()
		{
		}

		public Put_Effort_Certifying_TextInput(Workday_Common_HeaderType Workday_Common_Header, Put_Effort_Certifying_Text_RequestType Put_Effort_Certifying_Text_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Effort_Certifying_Text_Request = Put_Effort_Certifying_Text_Request;
		}
	}
}
