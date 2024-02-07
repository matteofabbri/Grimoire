using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Staffing
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Edit_Service_DatesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Edit_Service_Dates_ResponseType Edit_Service_Dates_Response;

		public Edit_Service_DatesOutput()
		{
		}

		public Edit_Service_DatesOutput(Edit_Service_Dates_ResponseType Edit_Service_Dates_Response)
		{
			this.Edit_Service_Dates_Response = Edit_Service_Dates_Response;
		}
	}
}
