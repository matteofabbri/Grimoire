using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Payroll.Gbr
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Worker_Pensions_Auto_Enrolment_DetailsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Worker_Pensions_Auto_Enrolment_Details_ResponseType Put_Worker_Pensions_Auto_Enrolment_Details_Response;

		public Put_Worker_Pensions_Auto_Enrolment_DetailsOutput()
		{
		}

		public Put_Worker_Pensions_Auto_Enrolment_DetailsOutput(Put_Worker_Pensions_Auto_Enrolment_Details_ResponseType Put_Worker_Pensions_Auto_Enrolment_Details_Response)
		{
			this.Put_Worker_Pensions_Auto_Enrolment_Details_Response = Put_Worker_Pensions_Auto_Enrolment_Details_Response;
		}
	}
}
