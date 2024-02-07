using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Worker_PhotoOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Worker_Photo_ResponseType Put_Worker_Photo_Response;

		public Put_Worker_PhotoOutput()
		{
		}

		public Put_Worker_PhotoOutput(Put_Worker_Photo_ResponseType Put_Worker_Photo_Response)
		{
			this.Put_Worker_Photo_Response = Put_Worker_Photo_Response;
		}
	}
}
