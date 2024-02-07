using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.Xml.Serialization;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_1042S_Income_CodeOutput
	{
		[MessageBodyMember(Name = "Put_1042-S_Income_Code_Response", Namespace = "urn:com.workday/bsvc", Order = 0), XmlElement("Put_1042-S_Income_Code_Response")]
		public Put_1042S_Income_Code_ResponseType Put_1042S_Income_Code_Response;

		public Put_1042S_Income_CodeOutput()
		{
		}

		public Put_1042S_Income_CodeOutput(Put_1042S_Income_Code_ResponseType Put_1042S_Income_Code_Response)
		{
			this.Put_1042S_Income_Code_Response = Put_1042S_Income_Code_Response;
		}
	}
}
