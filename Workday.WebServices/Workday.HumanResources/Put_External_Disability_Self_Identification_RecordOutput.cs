using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_External_Disability_Self_Identification_RecordOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_External_Disability_Self_Identification_Record_ResponseType Put_External_Disability_Self_Identification_Record_Response;

		public Put_External_Disability_Self_Identification_RecordOutput()
		{
		}

		public Put_External_Disability_Self_Identification_RecordOutput(Put_External_Disability_Self_Identification_Record_ResponseType Put_External_Disability_Self_Identification_Record_Response)
		{
			this.Put_External_Disability_Self_Identification_Record_Response = Put_External_Disability_Self_Identification_Record_Response;
		}
	}
}
