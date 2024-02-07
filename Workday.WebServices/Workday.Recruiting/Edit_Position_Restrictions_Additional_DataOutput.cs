using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Recruiting
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Edit_Position_Restrictions_Additional_DataOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Edit_Position_Restrictions_Additional_Data_ResponseType Edit_Position_Restrictions_Additional_Data_Response;

		public Edit_Position_Restrictions_Additional_DataOutput()
		{
		}

		public Edit_Position_Restrictions_Additional_DataOutput(Edit_Position_Restrictions_Additional_Data_ResponseType Edit_Position_Restrictions_Additional_Data_Response)
		{
			this.Edit_Position_Restrictions_Additional_Data_Response = Edit_Position_Restrictions_Additional_Data_Response;
		}
	}
}
