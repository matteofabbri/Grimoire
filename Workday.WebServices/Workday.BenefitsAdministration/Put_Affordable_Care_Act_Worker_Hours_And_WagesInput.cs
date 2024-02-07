using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.BenefitsAdministration
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Affordable_Care_Act_Worker_Hours_And_WagesInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Affordable_Care_Act_Worker_Hours_And_Wages_RequestType Put_Affordable_Care_Act_Worker_Hours_And_Wages_Request;

		public Put_Affordable_Care_Act_Worker_Hours_And_WagesInput()
		{
		}

		public Put_Affordable_Care_Act_Worker_Hours_And_WagesInput(Workday_Common_HeaderType Workday_Common_Header, Put_Affordable_Care_Act_Worker_Hours_And_Wages_RequestType Put_Affordable_Care_Act_Worker_Hours_And_Wages_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Affordable_Care_Act_Worker_Hours_And_Wages_Request = Put_Affordable_Care_Act_Worker_Hours_And_Wages_Request;
		}
	}
}
