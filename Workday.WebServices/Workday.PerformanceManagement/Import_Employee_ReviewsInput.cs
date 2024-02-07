using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.PerformanceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Import_Employee_ReviewsInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Import_Employee_Reviews_RequestType Import_Employee_Reviews_Request;

		public Import_Employee_ReviewsInput()
		{
		}

		public Import_Employee_ReviewsInput(Workday_Common_HeaderType Workday_Common_Header, Import_Employee_Reviews_RequestType Import_Employee_Reviews_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Import_Employee_Reviews_Request = Import_Employee_Reviews_Request;
		}
	}
}
