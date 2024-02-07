using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Customer_GroupOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Customer_Group_ResponseType Put_Customer_Group_Response;

		public Put_Customer_GroupOutput()
		{
		}

		public Put_Customer_GroupOutput(Put_Customer_Group_ResponseType Put_Customer_Group_Response)
		{
			this.Put_Customer_Group_Response = Put_Customer_Group_Response;
		}
	}
}
