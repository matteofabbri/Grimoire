using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Submit_Escheatment_ItemsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Submit_Escheatment_Items_ResponseType Submit_Escheatment_Items_Response;

		public Submit_Escheatment_ItemsOutput()
		{
		}

		public Submit_Escheatment_ItemsOutput(Submit_Escheatment_Items_ResponseType Submit_Escheatment_Items_Response)
		{
			this.Submit_Escheatment_Items_Response = Submit_Escheatment_Items_Response;
		}
	}
}
