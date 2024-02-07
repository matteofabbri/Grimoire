using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Subaward_Risk_AssessmentOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Subaward_Risk_Assessment_ResponseType Put_Subaward_Risk_Assessment_Response;

		public Put_Subaward_Risk_AssessmentOutput()
		{
		}

		public Put_Subaward_Risk_AssessmentOutput(Put_Subaward_Risk_Assessment_ResponseType Put_Subaward_Risk_Assessment_Response)
		{
			this.Put_Subaward_Risk_Assessment_Response = Put_Subaward_Risk_Assessment_Response;
		}
	}
}
