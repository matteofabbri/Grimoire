using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Subrecipient_Risk_RecordsInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Subrecipient_Risk_Records_RequestType Get_Subrecipient_Risk_Records_Request;

		public Get_Subrecipient_Risk_RecordsInput()
		{
		}

		public Get_Subrecipient_Risk_RecordsInput(Workday_Common_HeaderType Workday_Common_Header, Get_Subrecipient_Risk_Records_RequestType Get_Subrecipient_Risk_Records_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Subrecipient_Risk_Records_Request = Get_Subrecipient_Risk_Records_Request;
		}
	}
}
