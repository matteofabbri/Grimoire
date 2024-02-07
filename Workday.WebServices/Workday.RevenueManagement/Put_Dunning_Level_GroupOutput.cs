using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Dunning_Level_GroupOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Dunning_Level_Group_ResponseType Put_Dunning_Level_Group_Response;

		public Put_Dunning_Level_GroupOutput()
		{
		}

		public Put_Dunning_Level_GroupOutput(Put_Dunning_Level_Group_ResponseType Put_Dunning_Level_Group_Response)
		{
			this.Put_Dunning_Level_Group_Response = Put_Dunning_Level_Group_Response;
		}
	}
}
