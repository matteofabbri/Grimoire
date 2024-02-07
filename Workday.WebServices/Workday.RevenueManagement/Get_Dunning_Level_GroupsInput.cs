using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Dunning_Level_GroupsInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Dunning_Level_Groups_RequestType Get_Dunning_Level_Groups_Request;

		public Get_Dunning_Level_GroupsInput()
		{
		}

		public Get_Dunning_Level_GroupsInput(Workday_Common_HeaderType Workday_Common_Header, Get_Dunning_Level_Groups_RequestType Get_Dunning_Level_Groups_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Dunning_Level_Groups_Request = Get_Dunning_Level_Groups_Request;
		}
	}
}
