using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Supplier_GroupOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Supplier_Group_ResponseType Put_Supplier_Group_Response;

		public Put_Supplier_GroupOutput()
		{
		}

		public Put_Supplier_GroupOutput(Put_Supplier_Group_ResponseType Put_Supplier_Group_Response)
		{
			this.Put_Supplier_Group_Response = Put_Supplier_Group_Response;
		}
	}
}
