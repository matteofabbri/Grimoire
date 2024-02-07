using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Inventory
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Submit_Inventory_MoveOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Submit_Inventory_Move_ResponseType Submit_Inventory_Move_Response;

		public Submit_Inventory_MoveOutput()
		{
		}

		public Submit_Inventory_MoveOutput(Submit_Inventory_Move_ResponseType Submit_Inventory_Move_Response)
		{
			this.Submit_Inventory_Move_Response = Submit_Inventory_Move_Response;
		}
	}
}
