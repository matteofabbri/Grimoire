using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Payroll
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Quarterly_Worker_Tax_Filing_DataOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Quarterly_Worker_Tax_Data_ResponseType Get_Quarterly_Worker_Tax_Data_Response;

		public Get_Quarterly_Worker_Tax_Filing_DataOutput()
		{
		}

		public Get_Quarterly_Worker_Tax_Filing_DataOutput(Get_Quarterly_Worker_Tax_Data_ResponseType Get_Quarterly_Worker_Tax_Data_Response)
		{
			this.Get_Quarterly_Worker_Tax_Data_Response = Get_Quarterly_Worker_Tax_Data_Response;
		}
	}
}
