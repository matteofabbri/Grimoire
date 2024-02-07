using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.PerformanceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Goal_UnitOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Goal_Unit_ResponseType Put_Goal_Unit_Response;

		public Put_Goal_UnitOutput()
		{
		}

		public Put_Goal_UnitOutput(Put_Goal_Unit_ResponseType Put_Goal_Unit_Response)
		{
			this.Put_Goal_Unit_Response = Put_Goal_Unit_Response;
		}
	}
}
