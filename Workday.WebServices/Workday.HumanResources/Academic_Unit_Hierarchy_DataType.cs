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
	public class Academic_Unit_Hierarchy_DataType : INotifyPropertyChanged
	{
		private string academic_Unit_Hierarchy_IDField;

		private string nameField;

		private string codeField;

		private bool include_Code_in_NameField;

		private bool include_Code_in_NameFieldSpecified;

		private bool include_Leadership_Role_Incumbent_in_NameField;

		private bool include_Leadership_Role_Incumbent_in_NameFieldSpecified;

		private bool include_Subtype_in_NameField;

		private bool include_Subtype_in_NameFieldSpecified;

		private Academic_Unit_SubtypeObjectType type_ReferenceField;

		private External_URLObjectType external_URL_ReferenceField;

		private Academic_Unit_HierarchyObjectType superior_ReferenceField;

		private Academic_Unit_HierarchyObjectType[] subordinate_ReferenceField;

		private Academic_UnitObjectType[] academic_Unit_ReferenceField;

		private bool inactiveField;

		private bool inactiveFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Academic_Unit_Hierarchy_ID
		{
			get
			{
				return this.academic_Unit_Hierarchy_IDField;
			}
			set
			{
				this.academic_Unit_Hierarchy_IDField = value;
				this.RaisePropertyChanged("Academic_Unit_Hierarchy_ID");
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

		[XmlElement(Order = 3)]
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

		[XmlElement(Order = 4)]
		public bool Include_Leadership_Role_Incumbent_in_Name
		{
			get
			{
				return this.include_Leadership_Role_Incumbent_in_NameField;
			}
			set
			{
				this.include_Leadership_Role_Incumbent_in_NameField = value;
				this.RaisePropertyChanged("Include_Leadership_Role_Incumbent_in_Name");
			}
		}

		[XmlIgnore]
		public bool Include_Leadership_Role_Incumbent_in_NameSpecified
		{
			get
			{
				return this.include_Leadership_Role_Incumbent_in_NameFieldSpecified;
			}
			set
			{
				this.include_Leadership_Role_Incumbent_in_NameFieldSpecified = value;
				this.RaisePropertyChanged("Include_Leadership_Role_Incumbent_in_NameSpecified");
			}
		}

		[XmlElement(Order = 5)]
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

		[XmlElement(Order = 6)]
		public Academic_Unit_SubtypeObjectType Type_Reference
		{
			get
			{
				return this.type_ReferenceField;
			}
			set
			{
				this.type_ReferenceField = value;
				this.RaisePropertyChanged("Type_Reference");
			}
		}

		[XmlElement(Order = 7)]
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

		[XmlElement(Order = 8)]
		public Academic_Unit_HierarchyObjectType Superior_Reference
		{
			get
			{
				return this.superior_ReferenceField;
			}
			set
			{
				this.superior_ReferenceField = value;
				this.RaisePropertyChanged("Superior_Reference");
			}
		}

		[XmlElement("Subordinate_Reference", Order = 9)]
		public Academic_Unit_HierarchyObjectType[] Subordinate_Reference
		{
			get
			{
				return this.subordinate_ReferenceField;
			}
			set
			{
				this.subordinate_ReferenceField = value;
				this.RaisePropertyChanged("Subordinate_Reference");
			}
		}

		[XmlElement("Academic_Unit_Reference", Order = 10)]
		public Academic_UnitObjectType[] Academic_Unit_Reference
		{
			get
			{
				return this.academic_Unit_ReferenceField;
			}
			set
			{
				this.academic_Unit_ReferenceField = value;
				this.RaisePropertyChanged("Academic_Unit_Reference");
			}
		}

		[XmlElement(Order = 11)]
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
