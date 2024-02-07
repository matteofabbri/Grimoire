using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.HumanResources
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Academic_Unit_DataType : INotifyPropertyChanged
	{
		private string idField;

		private DateTime effective_DateField;

		private bool effective_DateFieldSpecified;

		private string nameField;

		private string codeField;

		private bool is_InstitutionField;

		private bool is_InstitutionFieldSpecified;

		private bool include_Code_in_NameField;

		private bool include_Code_in_NameFieldSpecified;

		private bool include_Incumbent_Leader_in_NameField;

		private bool include_Incumbent_Leader_in_NameFieldSpecified;

		private Academic_Unit_SubtypeObjectType academic_Organization_Subtype_ReferenceField;

		private bool include_Subtype_in_NameField;

		private bool include_Subtype_in_NameFieldSpecified;

		private bool inactiveField;

		private bool inactiveFieldSpecified;

		private CompanyObjectType company_ReferenceField;

		private CIP_Code__Workday_Owned_ObjectType cIP_Code_ReferenceField;

		private External_URLObjectType external_URL_ReferenceField;

		private Supervisory_OrganizationObjectType[] supervisory_Organization_ReferenceField;

		private Academic_Track_TypeObjectType[] track_Type_ReferenceField;

		private Academic_UnitObjectType superior_Academic_Unit_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string ID
		{
			get
			{
				return this.idField;
			}
			set
			{
				this.idField = value;
				this.RaisePropertyChanged("ID");
			}
		}

		[XmlElement(DataType = "date", Order = 1)]
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

		[XmlIgnore]
		public bool Effective_DateSpecified
		{
			get
			{
				return this.effective_DateFieldSpecified;
			}
			set
			{
				this.effective_DateFieldSpecified = value;
				this.RaisePropertyChanged("Effective_DateSpecified");
			}
		}

		[XmlElement(Order = 2)]
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

		[XmlElement(Order = 3)]
		public string Code
		{
			get
			{
				return this.codeField;
			}
			set
			{
				this.codeField = value;
				this.RaisePropertyChanged("Code");
			}
		}

		[XmlElement(Order = 4)]
		public bool Is_Institution
		{
			get
			{
				return this.is_InstitutionField;
			}
			set
			{
				this.is_InstitutionField = value;
				this.RaisePropertyChanged("Is_Institution");
			}
		}

		[XmlIgnore]
		public bool Is_InstitutionSpecified
		{
			get
			{
				return this.is_InstitutionFieldSpecified;
			}
			set
			{
				this.is_InstitutionFieldSpecified = value;
				this.RaisePropertyChanged("Is_InstitutionSpecified");
			}
		}

		[XmlElement(Order = 5)]
		public bool Include_Code_in_Name
		{
			get
			{
				return this.include_Code_in_NameField;
			}
			set
			{
				this.include_Code_in_NameField = value;
				this.RaisePropertyChanged("Include_Code_in_Name");
			}
		}

		[XmlIgnore]
		public bool Include_Code_in_NameSpecified
		{
			get
			{
				return this.include_Code_in_NameFieldSpecified;
			}
			set
			{
				this.include_Code_in_NameFieldSpecified = value;
				this.RaisePropertyChanged("Include_Code_in_NameSpecified");
			}
		}

		[XmlElement(Order = 6)]
		public bool Include_Incumbent_Leader_in_Name
		{
			get
			{
				return this.include_Incumbent_Leader_in_NameField;
			}
			set
			{
				this.include_Incumbent_Leader_in_NameField = value;
				this.RaisePropertyChanged("Include_Incumbent_Leader_in_Name");
			}
		}

		[XmlIgnore]
		public bool Include_Incumbent_Leader_in_NameSpecified
		{
			get
			{
				return this.include_Incumbent_Leader_in_NameFieldSpecified;
			}
			set
			{
				this.include_Incumbent_Leader_in_NameFieldSpecified = value;
				this.RaisePropertyChanged("Include_Incumbent_Leader_in_NameSpecified");
			}
		}

		[XmlElement(Order = 7)]
		public Academic_Unit_SubtypeObjectType Academic_Organization_Subtype_Reference
		{
			get
			{
				return this.academic_Organization_Subtype_ReferenceField;
			}
			set
			{
				this.academic_Organization_Subtype_ReferenceField = value;
				this.RaisePropertyChanged("Academic_Organization_Subtype_Reference");
			}
		}

		[XmlElement(Order = 8)]
		public bool Include_Subtype_in_Name
		{
			get
			{
				return this.include_Subtype_in_NameField;
			}
			set
			{
				this.include_Subtype_in_NameField = value;
				this.RaisePropertyChanged("Include_Subtype_in_Name");
			}
		}

		[XmlIgnore]
		public bool Include_Subtype_in_NameSpecified
		{
			get
			{
				return this.include_Subtype_in_NameFieldSpecified;
			}
			set
			{
				this.include_Subtype_in_NameFieldSpecified = value;
				this.RaisePropertyChanged("Include_Subtype_in_NameSpecified");
			}
		}

		[XmlElement(Order = 9)]
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

		[XmlElement(Order = 10)]
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

		[XmlElement(Order = 11)]
		public CIP_Code__Workday_Owned_ObjectType CIP_Code_Reference
		{
			get
			{
				return this.cIP_Code_ReferenceField;
			}
			set
			{
				this.cIP_Code_ReferenceField = value;
				this.RaisePropertyChanged("CIP_Code_Reference");
			}
		}

		[XmlElement(Order = 12)]
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

		[XmlElement("Supervisory_Organization_Reference", Order = 13)]
		public Supervisory_OrganizationObjectType[] Supervisory_Organization_Reference
		{
			get
			{
				return this.supervisory_Organization_ReferenceField;
			}
			set
			{
				this.supervisory_Organization_ReferenceField = value;
				this.RaisePropertyChanged("Supervisory_Organization_Reference");
			}
		}

		[XmlElement("Track_Type_Reference", Order = 14)]
		public Academic_Track_TypeObjectType[] Track_Type_Reference
		{
			get
			{
				return this.track_Type_ReferenceField;
			}
			set
			{
				this.track_Type_ReferenceField = value;
				this.RaisePropertyChanged("Track_Type_Reference");
			}
		}

		[XmlElement(Order = 15)]
		public Academic_UnitObjectType Superior_Academic_Unit_Reference
		{
			get
			{
				return this.superior_Academic_Unit_ReferenceField;
			}
			set
			{
				this.superior_Academic_Unit_ReferenceField = value;
				this.RaisePropertyChanged("Superior_Academic_Unit_Reference");
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
