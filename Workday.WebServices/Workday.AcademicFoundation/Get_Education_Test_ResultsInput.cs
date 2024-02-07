using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.AcademicFoundation
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Education_Test_ResultsInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Education_Test_Results_RequestType Get_Education_Test_Results_Request;

		public Get_Education_Test_ResultsInput()
		{
		}

		public Get_Education_Test_ResultsInput(Workday_Common_HeaderType Workday_Common_Header, Get_Education_Test_Results_RequestType Get_Education_Test_Results_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Education_Test_Results_Request = Get_Education_Test_Results_Request;
		}
	}
}
