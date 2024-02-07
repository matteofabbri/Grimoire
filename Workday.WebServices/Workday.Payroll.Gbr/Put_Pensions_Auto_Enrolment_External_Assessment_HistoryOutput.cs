using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Payroll.Gbr
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Pensions_Auto_Enrolment_External_Assessment_HistoryOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Pensions_Auto_Enrolment_External_Assessment_History_ResponseType Put_Pensions_Auto_Enrolment_External_Assessment_History_Response;

		public Put_Pensions_Auto_Enrolment_External_Assessment_HistoryOutput()
		{
		}

		public Put_Pensions_Auto_Enrolment_External_Assessment_HistoryOutput(Put_Pensions_Auto_Enrolment_External_Assessment_History_ResponseType Put_Pensions_Auto_Enrolment_External_Assessment_History_Response)
		{
			this.Put_Pensions_Auto_Enrolment_External_Assessment_History_Response = Put_Pensions_Auto_Enrolment_External_Assessment_History_Response;
		}
	}
}
