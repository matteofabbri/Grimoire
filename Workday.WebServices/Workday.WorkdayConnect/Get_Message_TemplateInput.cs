using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.WorkdayConnect
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Message_TemplateInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Message_Template_RequestType Get_Message_Template_Request;

		public Get_Message_TemplateInput()
		{
		}

		public Get_Message_TemplateInput(Workday_Common_HeaderType Workday_Common_Header, Get_Message_Template_RequestType Get_Message_Template_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Message_Template_Request = Get_Message_Template_Request;
		}
	}
}
