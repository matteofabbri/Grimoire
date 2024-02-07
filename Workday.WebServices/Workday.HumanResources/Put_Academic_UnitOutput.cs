using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Academic_UnitOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Academic_Unit_ResponseType Put_Academic_Unit_Response;

		public Put_Academic_UnitOutput()
		{
		}

		public Put_Academic_UnitOutput(Put_Academic_Unit_ResponseType Put_Academic_Unit_Response)
		{
			this.Put_Academic_Unit_Response = Put_Academic_Unit_Response;
		}
	}
}
