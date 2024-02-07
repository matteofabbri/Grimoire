using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.Payroll
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(TypeName = "Get_Payroll_Pre-Printed_Payslips_ResponseType", Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Get_Payroll_PrePrinted_Payslips_ResponseType : INotifyPropertyChanged
	{
		private Repository_DocumentObjectType[] request_ReferencesField;

		private Payroll_PrePrinted_Payslips_Request_CriteriaType[] request_CriteriaField;

		private Payroll_PrePrinted_Payslips_Response_GroupType[] response_GroupField;

		private Response_FilterType[] request_FilterField;

		private Response_ResultsType[] response_ResultsField;

		private Get_Payroll_PrePrinted_Payslips_Response_DataType[] response_DataField;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlArray(Order = 0), XmlArrayItem("Payroll_Pre-Printed_Payslips_Request_Reference", typeof(Repository_DocumentObjectType), IsNullable = false)]
		public Repository_DocumentObjectType[] Request_References
		{
			get
			{
				return this.request_ReferencesField;
			}
			set
			{
				this.request_ReferencesField = value;
				this.RaisePropertyChanged("Request_References");
			}
		}

		[XmlElement("Request_Criteria", Order = 1)]
		public Payroll_PrePrinted_Payslips_Request_CriteriaType[] Request_Criteria
		{
			get
			{
				return this.request_CriteriaField;
			}
			set
			{
				this.request_CriteriaField = value;
				this.RaisePropertyChanged("Request_Criteria");
			}
		}

		[XmlElement("Response_Group", Order = 2)]
		public Payroll_PrePrinted_Payslips_Response_GroupType[] Response_Group
		{
			get
			{
				return this.response_GroupField;
			}
			set
			{
				this.response_GroupField = value;
				this.RaisePropertyChanged("Response_Group");
			}
		}

		[XmlElement("Request_Filter", Order = 3)]
		public Response_FilterType[] Request_Filter
		{
			get
			{
				return this.request_FilterField;
			}
			set
			{
				this.request_FilterField = value;
				this.RaisePropertyChanged("Request_Filter");
			}
		}

		[XmlElement("Response_Results", Order = 4)]
		public Response_ResultsType[] Response_Results
		{
			get
			{
				return this.response_ResultsField;
			}
			set
			{
				this.response_ResultsField = value;
				this.RaisePropertyChanged("Response_Results");
			}
		}

		[XmlElement("Response_Data", Order = 5)]
		public Get_Payroll_PrePrinted_Payslips_Response_DataType[] Response_Data
		{
			get
			{
				return this.response_DataField;
			}
			set
			{
				this.response_DataField = value;
				this.RaisePropertyChanged("Response_Data");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public string version
		{
			get
			{
				return this.versionField;
			}
			set
			{
				this.versionField = value;
				this.RaisePropertyChanged("version");
			}
		}

		protected void RaisePropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged != null)
			{
				propertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
