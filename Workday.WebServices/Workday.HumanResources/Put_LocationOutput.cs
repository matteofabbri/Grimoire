using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_LocationOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Location_ResponseType Put_Location_Response;

		public Put_LocationOutput()
		{
		}

		public Put_LocationOutput(Put_Location_ResponseType Put_Location_Response)
		{
			this.Put_Location_Response = Put_Location_Response;
		}
	}
}
