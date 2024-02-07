using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Sales_Item_Fair_Value_Price_ListsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Sales_Item_Fair_Value_Price_Lists_ResponseType Get_Sales_Item_Fair_Value_Price_Lists_Response;

		public Get_Sales_Item_Fair_Value_Price_ListsOutput()
		{
		}

		public Get_Sales_Item_Fair_Value_Price_ListsOutput(Get_Sales_Item_Fair_Value_Price_Lists_ResponseType Get_Sales_Item_Fair_Value_Price_Lists_Response)
		{
			this.Get_Sales_Item_Fair_Value_Price_Lists_Response = Get_Sales_Item_Fair_Value_Price_Lists_Response;
		}
	}
}
