using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Basic_ProjectOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Project_ResponseType Put_Project_Response;

		public Put_Basic_ProjectOutput()
		{
		}

		public Put_Basic_ProjectOutput(Put_Project_ResponseType Put_Project_Response)
		{
			this.Put_Project_Response = Put_Project_Response;
		}
	}
}
