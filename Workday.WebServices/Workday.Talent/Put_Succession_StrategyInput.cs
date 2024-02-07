using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Talent
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Succession_StrategyInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Succession_Strategy_RequestType Put_Succession_Strategy_Request;

		public Put_Succession_StrategyInput()
		{
		}

		public Put_Succession_StrategyInput(Workday_Common_HeaderType Workday_Common_Header, Put_Succession_Strategy_RequestType Put_Succession_Strategy_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Succession_Strategy_Request = Put_Succession_Strategy_Request;
		}
	}
}
