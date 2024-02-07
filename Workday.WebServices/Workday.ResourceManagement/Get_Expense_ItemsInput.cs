using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Expense_ItemsInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Expense_Items_RequestType Get_Expense_Items_Request;

		public Get_Expense_ItemsInput()
		{
		}

		public Get_Expense_ItemsInput(Workday_Common_HeaderType Workday_Common_Header, Get_Expense_Items_RequestType Get_Expense_Items_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Expense_Items_Request = Get_Expense_Items_Request;
		}
	}
}
