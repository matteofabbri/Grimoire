using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Import_Travel_ProfilesInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Worker_Travel_Profile_Header__HV__RequestType Worker_Travel_Profile_Header__HV__Request;

		public Import_Travel_ProfilesInput()
		{
		}

		public Import_Travel_ProfilesInput(Workday_Common_HeaderType Workday_Common_Header, Worker_Travel_Profile_Header__HV__RequestType Worker_Travel_Profile_Header__HV__Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Worker_Travel_Profile_Header__HV__Request = Worker_Travel_Profile_Header__HV__Request;
		}
	}
}
