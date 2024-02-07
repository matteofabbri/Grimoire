using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Import_Travel_Booking_RecordsInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Travel_Booking_Header_RequestType Travel_Booking_Header_Request;

		public Import_Travel_Booking_RecordsInput()
		{
		}

		public Import_Travel_Booking_RecordsInput(Workday_Common_HeaderType Workday_Common_Header, Travel_Booking_Header_RequestType Travel_Booking_Header_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Travel_Booking_Header_Request = Travel_Booking_Header_Request;
		}
	}
}
