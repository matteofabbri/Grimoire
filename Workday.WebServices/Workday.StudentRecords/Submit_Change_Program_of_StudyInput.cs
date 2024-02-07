using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.StudentRecords
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Submit_Change_Program_of_StudyInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Submit_Change_Program_of_Study_RequestType Submit_Change_Program_of_Study_Request;

		public Submit_Change_Program_of_StudyInput()
		{
		}

		public Submit_Change_Program_of_StudyInput(Workday_Common_HeaderType Workday_Common_Header, Submit_Change_Program_of_Study_RequestType Submit_Change_Program_of_Study_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Submit_Change_Program_of_Study_Request = Submit_Change_Program_of_Study_Request;
		}
	}
}
