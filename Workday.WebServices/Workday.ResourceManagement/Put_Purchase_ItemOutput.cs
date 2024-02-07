using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Purchase_ItemOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Purchase_Item_ResponseType Put_Purchase_Item_Response;

		public Put_Purchase_ItemOutput()
		{
		}

		public Put_Purchase_ItemOutput(Put_Purchase_Item_ResponseType Put_Purchase_Item_Response)
		{
			this.Put_Purchase_Item_Response = Put_Purchase_Item_Response;
		}
	}
}
