using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_SurveyInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Survey_RequestType Put_Survey_Request;

		public Put_SurveyInput()
		{
		}

		public Put_SurveyInput(Workday_Common_HeaderType Workday_Common_Header, Put_Survey_RequestType Put_Survey_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Survey_Request = Put_Survey_Request;
		}
	}
}
