using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.StudentRecords
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Submit_Grades_for_RegistrationsInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Submit_Grades_for_Registrations_RequestType Submit_Grades_for_Registrations_Request;

		public Submit_Grades_for_RegistrationsInput()
		{
		}

		public Submit_Grades_for_RegistrationsInput(Workday_Common_HeaderType Workday_Common_Header, Submit_Grades_for_Registrations_RequestType Submit_Grades_for_Registrations_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Submit_Grades_for_Registrations_Request = Submit_Grades_for_Registrations_Request;
		}
	}
}
