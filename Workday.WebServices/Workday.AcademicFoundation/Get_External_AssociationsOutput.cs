using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.AcademicFoundation
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_External_AssociationsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_External_Associations_ResponseType Get_External_Associations_Response;

		public Get_External_AssociationsOutput()
		{
		}

		public Get_External_AssociationsOutput(Get_External_Associations_ResponseType Get_External_Associations_Response)
		{
			this.Get_External_Associations_Response = Get_External_Associations_Response;
		}
	}
}
