using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Customer_Date_MilestonesInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Customer_Date_Milestones_RequestType Get_Customer_Date_Milestones_Request;

		public Get_Customer_Date_MilestonesInput()
		{
		}

		public Get_Customer_Date_MilestonesInput(Workday_Common_HeaderType Workday_Common_Header, Get_Customer_Date_Milestones_RequestType Get_Customer_Date_Milestones_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Customer_Date_Milestones_Request = Get_Customer_Date_Milestones_Request;
		}
	}
}
