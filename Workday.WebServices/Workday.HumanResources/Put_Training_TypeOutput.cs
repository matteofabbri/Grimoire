using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Training_TypeOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Training_Type_ResponseType Put_Training_Type_Response;

		public Put_Training_TypeOutput()
		{
		}

		public Put_Training_TypeOutput(Put_Training_Type_ResponseType Put_Training_Type_Response)
		{
			this.Put_Training_Type_Response = Put_Training_Type_Response;
		}
	}
}
