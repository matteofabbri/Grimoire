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
	public class Organization_WWS_DataType : INotifyPropertyChanged
	{
		private string reference_IDField;

		private string nameField;

		private string descriptionField;

		private string organization_CodeField;

		private bool include_Manager_in_NameField;

		private bool include_Manager_in_NameFieldSpecified;

		private bool include_Organization_Code_in_NameField;

		private bool include_Organization_Code_in_NameFieldSpecified;

		private Organization_TypeObjectType organization_Type_ReferenceField;

		private Organization_SubtypeObjectType organization_Subtype_ReferenceField;

		private DateTime availibility_DateField;

		private bool availibility_DateFieldSpecified;

		private DateTime last_Updated_DateTimeField;

		private bool last_Updated_DateTimeFieldSpecified;

		private bool inactiveField;

		private bool inactiveFieldSpecified;

		private DateTime inactive_DateField;

		private bool inactive_DateFieldSpecified;

		private WorkerObjectType manager_ReferenceField;

		private WorkerObjectType[] leadership_ReferenceField;

		private Organization_OwnerObjectType organization_Owner_ReferenceField;

		private Unique_IdentifierObjectType organization_Visibility_ReferenceField;

		private External_URLObjectType external_URL_ReferenceField;

		private IDType[] external_IDs_DataField;

		private Organization_Role_Assignment_WWS_DataType[] roles_DataField;

		private Organization_Hierarchy_DataType hierarchy_DataField;

		private Supervisory_Org_DataType supervisory_DataField;

		private Document_Field_Result_DataType[] integration_Field_Override_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Reference_ID
		{
			get
			{
				return this.reference_IDField;
			}
			set
			{
				this.reference_IDField = value;
				this.RaisePropertyChanged("Reference_ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
				this.RaisePropertyChanged("Name");
			}
		}

		[XmlElement(Order = 2)]
		public string Description
		{
			get
			{
				return this.descriptionField;
			}
			set
			{
				this.descriptionField = value;
				this.RaisePropertyChanged("Description");
			}
		}

		[XmlElement(Order = 3)]
		public string Organization_Code
		{
			get
			{
				return this.organization_CodeField;
			}
			set
			{
				this.organization_CodeField = value;
				this.RaisePropertyChanged("Organization_Code");
			}
		}

		[XmlElement(Order = 4)]
		public bool Include_Manager_in_Name
		{
			get
			{
				return this.include_Manager_in_NameField;
			}
			set
			{
				this.include_Manager_in_NameField = value;
				this.RaisePropertyChanged("Include_Manager_in_Name");
			}
		}

		[XmlIgnore]
		public bool Include_Manager_in_NameSpecified
		{
			get
			{
				return this.include_Manager_in_NameFieldSpecified;
			}
			set
			{
				this.include_Manager_in_NameFieldSpecified = value;
				this.RaisePropertyChanged("Include_Manager_in_NameSpecified");
			}
		}

		[XmlElement(Order = 5)]
		public bool Include_Organization_Code_in_Name
		{
			get
			{
				return this.include_Organization_Code_in_NameField;
			}
			set
			{
				this.include_Organization_Code_in_NameField = value;
				this.RaisePropertyChanged("Include_Organization_Code_in_Name");
			}
		}

		[XmlIgnore]
		public bool Include_Organization_Code_in_NameSpecified
		{
			get
			{
				return this.include_Organization_Code_in_NameFieldSpecified;
			}
			set
			{
				this.include_Organization_Code_in_NameFieldSpecified = value;
				this.RaisePropertyChanged("Include_Organization_Code_in_NameSpecified");
			}
		}

		[XmlElement(Order = 6)]
		public Organization_TypeObjectType Organization_Type_Reference
		{
			get
			{
				return this.organization_Type_ReferenceField;
			}
			set
			{
				this.organization_Type_ReferenceField = value;
				this.RaisePropertyChanged("Organization_Type_Reference");
			}
		}

		[XmlElement(Order = 7)]
		public Organization_SubtypeObjectType Organization_Subtype_Reference
		{
			get
			{
				return this.organization_Subtype_ReferenceField;
			}
			set
			{
				this.organization_Subtype_ReferenceField = value;
				this.RaisePropertyChanged("Organization_Subtype_Reference");
			}
		}

		[XmlElement(Order = 8)]
		public DateTime Availibility_Date
		{
			get
			{
				return this.availibility_DateField;
			}
			set
			{
				this.availibility_DateField = value;
				this.RaisePropertyChanged("Availibility_Date");
			}
		}

		[XmlIgnore]
		public bool Availibility_DateSpecified
		{
			get
			{
				return this.availibility_DateFieldSpecified;
			}
			set
			{
				this.availibility_DateFieldSpecified = value;
				this.RaisePropertyChanged("Availibility_DateSpecified");
			}
		}

		[XmlElement(Order = 9)]
		public DateTime Last_Updated_DateTime
		{
			get
			{
				return this.last_Updated_DateTimeField;
			}
			set
			{
				this.last_Updated_DateTimeField = value;
				this.RaisePropertyChanged("Last_Updated_DateTime");
			}
		}

		[XmlIgnore]
		public bool Last_Updated_DateTimeSpecified
		{
			get
			{
				return this.last_Updated_DateTimeFieldSpecified;
			}
			set
			{
				this.last_Updated_DateTimeFieldSpecified = value;
				this.RaisePropertyChanged("Last_Updated_DateTimeSpecified");
			}
		}

		[XmlElement(Order = 10)]
		public bool Inactive
		{
			get
			{
				return this.inactiveField;
			}
			set
			{
				this.inactiveField = value;
				this.RaisePropertyChanged("Inactive");
			}
		}

		[XmlIgnore]
		public bool InactiveSpecified
		{
			get
			{
				return this.inactiveFieldSpecified;
			}
			set
			{
				this.inactiveFieldSpecified = value;
				this.RaisePropertyChanged("InactiveSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 11)]
		public DateTime Inactive_Date
		{
			get
			{
				return this.inactive_DateField;
			}
			set
			{
				this.inactive_DateField = value;
				this.RaisePropertyChanged("Inactive_Date");
			}
		}

		[XmlIgnore]
		public bool Inactive_DateSpecified
		{
			get
			{
				return this.inactive_DateFieldSpecified;
			}
			set
			{
				this.inactive_DateFieldSpecified = value;
				this.RaisePropertyChanged("Inactive_DateSpecified");
			}
		}

		[XmlElement(Order = 12)]
		public WorkerObjectType Manager_Reference
		{
			get
			{
				return this.manager_ReferenceField;
			}
			set
			{
				this.manager_ReferenceField = value;
				this.RaisePropertyChanged("Manager_Reference");
			}
		}

		[XmlElement("Leadership_Reference", Order = 13)]
		public WorkerObjectType[] Leadership_Reference
		{
			get
			{
				return this.leadership_ReferenceField;
			}
			set
			{
				this.leadership_ReferenceField = value;
				this.RaisePropertyChanged("Leadership_Reference");
			}
		}

		[XmlElement(Order = 14)]
		public Organization_OwnerObjectType Organization_Owner_Reference
		{
			get
			{
				return this.organization_Owner_ReferenceField;
			}
			set
			{
				this.organization_Owner_ReferenceField = value;
				this.RaisePropertyChanged("Organization_Owner_Reference");
			}
		}

		[XmlElement(Order = 15)]
		public Unique_IdentifierObjectType Organization_Visibility_Reference
		{
			get
			{
				return this.organization_Visibility_ReferenceField;
			}
			set
			{
				this.organization_Visibility_ReferenceField = value;
				this.RaisePropertyChanged("Organization_Visibility_Reference");
			}
		}

		[XmlElement(Order = 16)]
		public External_URLObjectType External_URL_Reference
		{
			get
			{
				return this.external_URL_ReferenceField;
			}
			set
			{
				this.external_URL_ReferenceField = value;
				this.RaisePropertyChanged("External_URL_Reference");
			}
		}

		[XmlArray(Order = 17), XmlArrayItem("ID", IsNullable = false)]
		public IDType[] External_IDs_Data
		{
			get
			{
				return this.external_IDs_DataField;
			}
			set
			{
				this.external_IDs_DataField = value;
				this.RaisePropertyChanged("External_IDs_Data");
			}
		}

		[XmlArray(Order = 18), XmlArrayItem("Organization_Role_Data", IsNullable = false)]
		public Organization_Role_Assignment_WWS_DataType[] Roles_Data
		{
			get
			{
				return this.roles_DataField;
			}
			set
			{
				this.roles_DataField = value;
				this.RaisePropertyChanged("Roles_Data");
			}
		}

		[XmlElement(Order = 19)]
		public Organization_Hierarchy_DataType Hierarchy_Data
		{
			get
			{
				return this.hierarchy_DataField;
			}
			set
			{
				this.hierarchy_DataField = value;
				this.RaisePropertyChanged("Hierarchy_Data");
			}
		}

		[XmlElement(Order = 20)]
		public Supervisory_Org_DataType Supervisory_Data
		{
			get
			{
				return this.supervisory_DataField;
			}
			set
			{
				this.supervisory_DataField = value;
				this.RaisePropertyChanged("Supervisory_Data");
			}
		}

		[XmlElement("Integration_Field_Override_Data", Order = 21)]
		public Document_Field_Result_DataType[] Integration_Field_Override_Data
		{
			get
			{
				return this.integration_Field_Override_DataField;
			}
			set
			{
				this.integration_Field_Override_DataField = value;
				this.RaisePropertyChanged("Integration_Field_Override_Data");
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
