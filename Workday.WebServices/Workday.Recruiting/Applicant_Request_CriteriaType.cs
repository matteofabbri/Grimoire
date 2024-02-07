using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Recruiting
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Applicant_Request_CriteriaType : INotifyPropertyChanged
	{
		private WorkerObjectType worker_ReferenceField;

		private Former_WorkerObjectType former_Worker_ReferenceField;

		private string email_AddressField;

		private External_Field_and_Parameter_Initialization_ProviderObjectType[] field_And_Parameter_Criteria_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public WorkerObjectType Worker_Reference
		{
			get
			{
				return this.worker_ReferenceField;
			}
			set
			{
				this.worker_ReferenceField = value;
				this.RaisePropertyChanged("Worker_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Former_WorkerObjectType Former_Worker_Reference
		{
			get
			{
				return this.former_Worker_ReferenceField;
			}
			set
			{
				this.former_Worker_ReferenceField = value;
				this.RaisePropertyChanged("Former_Worker_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public string Email_Address
		{
			get
			{
				return this.email_AddressField;
			}
			set
			{
				this.email_AddressField = value;
				this.RaisePropertyChanged("Email_Address");
			}
		}

		[XmlArray(Order = 3), XmlArrayItem("Provider_Reference", IsNullable = false)]
		public External_Field_and_Parameter_Initialization_ProviderObjectType[] Field_And_Parameter_Criteria_Data
		{
			get
			{
				return this.field_And_Parameter_Criteria_DataField;
			}
			set
			{
				this.field_And_Parameter_Criteria_DataField = value;
				this.RaisePropertyChanged("Field_And_Parameter_Criteria_Data");
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
