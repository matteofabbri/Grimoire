using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.Xml.Serialization;

namespace Workday.BenefitsAdministration
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_ACA_1095C_Forms_DataInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Name = "Get_ACA_1095-C_Forms_Data_Request", Namespace = "urn:com.workday/bsvc", Order = 0), XmlElement("Get_ACA_1095-C_Forms_Data_Request")]
		public Get_ACA_1095C_Forms_Data_RequestType Get_ACA_1095C_Forms_Data_Request;

		public Get_ACA_1095C_Forms_DataInput()
		{
		}

		public Get_ACA_1095C_Forms_DataInput(Workday_Common_HeaderType Workday_Common_Header, Get_ACA_1095C_Forms_Data_RequestType Get_ACA_1095C_Forms_Data_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_ACA_1095C_Forms_Data_Request = Get_ACA_1095C_Forms_Data_Request;
		}
	}
}
