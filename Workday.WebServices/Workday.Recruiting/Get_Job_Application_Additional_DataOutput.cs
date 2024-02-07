using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Recruiting
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Job_Application_Additional_DataOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Job_Application_Additional_Data_ResponseType Get_Job_Application_Additional_Data_Response;

		public Get_Job_Application_Additional_DataOutput()
		{
		}

		public Get_Job_Application_Additional_DataOutput(Get_Job_Application_Additional_Data_ResponseType Get_Job_Application_Additional_Data_Response)
		{
			this.Get_Job_Application_Additional_Data_Response = Get_Job_Application_Additional_Data_Response;
		}
	}
}
