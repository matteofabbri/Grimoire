using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Compensation
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Period_Activity_Rate_MatrixInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Period_Activity_Rate_Matrix_RequestType Put_Period_Activity_Rate_Matrix_Request;

		public Put_Period_Activity_Rate_MatrixInput()
		{
		}

		public Put_Period_Activity_Rate_MatrixInput(Workday_Common_HeaderType Workday_Common_Header, Put_Period_Activity_Rate_Matrix_RequestType Put_Period_Activity_Rate_Matrix_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Period_Activity_Rate_Matrix_Request = Put_Period_Activity_Rate_Matrix_Request;
		}
	}
}
