using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Payroll
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Canadian_Record_of_Employment_DataOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Canadian_Record_of_Employment_Data_ResponseType Get_Canadian_Record_of_Employment_Data_Response;

		public Get_Canadian_Record_of_Employment_DataOutput()
		{
		}

		public Get_Canadian_Record_of_Employment_DataOutput(Get_Canadian_Record_of_Employment_Data_ResponseType Get_Canadian_Record_of_Employment_Data_Response)
		{
			this.Get_Canadian_Record_of_Employment_Data_Response = Get_Canadian_Record_of_Employment_Data_Response;
		}
	}
}
