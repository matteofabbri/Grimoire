using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Payroll
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_ROE_History_DataOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_ROE_History_Data_ResponseType Put_ROE_History_Data_Response;

		public Put_ROE_History_DataOutput()
		{
		}

		public Put_ROE_History_DataOutput(Put_ROE_History_Data_ResponseType Put_ROE_History_Data_Response)
		{
			this.Put_ROE_History_Data_Response = Put_ROE_History_Data_Response;
		}
	}
}
