using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.WorkdayConnect
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Message_TemplateInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Message_Template_RequestType Put_Message_Template_Request;

		public Put_Message_TemplateInput()
		{
		}

		public Put_Message_TemplateInput(Workday_Common_HeaderType Workday_Common_Header, Put_Message_Template_RequestType Put_Message_Template_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Message_Template_Request = Put_Message_Template_Request;
		}
	}
}
