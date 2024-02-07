using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Committee_Classification_GroupsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Committee_Classification_Groups_ResponseType Get_Committee_Classification_Groups_Response;

		public Get_Committee_Classification_GroupsOutput()
		{
		}

		public Get_Committee_Classification_GroupsOutput(Get_Committee_Classification_Groups_ResponseType Get_Committee_Classification_Groups_Response)
		{
			this.Get_Committee_Classification_Groups_Response = Get_Committee_Classification_Groups_Response;
		}
	}
}
