using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.AcademicFoundation
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Education_Test_ResultInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Education_Test_Result_RequestType Put_Education_Test_Result_Request;

		public Put_Education_Test_ResultInput()
		{
		}

		public Put_Education_Test_ResultInput(Workday_Common_HeaderType Workday_Common_Header, Put_Education_Test_Result_RequestType Put_Education_Test_Result_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Education_Test_Result_Request = Put_Education_Test_Result_Request;
		}
	}
}
