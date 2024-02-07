using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Payroll
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Periodic_Company_Tax_Filing_DataOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Periodic_Company_Tax_Filing_Data_ResponseType Get_Periodic_Company_Tax_Filing_Data_Response;

		public Get_Periodic_Company_Tax_Filing_DataOutput()
		{
		}

		public Get_Periodic_Company_Tax_Filing_DataOutput(Get_Periodic_Company_Tax_Filing_Data_ResponseType Get_Periodic_Company_Tax_Filing_Data_Response)
		{
			this.Get_Periodic_Company_Tax_Filing_Data_Response = Get_Periodic_Company_Tax_Filing_Data_Response;
		}
	}
}
