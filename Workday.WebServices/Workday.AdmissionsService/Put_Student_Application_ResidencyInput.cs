using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Admissions
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Student_Application_ResidencyInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Student_Application_Residency_RequestType Put_Student_Application_Residency_Request;

		public Put_Student_Application_ResidencyInput()
		{
		}

		public Put_Student_Application_ResidencyInput(Workday_Common_HeaderType Workday_Common_Header, Put_Student_Application_Residency_RequestType Put_Student_Application_Residency_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Student_Application_Residency_Request = Put_Student_Application_Residency_Request;
		}
	}
}
