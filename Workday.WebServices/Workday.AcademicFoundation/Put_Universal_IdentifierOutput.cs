using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.AcademicFoundation
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Universal_IdentifierOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Universal_Identifier_ResponseType Put_Universal_Identifier_Response;

		public Put_Universal_IdentifierOutput()
		{
		}

		public Put_Universal_IdentifierOutput(Put_Universal_Identifier_ResponseType Put_Universal_Identifier_Response)
		{
			this.Put_Universal_Identifier_Response = Put_Universal_Identifier_Response;
		}
	}
}
