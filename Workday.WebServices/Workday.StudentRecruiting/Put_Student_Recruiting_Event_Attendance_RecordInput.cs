using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.StudentRecruiting
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Student_Recruiting_Event_Attendance_RecordInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Student_Recruiting_Event_Attendance_Record_RequestType Put_Student_Recruiting_Event_Attendance_Record_Request;

		public Put_Student_Recruiting_Event_Attendance_RecordInput()
		{
		}

		public Put_Student_Recruiting_Event_Attendance_RecordInput(Workday_Common_HeaderType Workday_Common_Header, Put_Student_Recruiting_Event_Attendance_Record_RequestType Put_Student_Recruiting_Event_Attendance_Record_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Student_Recruiting_Event_Attendance_Record_Request = Put_Student_Recruiting_Event_Attendance_Record_Request;
		}
	}
}
