using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.StudentRecords
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Scheduled_AssessmentsInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Scheduled_Assessments_RequestType Get_Scheduled_Assessments_Request;

		public Get_Scheduled_AssessmentsInput()
		{
		}

		public Get_Scheduled_AssessmentsInput(Workday_Common_HeaderType Workday_Common_Header, Get_Scheduled_Assessments_RequestType Get_Scheduled_Assessments_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Scheduled_Assessments_Request = Get_Scheduled_Assessments_Request;
		}
	}
}
