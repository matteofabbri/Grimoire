using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Talent
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_SubspecialtiesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Subspecialties_ResponseType Get_Subspecialties_Response;

		public Get_SubspecialtiesOutput()
		{
		}

		public Get_SubspecialtiesOutput(Get_Subspecialties_ResponseType Get_Subspecialties_Response)
		{
			this.Get_Subspecialties_Response = Get_Subspecialties_Response;
		}
	}
}
