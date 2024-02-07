using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_VAT_GroupOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_VAT_Group_ResponseType Put_VAT_Group_Response;

		public Put_VAT_GroupOutput()
		{
		}

		public Put_VAT_GroupOutput(Put_VAT_Group_ResponseType Put_VAT_Group_Response)
		{
			this.Put_VAT_Group_Response = Put_VAT_Group_Response;
		}
	}
}
