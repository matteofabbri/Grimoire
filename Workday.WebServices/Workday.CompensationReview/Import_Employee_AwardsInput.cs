using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.CompensationReview
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Import_Employee_AwardsInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Import_Employee_Awards_RequestType Import_Employee_Awards_Request;

		public Import_Employee_AwardsInput()
		{
		}

		public Import_Employee_AwardsInput(Workday_Common_HeaderType Workday_Common_Header, Import_Employee_Awards_RequestType Import_Employee_Awards_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Import_Employee_Awards_Request = Import_Employee_Awards_Request;
		}
	}
}
