using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Import_BudgetInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Import_Budget_High_Volume_RequestType Import_Budget_High_Volume_Request;

		public Import_BudgetInput()
		{
		}

		public Import_BudgetInput(Workday_Common_HeaderType Workday_Common_Header, Import_Budget_High_Volume_RequestType Import_Budget_High_Volume_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Import_Budget_High_Volume_Request = Import_Budget_High_Volume_Request;
		}
	}
}
