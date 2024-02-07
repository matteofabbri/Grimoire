using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Resource_CategoryInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Resource_Category_RequestType Put_Resource_Category_Request;

		public Put_Resource_CategoryInput()
		{
		}

		public Put_Resource_CategoryInput(Workday_Common_HeaderType Workday_Common_Header, Put_Resource_Category_RequestType Put_Resource_Category_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Resource_Category_Request = Put_Resource_Category_Request;
		}
	}
}
