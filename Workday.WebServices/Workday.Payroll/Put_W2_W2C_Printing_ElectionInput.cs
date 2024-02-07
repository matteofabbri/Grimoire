using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.Xml.Serialization;

namespace Workday.Payroll
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_W2_W2C_Printing_ElectionInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Name = "Put_W-2_W-2C_Printing_Election_Request", Namespace = "urn:com.workday/bsvc", Order = 0), XmlElement("Put_W-2_W-2C_Printing_Election_Request")]
		public Put_W2_W2C_Printing_Election_RequestType Put_W2_W2C_Printing_Election_Request;

		public Put_W2_W2C_Printing_ElectionInput()
		{
		}

		public Put_W2_W2C_Printing_ElectionInput(Workday_Common_HeaderType Workday_Common_Header, Put_W2_W2C_Printing_Election_RequestType Put_W2_W2C_Printing_Election_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_W2_W2C_Printing_Election_Request = Put_W2_W2C_Printing_Election_Request;
		}
	}
}
