using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Difficulty_to_FillInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Difficulty_to_Fill_RequestType Get_Difficulty_to_Fill_Request;

		public Get_Difficulty_to_FillInput()
		{
		}

		public Get_Difficulty_to_FillInput(Workday_Common_HeaderType Workday_Common_Header, Get_Difficulty_to_Fill_RequestType Get_Difficulty_to_Fill_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Difficulty_to_Fill_Request = Get_Difficulty_to_Fill_Request;
		}
	}
}
