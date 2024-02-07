using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_EthnicitiesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Ethnicities_ResponseType Get_Ethnicities_Response;

		public Get_EthnicitiesOutput()
		{
		}

		public Get_EthnicitiesOutput(Get_Ethnicities_ResponseType Get_Ethnicities_Response)
		{
			this.Get_Ethnicities_Response = Get_Ethnicities_Response;
		}
	}
}
