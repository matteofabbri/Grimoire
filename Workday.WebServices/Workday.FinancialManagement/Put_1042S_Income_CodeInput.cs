using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.Xml.Serialization;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_1042S_Income_CodeInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Name = "Put_1042-S_Income_Code_Request", Namespace = "urn:com.workday/bsvc", Order = 0), XmlElement("Put_1042-S_Income_Code_Request")]
		public Put_1042S_Income_Code_RequestType Put_1042S_Income_Code_Request;

		public Put_1042S_Income_CodeInput()
		{
		}

		public Put_1042S_Income_CodeInput(Workday_Common_HeaderType Workday_Common_Header, Put_1042S_Income_Code_RequestType Put_1042S_Income_Code_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_1042S_Income_Code_Request = Put_1042S_Income_Code_Request;
		}
	}
}
