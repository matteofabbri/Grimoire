using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Inventory
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Inventory_Count_SheetsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Inventory_Count_Sheets_ResponseType Get_Inventory_Count_Sheets_Response;

		public Get_Inventory_Count_SheetsOutput()
		{
		}

		public Get_Inventory_Count_SheetsOutput(Get_Inventory_Count_Sheets_ResponseType Get_Inventory_Count_Sheets_Response)
		{
			this.Get_Inventory_Count_Sheets_Response = Get_Inventory_Count_Sheets_Response;
		}
	}
}
