using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Compensation
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Launch_Employee_Severance_WorksheetInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Launch_Employee_Severance_Worksheet_RequestType Launch_Employee_Severance_Worksheet_Request;

		public Launch_Employee_Severance_WorksheetInput()
		{
		}

		public Launch_Employee_Severance_WorksheetInput(Workday_Common_HeaderType Workday_Common_Header, Launch_Employee_Severance_Worksheet_RequestType Launch_Employee_Severance_Worksheet_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Launch_Employee_Severance_Worksheet_Request = Launch_Employee_Severance_Worksheet_Request;
		}
	}
}
