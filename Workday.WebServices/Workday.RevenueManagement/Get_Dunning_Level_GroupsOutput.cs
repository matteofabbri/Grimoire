using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Dunning_Level_GroupsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Dunning_Level_Groups_ResponseType Get_Dunning_Level_Groups_Response;

		public Get_Dunning_Level_GroupsOutput()
		{
		}

		public Get_Dunning_Level_GroupsOutput(Get_Dunning_Level_Groups_ResponseType Get_Dunning_Level_Groups_Response)
		{
			this.Get_Dunning_Level_Groups_Response = Get_Dunning_Level_Groups_Response;
		}
	}
}
