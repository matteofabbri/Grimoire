using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_SurveysInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Surveys_RequestType Get_Surveys_Request;

		public Get_SurveysInput()
		{
		}

		public Get_SurveysInput(Workday_Common_HeaderType Workday_Common_Header, Get_Surveys_RequestType Get_Surveys_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Surveys_Request = Get_Surveys_Request;
		}
	}
}
