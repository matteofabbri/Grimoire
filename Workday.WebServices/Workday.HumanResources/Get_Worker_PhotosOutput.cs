using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Worker_PhotosOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Worker_Photos_ResponseType Get_Worker_Photos_Response;

		public Get_Worker_PhotosOutput()
		{
		}

		public Get_Worker_PhotosOutput(Get_Worker_Photos_ResponseType Get_Worker_Photos_Response)
		{
			this.Get_Worker_Photos_Response = Get_Worker_Photos_Response;
		}
	}
}
