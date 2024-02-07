using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_ProgramOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Program_ResponseType Put_Program_Response;

		public Put_ProgramOutput()
		{
		}

		public Put_ProgramOutput(Put_Program_ResponseType Put_Program_Response)
		{
			this.Put_Program_Response = Put_Program_Response;
		}
	}
}
