using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Payroll
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Canadian_Record_of_Employment_DataOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Canadian_Record_of_Employment_Data_ResponseType Put_Canadian_Record_of_Employment_Data_Response;

		public Put_Canadian_Record_of_Employment_DataOutput()
		{
		}

		public Put_Canadian_Record_of_Employment_DataOutput(Put_Canadian_Record_of_Employment_Data_ResponseType Put_Canadian_Record_of_Employment_Data_Response)
		{
			this.Put_Canadian_Record_of_Employment_Data_Response = Put_Canadian_Record_of_Employment_Data_Response;
		}
	}
}
