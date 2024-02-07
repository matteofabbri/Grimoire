using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Compensation
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Period_Activity_Rate_MatricesInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Period_Activity_Rate_Matrices_RequestType Get_Period_Activity_Rate_Matrices_Request;

		public Get_Period_Activity_Rate_MatricesInput()
		{
		}

		public Get_Period_Activity_Rate_MatricesInput(Workday_Common_HeaderType Workday_Common_Header, Get_Period_Activity_Rate_Matrices_RequestType Get_Period_Activity_Rate_Matrices_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Period_Activity_Rate_Matrices_Request = Get_Period_Activity_Rate_Matrices_Request;
		}
	}
}
