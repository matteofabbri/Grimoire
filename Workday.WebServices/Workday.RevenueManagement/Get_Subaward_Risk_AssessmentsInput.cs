using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Subaward_Risk_AssessmentsInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Subaward_Risk_Assessments_RequestType Get_Subaward_Risk_Assessments_Request;

		public Get_Subaward_Risk_AssessmentsInput()
		{
		}

		public Get_Subaward_Risk_AssessmentsInput(Workday_Common_HeaderType Workday_Common_Header, Get_Subaward_Risk_Assessments_RequestType Get_Subaward_Risk_Assessments_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Subaward_Risk_Assessments_Request = Get_Subaward_Risk_Assessments_Request;
		}
	}
}
