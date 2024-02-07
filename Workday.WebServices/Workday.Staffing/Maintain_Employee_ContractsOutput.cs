using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Staffing
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Maintain_Employee_ContractsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Maintain_Employee_Contracts_ResponseType Maintain_Employee_Contracts_Response;

		public Maintain_Employee_ContractsOutput()
		{
		}

		public Maintain_Employee_ContractsOutput(Maintain_Employee_Contracts_ResponseType Maintain_Employee_Contracts_Response)
		{
			this.Maintain_Employee_Contracts_Response = Maintain_Employee_Contracts_Response;
		}
	}
}
