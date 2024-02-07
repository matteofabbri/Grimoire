using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Staffing
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Maintain_Employee_ContractsInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Maintain_Employee_Contracts_RequestType Maintain_Employee_Contracts_Request;

		public Maintain_Employee_ContractsInput()
		{
		}

		public Maintain_Employee_ContractsInput(Workday_Common_HeaderType Workday_Common_Header, Maintain_Employee_Contracts_RequestType Maintain_Employee_Contracts_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Maintain_Employee_Contracts_Request = Maintain_Employee_Contracts_Request;
		}
	}
}
