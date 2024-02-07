using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Effort_Certification_TypesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Effort_Certification_Types_ResponseType Get_Effort_Certification_Types_Response;

		public Get_Effort_Certification_TypesOutput()
		{
		}

		public Get_Effort_Certification_TypesOutput(Get_Effort_Certification_Types_ResponseType Get_Effort_Certification_Types_Response)
		{
			this.Get_Effort_Certification_Types_Response = Get_Effort_Certification_Types_Response;
		}
	}
}
