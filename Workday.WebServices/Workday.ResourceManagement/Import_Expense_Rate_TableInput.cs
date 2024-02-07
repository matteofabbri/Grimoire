using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Import_Expense_Rate_TableInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Expense_Rate_Table_Header__HV__RequestType Expense_Rate_Table_Header__HV__Request;

		public Import_Expense_Rate_TableInput()
		{
		}

		public Import_Expense_Rate_TableInput(Workday_Common_HeaderType Workday_Common_Header, Expense_Rate_Table_Header__HV__RequestType Expense_Rate_Table_Header__HV__Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Expense_Rate_Table_Header__HV__Request = Expense_Rate_Table_Header__HV__Request;
		}
	}
}
