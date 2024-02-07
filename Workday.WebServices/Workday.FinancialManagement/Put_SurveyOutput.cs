using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_SurveyOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Survey_ResponseType Put_Survey_Response;

		public Put_SurveyOutput()
		{
		}

		public Put_SurveyOutput(Put_Survey_ResponseType Put_Survey_Response)
		{
			this.Put_Survey_Response = Put_Survey_Response;
		}
	}
}
