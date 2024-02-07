using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Basic_Sales_ItemOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Sales_Item_ResponseType Put_Sales_Item_Response;

		public Put_Basic_Sales_ItemOutput()
		{
		}

		public Put_Basic_Sales_ItemOutput(Put_Sales_Item_ResponseType Put_Sales_Item_Response)
		{
			this.Put_Sales_Item_Response = Put_Sales_Item_Response;
		}
	}
}
