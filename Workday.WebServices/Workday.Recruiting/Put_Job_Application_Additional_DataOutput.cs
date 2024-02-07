using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Recruiting
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Job_Application_Additional_DataOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Job_Application_Additional_Data_ResponseType Put_Job_Application_Additional_Data_Response;

		public Put_Job_Application_Additional_DataOutput()
		{
		}

		public Put_Job_Application_Additional_DataOutput(Put_Job_Application_Additional_Data_ResponseType Put_Job_Application_Additional_Data_Response)
		{
			this.Put_Job_Application_Additional_Data_Response = Put_Job_Application_Additional_Data_Response;
		}
	}
}
