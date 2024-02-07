using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Import_Position_BudgetInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Import_Position_Budget_RequestType Import_Position_Budget_Request;

		public Import_Position_BudgetInput()
		{
		}

		public Import_Position_BudgetInput(Workday_Common_HeaderType Workday_Common_Header, Import_Position_Budget_RequestType Import_Position_Budget_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Import_Position_Budget_Request = Import_Position_Budget_Request;
		}
	}
}
