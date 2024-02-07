using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Alternate_Account_Set_MappingsInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Alternate_Account_Set_Mappings_RequestType Get_Alternate_Account_Set_Mappings_Request;

		public Get_Alternate_Account_Set_MappingsInput()
		{
		}

		public Get_Alternate_Account_Set_MappingsInput(Workday_Common_HeaderType Workday_Common_Header, Get_Alternate_Account_Set_Mappings_RequestType Get_Alternate_Account_Set_Mappings_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Alternate_Account_Set_Mappings_Request = Get_Alternate_Account_Set_Mappings_Request;
		}
	}
}
