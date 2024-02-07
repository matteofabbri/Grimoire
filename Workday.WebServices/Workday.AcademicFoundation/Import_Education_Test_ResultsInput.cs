using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.AcademicFoundation
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Import_Education_Test_ResultsInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Import_Education_Test_Result_RequestType Import_Education_Test_Result_Request;

		public Import_Education_Test_ResultsInput()
		{
		}

		public Import_Education_Test_ResultsInput(Workday_Common_HeaderType Workday_Common_Header, Import_Education_Test_Result_RequestType Import_Education_Test_Result_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Import_Education_Test_Result_Request = Import_Education_Test_Result_Request;
		}
	}
}
