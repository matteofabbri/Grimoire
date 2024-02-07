using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Payroll
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Canadian_Record_of_Employment_DataInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Canadian_Record_of_Employment_Data_RequestType Put_Canadian_Record_of_Employment_Data_Request;

		public Put_Canadian_Record_of_Employment_DataInput()
		{
		}

		public Put_Canadian_Record_of_Employment_DataInput(Workday_Common_HeaderType Workday_Common_Header, Put_Canadian_Record_of_Employment_Data_RequestType Put_Canadian_Record_of_Employment_Data_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Canadian_Record_of_Employment_Data_Request = Put_Canadian_Record_of_Employment_Data_Request;
		}
	}
}
