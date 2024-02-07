using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Alternate_Account_Set_MappingOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Alternate_Account_Set_Mapping_ResponseType Put_Alternate_Account_Set_Mapping_Response;

		public Put_Alternate_Account_Set_MappingOutput()
		{
		}

		public Put_Alternate_Account_Set_MappingOutput(Put_Alternate_Account_Set_Mapping_ResponseType Put_Alternate_Account_Set_Mapping_Response)
		{
			this.Put_Alternate_Account_Set_Mapping_Response = Put_Alternate_Account_Set_Mapping_Response;
		}
	}
}
