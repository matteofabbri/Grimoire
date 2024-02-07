using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.SettlementServices
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Escheatable_Payment_Notification_DateOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Escheatable_Payment_Notification_Date_ResponseType Put_Escheatable_Payment_Notification_Date_Response;

		public Put_Escheatable_Payment_Notification_DateOutput()
		{
		}

		public Put_Escheatable_Payment_Notification_DateOutput(Put_Escheatable_Payment_Notification_Date_ResponseType Put_Escheatable_Payment_Notification_Date_Response)
		{
			this.Put_Escheatable_Payment_Notification_Date_Response = Put_Escheatable_Payment_Notification_Date_Response;
		}
	}
}
