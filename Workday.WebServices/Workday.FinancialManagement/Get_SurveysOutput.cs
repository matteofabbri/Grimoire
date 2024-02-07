using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_SurveysOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Surveys_ResponseType Get_Surveys_Response;

		public Get_SurveysOutput()
		{
		}

		public Get_SurveysOutput(Get_Surveys_ResponseType Get_Surveys_Response)
		{
			this.Get_Surveys_Response = Get_Surveys_Response;
		}
	}
}
