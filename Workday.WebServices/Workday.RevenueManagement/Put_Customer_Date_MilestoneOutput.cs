using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Customer_Date_MilestoneOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Customer_Date_Milestone_ResponseType Put_Customer_Date_Milestone_Response;

		public Put_Customer_Date_MilestoneOutput()
		{
		}

		public Put_Customer_Date_MilestoneOutput(Put_Customer_Date_Milestone_ResponseType Put_Customer_Date_Milestone_Response)
		{
			this.Put_Customer_Date_Milestone_Response = Put_Customer_Date_Milestone_Response;
		}
	}
}
