using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Procurement_Mass_CloseOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Procurement_Mass_Close_ResponseType Get_Procurement_Mass_Close_Response;

		public Get_Procurement_Mass_CloseOutput()
		{
		}

		public Get_Procurement_Mass_CloseOutput(Get_Procurement_Mass_Close_ResponseType Get_Procurement_Mass_Close_Response)
		{
			this.Get_Procurement_Mass_Close_Response = Get_Procurement_Mass_Close_Response;
		}
	}
}
