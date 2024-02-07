using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Payroll
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Payroll_Payee_Tax_Location_Mapping_DataType : INotifyPropertyChanged
	{
		private string payroll_Payee_Tax_Location_Mapping_IDField;

		private WorkerObjectType worker_ReferenceField;

		private DateTime effective_DateField;

		private CompanyObjectType company_ReferenceField;

		private bool inactive_Tax_Location_MappingField;

		private bool inactive_Tax_Location_MappingFieldSpecified;

		private Payroll_State_AuthorityObjectType[] inactivate_State_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Payroll_Payee_Tax_Location_Mapping_ID
		{
			get
			{
				return this.payroll_Payee_Tax_Location_Mapping_IDField;
			}
			set
			{
				this.payroll_Payee_Tax_Location_Mapping_IDField = value;
				this.RaisePropertyChanged("Payroll_Payee_Tax_Location_Mapping_ID");
			}
		}

		[XmlElement(Order = 1)]
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

		[XmlElement(DataType = "date", Order = 2)]
		public DateTime Effective_Date
		{
			get
			{
				return this.effective_DateField;
			}
			set
			{
				this.effective_DateField = value;
				this.RaisePropertyChanged("Effective_Date");
			}
		}

		[XmlElement(Order = 3)]
		public CompanyObjectType Company_Reference
		{
			get
			{
				return this.company_ReferenceField;
			}
			set
			{
				this.company_ReferenceField = value;
				this.RaisePropertyChanged("Company_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public bool Inactive_Tax_Location_Mapping
		{
			get
			{
				return this.inactive_Tax_Location_MappingField;
			}
			set
			{
				this.inactive_Tax_Location_MappingField = value;
				this.RaisePropertyChanged("Inactive_Tax_Location_Mapping");
			}
		}

		[XmlIgnore]
		public bool Inactive_Tax_Location_MappingSpecified
		{
			get
			{
				return this.inactive_Tax_Location_MappingFieldSpecified;
			}
			set
			{
				this.inactive_Tax_Location_MappingFieldSpecified = value;
				this.RaisePropertyChanged("Inactive_Tax_Location_MappingSpecified");
			}
		}

		[XmlElement("Inactivate_State_Reference", Order = 5)]
		public Payroll_State_AuthorityObjectType[] Inactivate_State_Reference
		{
			get
			{
				return this.inactivate_State_ReferenceField;
			}
			set
			{
				this.inactivate_State_ReferenceField = value;
				this.RaisePropertyChanged("Inactivate_State_Reference");
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
