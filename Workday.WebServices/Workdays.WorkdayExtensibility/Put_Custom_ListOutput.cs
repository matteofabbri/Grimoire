using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.WorkdayExtensibility
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Custom_ListOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Custom_List_ResponseType Put_Custom_List_Response;

		public Put_Custom_ListOutput()
		{
		}

		public Put_Custom_ListOutput(Put_Custom_List_ResponseType Put_Custom_List_Response)
		{
			this.Put_Custom_List_Response = Put_Custom_List_Response;
		}
	}
}
