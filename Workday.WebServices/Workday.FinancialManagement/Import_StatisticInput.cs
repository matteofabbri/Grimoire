using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Import_StatisticInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Import_Statistic_RequestType Import_Statistic_Request;

		public Import_StatisticInput()
		{
		}

		public Import_StatisticInput(Workday_Common_HeaderType Workday_Common_Header, Import_Statistic_RequestType Import_Statistic_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Import_Statistic_Request = Import_Statistic_Request;
		}
	}
}
