using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.PerformanceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Review_TypeOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Review_Type_ResponseType Put_Review_Type_Response;

		public Put_Review_TypeOutput()
		{
		}

		public Put_Review_TypeOutput(Put_Review_Type_ResponseType Put_Review_Type_Response)
		{
			this.Put_Review_Type_Response = Put_Review_Type_Response;
		}
	}
}
