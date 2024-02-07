using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Payroll.Gbr
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Worker_Pensions_Auto_Enrolment_DetailsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Worker_Pensions_Auto_Enrolment_Details_ResponseType Get_Worker_Pensions_Auto_Enrolment_Details_Response;

		public Get_Worker_Pensions_Auto_Enrolment_DetailsOutput()
		{
		}

		public Get_Worker_Pensions_Auto_Enrolment_DetailsOutput(Get_Worker_Pensions_Auto_Enrolment_Details_ResponseType Get_Worker_Pensions_Auto_Enrolment_Details_Response)
		{
			this.Get_Worker_Pensions_Auto_Enrolment_Details_Response = Get_Worker_Pensions_Auto_Enrolment_Details_Response;
		}
	}
}
