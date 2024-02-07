using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.Xml.Serialization;

namespace Workday.CashManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Investment_Pool_Catchup_Payout_CriteriaOutput
	{
		[MessageBodyMember(Name = "Put_Investment_Pool_Catch-up_Payout_Criteria_Response", Namespace = "urn:com.workday/bsvc", Order = 0), XmlElement("Put_Investment_Pool_Catch-up_Payout_Criteria_Response")]
		public Put_Investment_Pool_Catchup_Payout_Criteria_ResponseType Put_Investment_Pool_Catchup_Payout_Criteria_Response;

		public Put_Investment_Pool_Catchup_Payout_CriteriaOutput()
		{
		}

		public Put_Investment_Pool_Catchup_Payout_CriteriaOutput(Put_Investment_Pool_Catchup_Payout_Criteria_ResponseType Put_Investment_Pool_Catchup_Payout_Criteria_Response)
		{
			this.Put_Investment_Pool_Catchup_Payout_Criteria_Response = Put_Investment_Pool_Catchup_Payout_Criteria_Response;
		}
	}
}
