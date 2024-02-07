using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Payroll.Fra
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_DSN_DataOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_DSN_Data_ResponseType Get_DSN_Data_Response;

		public Get_DSN_DataOutput()
		{
		}

		public Get_DSN_DataOutput(Get_DSN_Data_ResponseType Get_DSN_Data_Response)
		{
			this.Get_DSN_Data_Response = Get_DSN_Data_Response;
		}
	}
}
