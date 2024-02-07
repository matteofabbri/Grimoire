using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Job_CategoryOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Job_Category_ResponseType Put_Job_Category_Response;

		public Put_Job_CategoryOutput()
		{
		}

		public Put_Job_CategoryOutput(Put_Job_Category_ResponseType Put_Job_Category_Response)
		{
			this.Put_Job_Category_Response = Put_Job_Category_Response;
		}
	}
}
