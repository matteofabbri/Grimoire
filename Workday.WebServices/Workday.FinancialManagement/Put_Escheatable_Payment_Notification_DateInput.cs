using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Escheatable_Payment_Notification_DateInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Escheatable_Payment_Notification_Date_RequestType Put_Escheatable_Payment_Notification_Date_Request;

		public Put_Escheatable_Payment_Notification_DateInput()
		{
		}

		public Put_Escheatable_Payment_Notification_DateInput(Workday_Common_HeaderType Workday_Common_Header, Put_Escheatable_Payment_Notification_Date_RequestType Put_Escheatable_Payment_Notification_Date_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Escheatable_Payment_Notification_Date_Request = Put_Escheatable_Payment_Notification_Date_Request;
		}
	}
}
