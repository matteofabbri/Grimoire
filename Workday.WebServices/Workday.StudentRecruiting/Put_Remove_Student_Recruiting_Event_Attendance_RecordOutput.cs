using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.StudentRecruiting
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Remove_Student_Recruiting_Event_Attendance_RecordOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Remove_Student_Recruiting_Event_Attendance_Record_ResponseType Put_Remove_Student_Recruiting_Event_Attendance_Record_Response;

		public Put_Remove_Student_Recruiting_Event_Attendance_RecordOutput()
		{
		}

		public Put_Remove_Student_Recruiting_Event_Attendance_RecordOutput(Put_Remove_Student_Recruiting_Event_Attendance_Record_ResponseType Put_Remove_Student_Recruiting_Event_Attendance_Record_Response)
		{
			this.Put_Remove_Student_Recruiting_Event_Attendance_Record_Response = Put_Remove_Student_Recruiting_Event_Attendance_Record_Response;
		}
	}
}
