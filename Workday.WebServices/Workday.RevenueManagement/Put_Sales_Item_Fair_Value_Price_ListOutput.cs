using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Sales_Item_Fair_Value_Price_ListOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Sales_Item_Fair_Value_Price_List_ResponseType Put_Sales_Item_Fair_Value_Price_List_Response;

		public Put_Sales_Item_Fair_Value_Price_ListOutput()
		{
		}

		public Put_Sales_Item_Fair_Value_Price_ListOutput(Put_Sales_Item_Fair_Value_Price_List_ResponseType Put_Sales_Item_Fair_Value_Price_List_Response)
		{
			this.Put_Sales_Item_Fair_Value_Price_List_Response = Put_Sales_Item_Fair_Value_Price_List_Response;
		}
	}
}
