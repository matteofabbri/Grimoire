using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Statistic_DefinitionsInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Statistic_Definitions_RequestType Get_Statistic_Definitions_Request;

		public Get_Statistic_DefinitionsInput()
		{
		}

		public Get_Statistic_DefinitionsInput(Workday_Common_HeaderType Workday_Common_Header, Get_Statistic_Definitions_RequestType Get_Statistic_Definitions_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Statistic_Definitions_Request = Get_Statistic_Definitions_Request;
		}
	}
}
