using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_TimesheetsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Timesheets_ResponseType Get_Timesheets_Response;

		public Get_TimesheetsOutput()
		{
		}

		public Get_TimesheetsOutput(Get_Timesheets_ResponseType Get_Timesheets_Response)
		{
			this.Get_Timesheets_Response = Get_Timesheets_Response;
		}
	}
}
