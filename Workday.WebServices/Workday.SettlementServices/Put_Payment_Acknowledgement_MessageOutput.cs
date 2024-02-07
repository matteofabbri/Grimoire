using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.SettlementServices
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Payment_Acknowledgement_MessageOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Payment_Acknowledgement_Message_ResponseType Put_Payment_Acknowledgement_Message_Response;

		public Put_Payment_Acknowledgement_MessageOutput()
		{
		}

		public Put_Payment_Acknowledgement_MessageOutput(Put_Payment_Acknowledgement_Message_ResponseType Put_Payment_Acknowledgement_Message_Response)
		{
			this.Put_Payment_Acknowledgement_Message_Response = Put_Payment_Acknowledgement_Message_Response;
		}
	}
}
