using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Talent
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_SubspecialtyInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Subspecialty_RequestType Put_Subspecialty_Request;

		public Put_SubspecialtyInput()
		{
		}

		public Put_SubspecialtyInput(Workday_Common_HeaderType Workday_Common_Header, Put_Subspecialty_RequestType Put_Subspecialty_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Subspecialty_Request = Put_Subspecialty_Request;
		}
	}
}
