using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Talent
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Contact_ConnectionInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Contact_Connection_RequestType Put_Contact_Connection_Request;

		public Put_Contact_ConnectionInput()
		{
		}

		public Put_Contact_ConnectionInput(Workday_Common_HeaderType Workday_Common_Header, Put_Contact_Connection_RequestType Put_Contact_Connection_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Contact_Connection_Request = Put_Contact_Connection_Request;
		}
	}
}
