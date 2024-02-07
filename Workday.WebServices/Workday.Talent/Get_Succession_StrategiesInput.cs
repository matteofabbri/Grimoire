using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Talent
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Succession_StrategiesInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Succession_Strategies_RequestType Get_Succession_Strategies_Request;

		public Get_Succession_StrategiesInput()
		{
		}

		public Get_Succession_StrategiesInput(Workday_Common_HeaderType Workday_Common_Header, Get_Succession_Strategies_RequestType Get_Succession_Strategies_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Succession_Strategies_Request = Get_Succession_Strategies_Request;
		}
	}
}
