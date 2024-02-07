using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Recruiting
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Edit_Job_Requisition_Additional_DataOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Edit_Job_Requisition_Additional_Data_ResponseType Edit_Job_Requisition_Additional_Data_Response;

		public Edit_Job_Requisition_Additional_DataOutput()
		{
		}

		public Edit_Job_Requisition_Additional_DataOutput(Edit_Job_Requisition_Additional_Data_ResponseType Edit_Job_Requisition_Additional_Data_Response)
		{
			this.Edit_Job_Requisition_Additional_Data_Response = Edit_Job_Requisition_Additional_Data_Response;
		}
	}
}
