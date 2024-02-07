using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Subrecipient_Risk_RecordsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Subrecipient_Risk_Records_ResponseType Get_Subrecipient_Risk_Records_Response;

		public Get_Subrecipient_Risk_RecordsOutput()
		{
		}

		public Get_Subrecipient_Risk_RecordsOutput(Get_Subrecipient_Risk_Records_ResponseType Get_Subrecipient_Risk_Records_Response)
		{
			this.Get_Subrecipient_Risk_Records_Response = Get_Subrecipient_Risk_Records_Response;
		}
	}
}
