using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Resource_CategoryOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Resource_Category_ResponseType Put_Resource_Category_Response;

		public Put_Resource_CategoryOutput()
		{
		}

		public Put_Resource_CategoryOutput(Put_Resource_Category_ResponseType Put_Resource_Category_Response)
		{
			this.Put_Resource_Category_Response = Put_Resource_Category_Response;
		}
	}
}
