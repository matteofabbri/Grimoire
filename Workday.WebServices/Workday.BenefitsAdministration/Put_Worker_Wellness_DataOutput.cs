using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.BenefitsAdministration
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Worker_Wellness_DataOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Worker_Wellness_Data_ResponseType Put_Worker_Wellness_Data_Response;

		public Put_Worker_Wellness_DataOutput()
		{
		}

		public Put_Worker_Wellness_DataOutput(Put_Worker_Wellness_Data_ResponseType Put_Worker_Wellness_Data_Response)
		{
			this.Put_Worker_Wellness_Data_Response = Put_Worker_Wellness_Data_Response;
		}
	}
}
