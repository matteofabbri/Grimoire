using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Subaward_Risk_AssessmentsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Subaward_Risk_Assessments_ResponseType Get_Subaward_Risk_Assessments_Response;

		public Get_Subaward_Risk_AssessmentsOutput()
		{
		}

		public Get_Subaward_Risk_AssessmentsOutput(Get_Subaward_Risk_Assessments_ResponseType Get_Subaward_Risk_Assessments_Response)
		{
			this.Get_Subaward_Risk_Assessments_Response = Get_Subaward_Risk_Assessments_Response;
		}
	}
}
