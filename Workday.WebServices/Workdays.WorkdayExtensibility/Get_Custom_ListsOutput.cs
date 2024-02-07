using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.WorkdayExtensibility
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Custom_ListsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Custom_Lists_ResponseType Get_Custom_Lists_Response;

		public Get_Custom_ListsOutput()
		{
		}

		public Get_Custom_ListsOutput(Get_Custom_Lists_ResponseType Get_Custom_Lists_Response)
		{
			this.Get_Custom_Lists_Response = Get_Custom_Lists_Response;
		}
	}
}
