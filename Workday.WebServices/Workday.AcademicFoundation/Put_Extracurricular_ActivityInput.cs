using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.AcademicFoundation
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Extracurricular_ActivityInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Extracurricular_Activity_RequestType Put_Extracurricular_Activity_Request;

		public Put_Extracurricular_ActivityInput()
		{
		}

		public Put_Extracurricular_ActivityInput(Workday_Common_HeaderType Workday_Common_Header, Put_Extracurricular_Activity_RequestType Put_Extracurricular_Activity_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Extracurricular_Activity_Request = Put_Extracurricular_Activity_Request;
		}
	}
}
