using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_External_Disability_Self_Identification_RecordsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_External_Disability_Self_Identification_Records_ResponseType Get_External_Disability_Self_Identification_Records_Response;

		public Get_External_Disability_Self_Identification_RecordsOutput()
		{
		}

		public Get_External_Disability_Self_Identification_RecordsOutput(Get_External_Disability_Self_Identification_Records_ResponseType Get_External_Disability_Self_Identification_Records_Response)
		{
			this.Get_External_Disability_Self_Identification_Records_Response = Get_External_Disability_Self_Identification_Records_Response;
		}
	}
}
