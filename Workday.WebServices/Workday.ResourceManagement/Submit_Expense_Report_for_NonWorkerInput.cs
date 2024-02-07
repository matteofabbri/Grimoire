using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.Xml.Serialization;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Submit_Expense_Report_for_NonWorkerInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Name = "Submit_Expense_Report_for_Non-Worker_Request", Namespace = "urn:com.workday/bsvc", Order = 0), XmlElement("Submit_Expense_Report_for_Non-Worker_Request")]
		public Submit_Expense_Report_for_NonWorker_RequestType Submit_Expense_Report_for_NonWorker_Request;

		public Submit_Expense_Report_for_NonWorkerInput()
		{
		}

		public Submit_Expense_Report_for_NonWorkerInput(Workday_Common_HeaderType Workday_Common_Header, Submit_Expense_Report_for_NonWorker_RequestType Submit_Expense_Report_for_NonWorker_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Submit_Expense_Report_for_NonWorker_Request = Submit_Expense_Report_for_NonWorker_Request;
		}
	}
}
