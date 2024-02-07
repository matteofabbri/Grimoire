using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.PerformanceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Goal_UnitsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Goal_Units_ResponseType Get_Goal_Units_Response;

		public Get_Goal_UnitsOutput()
		{
		}

		public Get_Goal_UnitsOutput(Get_Goal_Units_ResponseType Get_Goal_Units_Response)
		{
			this.Get_Goal_Units_Response = Get_Goal_Units_Response;
		}
	}
}
