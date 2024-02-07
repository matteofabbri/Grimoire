using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Payroll.Gbr
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Pensions_Auto_Enrolment_External_Assessment_HistoryOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Pensions_Auto_Enrolment_External_Assessment_History_ResponseType Get_Pensions_Auto_Enrolment_External_Assessment_History_Response;

		public Get_Pensions_Auto_Enrolment_External_Assessment_HistoryOutput()
		{
		}

		public Get_Pensions_Auto_Enrolment_External_Assessment_HistoryOutput(Get_Pensions_Auto_Enrolment_External_Assessment_History_ResponseType Get_Pensions_Auto_Enrolment_External_Assessment_History_Response)
		{
			this.Get_Pensions_Auto_Enrolment_External_Assessment_History_Response = Get_Pensions_Auto_Enrolment_External_Assessment_History_Response;
		}
	}
}
