using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Tax_Rule_Exception_GroupOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Tax_Rule_Exception_Group_ResponseType Put_Tax_Rule_Exception_Group_Response;

		public Put_Tax_Rule_Exception_GroupOutput()
		{
		}

		public Put_Tax_Rule_Exception_GroupOutput(Put_Tax_Rule_Exception_Group_ResponseType Put_Tax_Rule_Exception_Group_Response)
		{
			this.Put_Tax_Rule_Exception_Group_Response = Put_Tax_Rule_Exception_Group_Response;
		}
	}
}
