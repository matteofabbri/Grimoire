using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.PerformanceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Field_Of_StudyInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Field_Of_Study_RequestType Put_Field_Of_Study_Request;

		public Put_Field_Of_StudyInput()
		{
		}

		public Put_Field_Of_StudyInput(Workday_Common_HeaderType Workday_Common_Header, Put_Field_Of_Study_RequestType Put_Field_Of_Study_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Field_Of_Study_Request = Put_Field_Of_Study_Request;
		}
	}
}
