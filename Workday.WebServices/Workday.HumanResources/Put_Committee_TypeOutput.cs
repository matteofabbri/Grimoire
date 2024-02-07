using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Committee_TypeOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Committee_Type_ResponseType Put_Committee_Type_Response;

		public Put_Committee_TypeOutput()
		{
		}

		public Put_Committee_TypeOutput(Put_Committee_Type_ResponseType Put_Committee_Type_Response)
		{
			this.Put_Committee_Type_Response = Put_Committee_Type_Response;
		}
	}
}
