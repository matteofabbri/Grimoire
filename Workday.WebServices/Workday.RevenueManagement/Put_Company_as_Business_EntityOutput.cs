using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Company_as_Business_EntityOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Company_as_Business_Entity_ResponseType Put_Company_as_Business_Entity_Response;

		public Put_Company_as_Business_EntityOutput()
		{
		}

		public Put_Company_as_Business_EntityOutput(Put_Company_as_Business_Entity_ResponseType Put_Company_as_Business_Entity_Response)
		{
			this.Put_Company_as_Business_Entity_Response = Put_Company_as_Business_Entity_Response;
		}
	}
}
