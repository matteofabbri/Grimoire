using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Travel_Booking_FilesInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Travel_Booking_Files_RequestType Get_Travel_Booking_Files_Request;

		public Get_Travel_Booking_FilesInput()
		{
		}

		public Get_Travel_Booking_FilesInput(Workday_Common_HeaderType Workday_Common_Header, Get_Travel_Booking_Files_RequestType Get_Travel_Booking_Files_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Travel_Booking_Files_Request = Get_Travel_Booking_Files_Request;
		}
	}
}
