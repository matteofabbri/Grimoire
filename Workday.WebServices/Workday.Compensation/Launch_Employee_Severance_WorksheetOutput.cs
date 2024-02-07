using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Compensation
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Launch_Employee_Severance_WorksheetOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Launch_Employee_Severance_Worksheet_ResponseType Launch_Employee_Severance_Worksheet_Response;

		public Launch_Employee_Severance_WorksheetOutput()
		{
		}

		public Launch_Employee_Severance_WorksheetOutput(Launch_Employee_Severance_Worksheet_ResponseType Launch_Employee_Severance_Worksheet_Response)
		{
			this.Launch_Employee_Severance_Worksheet_Response = Launch_Employee_Severance_Worksheet_Response;
		}
	}
}
