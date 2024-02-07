using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Receivable_Writeoff_CategoryOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Receivable_Writeoff_Category_ResponseType Put_Receivable_Writeoff_Category_Response;

		public Put_Receivable_Writeoff_CategoryOutput()
		{
		}

		public Put_Receivable_Writeoff_CategoryOutput(Put_Receivable_Writeoff_Category_ResponseType Put_Receivable_Writeoff_Category_Response)
		{
			this.Put_Receivable_Writeoff_Category_Response = Put_Receivable_Writeoff_Category_Response;
		}
	}
}
