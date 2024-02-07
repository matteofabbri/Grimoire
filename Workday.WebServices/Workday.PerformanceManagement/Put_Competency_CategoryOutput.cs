using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.PerformanceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Competency_CategoryOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Competency_Category_ResponseType Put_Competency_Category_Response;

		public Put_Competency_CategoryOutput()
		{
		}

		public Put_Competency_CategoryOutput(Put_Competency_Category_ResponseType Put_Competency_Category_Response)
		{
			this.Put_Competency_Category_Response = Put_Competency_Category_Response;
		}
	}
}
