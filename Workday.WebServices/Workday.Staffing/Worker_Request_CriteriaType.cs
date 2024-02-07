using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Staffing
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Worker_Request_CriteriaType : INotifyPropertyChanged
	{
		private Transaction_Log_CriteriaType[] transaction_Log_Criteria_DataField;

		private OrganizationObjectType[] organization_ReferenceField;

		private CountryObjectType[] country_ReferenceField;

		private bool include_Subordinate_OrganizationsField;

		private bool include_Subordinate_OrganizationsFieldSpecified;

		private Position_ElementObjectType[] position_ReferenceField;

		private Transaction_LogObjectType event_ReferenceField;

		private Benefit_PlanObjectType[] benefit_Plan_ReferenceField;

		private External_Field_and_Parameter_Initialization_ProviderObjectType[] field_And_Parameter_Criteria_DataField;

		private Worker_by_National_ID_Request_CriteriaType[] national_ID_Criteria_DataField;

		private bool exclude_Inactive_WorkersField;

		private bool exclude_Inactive_WorkersFieldSpecified;

		private bool exclude_EmployeesField;

		private bool exclude_EmployeesFieldSpecified;

		private bool exclude_Contingent_WorkersField;

		private bool exclude_Contingent_WorkersFieldSpecified;

		private Eligibility_Criteria_DataType[] eligibility_Criteria_DataField;

		private Universal_IdentifierObjectType[] universal_ID_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Transaction_Log_Criteria_Data", Order = 0)]
		public Transaction_Log_CriteriaType[] Transaction_Log_Criteria_Data
		{
			get
			{
				return this.transaction_Log_Criteria_DataField;
			}
			set
			{
				this.transaction_Log_Criteria_DataField = value;
				this.RaisePropertyChanged("Transaction_Log_Criteria_Data");
			}
		}

		[XmlElement("Organization_Reference", Order = 1)]
		public OrganizationObjectType[] Organization_Reference
		{
			get
			{
				return this.organization_ReferenceField;
			}
			set
			{
				this.organization_ReferenceField = value;
				this.RaisePropertyChanged("Organization_Reference");
			}
		}

		[XmlElement("Country_Reference", Order = 2)]
		public CountryObjectType[] Country_Reference
		{
			get
			{
				return this.country_ReferenceField;
			}
			set
			{
				this.country_ReferenceField = value;
				this.RaisePropertyChanged("Country_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public bool Include_Subordinate_Organizations
		{
			get
			{
				return this.include_Subordinate_OrganizationsField;
			}
			set
			{
				this.include_Subordinate_OrganizationsField = value;
				this.RaisePropertyChanged("Include_Subordinate_Organizations");
			}
		}

		[XmlIgnore]
		public bool Include_Subordinate_OrganizationsSpecified
		{
			get
			{
				return this.include_Subordinate_OrganizationsFieldSpecified;
			}
			set
			{
				this.include_Subordinate_OrganizationsFieldSpecified = value;
				this.RaisePropertyChanged("Include_Subordinate_OrganizationsSpecified");
			}
		}

		[XmlElement("Position_Reference", Order = 4)]
		public Position_ElementObjectType[] Position_Reference
		{
			get
			{
				return this.position_ReferenceField;
			}
			set
			{
				this.position_ReferenceField = value;
				this.RaisePropertyChanged("Position_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public Transaction_LogObjectType Event_Reference
		{
			get
			{
				return this.event_ReferenceField;
			}
			set
			{
				this.event_ReferenceField = value;
				this.RaisePropertyChanged("Event_Reference");
			}
		}

		[XmlElement("Benefit_Plan_Reference", Order = 6)]
		public Benefit_PlanObjectType[] Benefit_Plan_Reference
		{
			get
			{
				return this.benefit_Plan_ReferenceField;
			}
			set
			{
				this.benefit_Plan_ReferenceField = value;
				this.RaisePropertyChanged("Benefit_Plan_Reference");
			}
		}

		[XmlArray(Order = 7), XmlArrayItem("Provider_Reference", IsNullable = false)]
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

		[XmlElement("National_ID_Criteria_Data", Order = 8)]
		public Worker_by_National_ID_Request_CriteriaType[] National_ID_Criteria_Data
		{
			get
			{
				return this.national_ID_Criteria_DataField;
			}
			set
			{
				this.national_ID_Criteria_DataField = value;
				this.RaisePropertyChanged("National_ID_Criteria_Data");
			}
		}

		[XmlElement(Order = 9)]
		public bool Exclude_Inactive_Workers
		{
			get
			{
				return this.exclude_Inactive_WorkersField;
			}
			set
			{
				this.exclude_Inactive_WorkersField = value;
				this.RaisePropertyChanged("Exclude_Inactive_Workers");
			}
		}

		[XmlIgnore]
		public bool Exclude_Inactive_WorkersSpecified
		{
			get
			{
				return this.exclude_Inactive_WorkersFieldSpecified;
			}
			set
			{
				this.exclude_Inactive_WorkersFieldSpecified = value;
				this.RaisePropertyChanged("Exclude_Inactive_WorkersSpecified");
			}
		}

		[XmlElement(Order = 10)]
		public bool Exclude_Employees
		{
			get
			{
				return this.exclude_EmployeesField;
			}
			set
			{
				this.exclude_EmployeesField = value;
				this.RaisePropertyChanged("Exclude_Employees");
			}
		}

		[XmlIgnore]
		public bool Exclude_EmployeesSpecified
		{
			get
			{
				return this.exclude_EmployeesFieldSpecified;
			}
			set
			{
				this.exclude_EmployeesFieldSpecified = value;
				this.RaisePropertyChanged("Exclude_EmployeesSpecified");
			}
		}

		[XmlElement(Order = 11)]
		public bool Exclude_Contingent_Workers
		{
			get
			{
				return this.exclude_Contingent_WorkersField;
			}
			set
			{
				this.exclude_Contingent_WorkersField = value;
				this.RaisePropertyChanged("Exclude_Contingent_Workers");
			}
		}

		[XmlIgnore]
		public bool Exclude_Contingent_WorkersSpecified
		{
			get
			{
				return this.exclude_Contingent_WorkersFieldSpecified;
			}
			set
			{
				this.exclude_Contingent_WorkersFieldSpecified = value;
				this.RaisePropertyChanged("Exclude_Contingent_WorkersSpecified");
			}
		}

		[XmlElement("Eligibility_Criteria_Data", Order = 12)]
		public Eligibility_Criteria_DataType[] Eligibility_Criteria_Data
		{
			get
			{
				return this.eligibility_Criteria_DataField;
			}
			set
			{
				this.eligibility_Criteria_DataField = value;
				this.RaisePropertyChanged("Eligibility_Criteria_Data");
			}
		}

		[XmlElement("Universal_ID_Reference", Order = 13)]
		public Universal_IdentifierObjectType[] Universal_ID_Reference
		{
			get
			{
				return this.universal_ID_ReferenceField;
			}
			set
			{
				this.universal_ID_ReferenceField = value;
				this.RaisePropertyChanged("Universal_ID_Reference");
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
