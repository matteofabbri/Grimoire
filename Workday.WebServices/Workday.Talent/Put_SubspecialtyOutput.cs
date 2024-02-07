using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Talent
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_SubspecialtyOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Subspecialty_ResponseType Put_Subspecialty_Response;

		public Put_SubspecialtyOutput()
		{
		}

		public Put_SubspecialtyOutput(Put_Subspecialty_ResponseType Put_Subspecialty_Response)
		{
			this.Put_Subspecialty_Response = Put_Subspecialty_Response;
		}
	}
}
