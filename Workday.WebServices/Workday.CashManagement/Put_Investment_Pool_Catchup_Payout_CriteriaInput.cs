using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.Xml.Serialization;

namespace Workday.CashManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Investment_Pool_Catchup_Payout_CriteriaInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Name = "Put_Investment_Pool_Catch-up_Payout_Criteria_Request", Namespace = "urn:com.workday/bsvc", Order = 0), XmlElement("Put_Investment_Pool_Catch-up_Payout_Criteria_Request")]
		public Put_Investment_Pool_Catchup_Payout_Criteria_RequestType Put_Investment_Pool_Catchup_Payout_Criteria_Request;

		public Put_Investment_Pool_Catchup_Payout_CriteriaInput()
		{
		}

		public Put_Investment_Pool_Catchup_Payout_CriteriaInput(Workday_Common_HeaderType Workday_Common_Header, Put_Investment_Pool_Catchup_Payout_Criteria_RequestType Put_Investment_Pool_Catchup_Payout_Criteria_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Investment_Pool_Catchup_Payout_Criteria_Request = Put_Investment_Pool_Catchup_Payout_Criteria_Request;
		}
	}
}
