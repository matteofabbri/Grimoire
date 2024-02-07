using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Staffing
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class End_Contingent_Worker_ContractInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public End_Contingent_Worker_Contract_RequestType End_Contingent_Worker_Contract_Request;

		public End_Contingent_Worker_ContractInput()
		{
		}

		public End_Contingent_Worker_ContractInput(Workday_Common_HeaderType Workday_Common_Header, End_Contingent_Worker_Contract_RequestType End_Contingent_Worker_Contract_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.End_Contingent_Worker_Contract_Request = End_Contingent_Worker_Contract_Request;
		}
	}
}
