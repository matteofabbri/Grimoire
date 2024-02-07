using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.PerformanceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Review_TypesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Review_Types_ResponseType Get_Review_Types_Response;

		public Get_Review_TypesOutput()
		{
		}

		public Get_Review_TypesOutput(Get_Review_Types_ResponseType Get_Review_Types_Response)
		{
			this.Get_Review_Types_Response = Get_Review_Types_Response;
		}
	}
}
