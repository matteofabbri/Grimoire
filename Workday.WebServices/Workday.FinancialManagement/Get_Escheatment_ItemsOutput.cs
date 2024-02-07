using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Escheatment_ItemsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Escheatment_Items_ResponseType Get_Escheatment_Items_Response;

		public Get_Escheatment_ItemsOutput()
		{
		}

		public Get_Escheatment_ItemsOutput(Get_Escheatment_Items_ResponseType Get_Escheatment_Items_Response)
		{
			this.Get_Escheatment_Items_Response = Get_Escheatment_Items_Response;
		}
	}
}
