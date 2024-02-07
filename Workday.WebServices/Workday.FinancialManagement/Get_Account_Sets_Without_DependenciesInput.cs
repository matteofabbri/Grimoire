using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Account_Sets_Without_DependenciesInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Account_Sets_without_Dependencies_RequestType Get_Account_Sets_without_Dependencies_Request;

		public Get_Account_Sets_Without_DependenciesInput()
		{
		}

		public Get_Account_Sets_Without_DependenciesInput(Workday_Common_HeaderType Workday_Common_Header, Get_Account_Sets_without_Dependencies_RequestType Get_Account_Sets_without_Dependencies_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Account_Sets_without_Dependencies_Request = Get_Account_Sets_without_Dependencies_Request;
		}
	}
}
