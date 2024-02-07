using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Project_AssetOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Project_Asset_ResponseType Put_Project_Asset_Response;

		public Put_Project_AssetOutput()
		{
		}

		public Put_Project_AssetOutput(Put_Project_Asset_ResponseType Put_Project_Asset_Response)
		{
			this.Put_Project_Asset_Response = Put_Project_Asset_Response;
		}
	}
}
