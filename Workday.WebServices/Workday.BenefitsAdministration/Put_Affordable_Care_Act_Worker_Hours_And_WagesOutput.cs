using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.BenefitsAdministration
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Affordable_Care_Act_Worker_Hours_And_WagesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Affordable_Care_Act_Worker_Hours_And_Wages_ResponseType Put_Affordable_Care_Act_Worker_Hours_And_Wages_Response;

		public Put_Affordable_Care_Act_Worker_Hours_And_WagesOutput()
		{
		}

		public Put_Affordable_Care_Act_Worker_Hours_And_WagesOutput(Put_Affordable_Care_Act_Worker_Hours_And_Wages_ResponseType Put_Affordable_Care_Act_Worker_Hours_And_Wages_Response)
		{
			this.Put_Affordable_Care_Act_Worker_Hours_And_Wages_Response = Put_Affordable_Care_Act_Worker_Hours_And_Wages_Response;
		}
	}
}
