using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Tax_Rule_Exception_GroupsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Tax_Rule_Exception_Groups_ResponseType Get_Tax_Rule_Exception_Groups_Response;

		public Get_Tax_Rule_Exception_GroupsOutput()
		{
		}

		public Get_Tax_Rule_Exception_GroupsOutput(Get_Tax_Rule_Exception_Groups_ResponseType Get_Tax_Rule_Exception_Groups_Response)
		{
			this.Get_Tax_Rule_Exception_Groups_Response = Get_Tax_Rule_Exception_Groups_Response;
		}
	}
}
