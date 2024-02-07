using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Alternate_Account_Set_MappingsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Alternate_Account_Set_Mappings_ResponseType Get_Alternate_Account_Set_Mappings_Response;

		public Get_Alternate_Account_Set_MappingsOutput()
		{
		}

		public Get_Alternate_Account_Set_MappingsOutput(Get_Alternate_Account_Set_Mappings_ResponseType Get_Alternate_Account_Set_Mappings_Response)
		{
			this.Get_Alternate_Account_Set_Mappings_Response = Get_Alternate_Account_Set_Mappings_Response;
		}
	}
}
