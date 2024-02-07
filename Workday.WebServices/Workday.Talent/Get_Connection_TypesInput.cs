using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Talent
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Connection_TypesInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Connection_Types_RequestType Get_Connection_Types_Request;

		public Get_Connection_TypesInput()
		{
		}

		public Get_Connection_TypesInput(Workday_Common_HeaderType Workday_Common_Header, Get_Connection_Types_RequestType Get_Connection_Types_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Connection_Types_Request = Get_Connection_Types_Request;
		}
	}
}
