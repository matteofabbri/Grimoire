using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_ProgramsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Programs_ResponseType Get_Programs_Response;

		public Get_ProgramsOutput()
		{
		}

		public Get_ProgramsOutput(Get_Programs_ResponseType Get_Programs_Response)
		{
			this.Get_Programs_Response = Get_Programs_Response;
		}
	}
}
