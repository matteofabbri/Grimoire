using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.AcademicFoundation
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Universal_IdentifierInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Universal_Identifier_RequestType Put_Universal_Identifier_Request;

		public Put_Universal_IdentifierInput()
		{
		}

		public Put_Universal_IdentifierInput(Workday_Common_HeaderType Workday_Common_Header, Put_Universal_Identifier_RequestType Put_Universal_Identifier_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Universal_Identifier_Request = Put_Universal_Identifier_Request;
		}
	}
}
