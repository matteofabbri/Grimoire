using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Committee_ClassificationOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Committee_Classification_ResponseType Put_Committee_Classification_Response;

		public Put_Committee_ClassificationOutput()
		{
		}

		public Put_Committee_ClassificationOutput(Put_Committee_Classification_ResponseType Put_Committee_Classification_Response)
		{
			this.Put_Committee_Classification_Response = Put_Committee_Classification_Response;
		}
	}
}
