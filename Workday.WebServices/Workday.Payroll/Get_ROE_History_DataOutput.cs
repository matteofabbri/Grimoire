using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Payroll
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_ROE_History_DataOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_ROE_History_Data_ResponseType Get_ROE_History_Data_Response;

		public Get_ROE_History_DataOutput()
		{
		}

		public Get_ROE_History_DataOutput(Get_ROE_History_Data_ResponseType Get_ROE_History_Data_Response)
		{
			this.Get_ROE_History_Data_Response = Get_ROE_History_Data_Response;
		}
	}
}
