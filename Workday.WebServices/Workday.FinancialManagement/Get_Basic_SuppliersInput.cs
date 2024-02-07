using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Basic_SuppliersInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Basic_Suppliers_RequestType Get_Basic_Suppliers_Request;

		public Get_Basic_SuppliersInput()
		{
		}

		public Get_Basic_SuppliersInput(Workday_Common_HeaderType Workday_Common_Header, Get_Basic_Suppliers_RequestType Get_Basic_Suppliers_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Basic_Suppliers_Request = Get_Basic_Suppliers_Request;
		}
	}
}
