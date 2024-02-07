using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.Payroll
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Get_Payroll_Tax_Mappings_on_Location_ResponseType : INotifyPropertyChanged
	{
		private Payroll_Tax_Location_MappingObjectType[] request_ReferenceField;

		private Payroll_Tax_Mappings_on_Location_Request_CriteriaType[] request_CriteriaField;

		private Response_FilterType[] response_FilterField;

		private Response_ResultsType[] response_ResultsField;

		private Payroll_Tax_Mappings_on_Location_Response_DataType[] itemsField;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlArray(Order = 0), XmlArrayItem("Payroll_Tax_Location_Mapping_Reference", typeof(Payroll_Tax_Location_MappingObjectType), IsNullable = false)]
		public Payroll_Tax_Location_MappingObjectType[] Request_Reference
		{
			get
			{
				return this.request_ReferenceField;
			}
			set
			{
				this.request_ReferenceField = value;
				this.RaisePropertyChanged("Request_Reference");
			}
		}

		[XmlElement("Request_Criteria", Order = 1)]
		public Payroll_Tax_Mappings_on_Location_Request_CriteriaType[] Request_Criteria
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

		[XmlElement("Response_Filter", Order = 2)]
		public Response_FilterType[] Response_Filter
		{
			get
			{
				return this.response_FilterField;
			}
			set
			{
				this.response_FilterField = value;
				this.RaisePropertyChanged("Response_Filter");
			}
		}

		[XmlElement("Response_Results", Order = 3)]
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

		[XmlElement("Response_Data", Order = 4)]
		public Payroll_Tax_Mappings_on_Location_Response_DataType[] Items
		{
			get
			{
				return this.itemsField;
			}
			set
			{
				this.itemsField = value;
				this.RaisePropertyChanged("Items");
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
