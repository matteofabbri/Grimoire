using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.CashManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Investment_Pool_PurchasesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Investment_Pool_Purchases_ResponseType Get_Investment_Pool_Purchases_Response;

		public Get_Investment_Pool_PurchasesOutput()
		{
		}

		public Get_Investment_Pool_PurchasesOutput(Get_Investment_Pool_Purchases_ResponseType Get_Investment_Pool_Purchases_Response)
		{
			this.Get_Investment_Pool_Purchases_Response = Get_Investment_Pool_Purchases_Response;
		}
	}
}
