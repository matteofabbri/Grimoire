using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Recruiting
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Recruiting_Agency_Additional_DataInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Recruiting_Agency_Additional_Data_RequestType Put_Recruiting_Agency_Additional_Data_Request;

		public Put_Recruiting_Agency_Additional_DataInput()
		{
		}

		public Put_Recruiting_Agency_Additional_DataInput(Workday_Common_HeaderType Workday_Common_Header, Put_Recruiting_Agency_Additional_Data_RequestType Put_Recruiting_Agency_Additional_Data_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Recruiting_Agency_Additional_Data_Request = Put_Recruiting_Agency_Additional_Data_Request;
		}
	}
}
