using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.StudentRecords
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Submit_Grades_for_RegistrationsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Submit_Grades_for_Registrations_ResponseType Submit_Grades_for_Registrations_Response;

		public Submit_Grades_for_RegistrationsOutput()
		{
		}

		public Submit_Grades_for_RegistrationsOutput(Submit_Grades_for_Registrations_ResponseType Submit_Grades_for_Registrations_Response)
		{
			this.Submit_Grades_for_Registrations_Response = Submit_Grades_for_Registrations_Response;
		}
	}
}
