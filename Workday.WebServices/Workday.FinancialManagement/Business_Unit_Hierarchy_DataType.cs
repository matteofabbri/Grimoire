using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Business_Unit_Hierarchy_DataType : INotifyPropertyChanged
	{
		private string business_Unit_Hierarchy_IDField;

		private string business_Unit_Hierarchy_NameField;

		private bool include_Business_Unit_Hierarchy_ID_in_NameField;

		private bool include_Business_Unit_Hierarchy_ID_in_NameFieldSpecified;

		private bool business_Unit_Hierarchy_is_InactiveField;

		private bool business_Unit_Hierarchy_is_InactiveFieldSpecified;

		private Organization_SubtypeObjectType organization_Subtype_ReferenceField;

		private Business_Unit_HierarchyObjectType parent_Business_Unit_Hierarchy_ReferenceField;

		private Business_UnitObjectType[] contains_Business_Unit_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Business_Unit_Hierarchy_ID
		{
			get
			{
				return this.business_Unit_Hierarchy_IDField;
			}
			set
			{
				this.business_Unit_Hierarchy_IDField = value;
				this.RaisePropertyChanged("Business_Unit_Hierarchy_ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Business_Unit_Hierarchy_Name
		{
			get
			{
				return this.business_Unit_Hierarchy_NameField;
			}
			set
			{
				this.business_Unit_Hierarchy_NameField = value;
				this.RaisePropertyChanged("Business_Unit_Hierarchy_Name");
			}
		}

		[XmlElement(Order = 2)]
		public bool Include_Business_Unit_Hierarchy_ID_in_Name
		{
			get
			{
				return this.include_Business_Unit_Hierarchy_ID_in_NameField;
			}
			set
			{
				this.include_Business_Unit_Hierarchy_ID_in_NameField = value;
				this.RaisePropertyChanged("Include_Business_Unit_Hierarchy_ID_in_Name");
			}
		}

		[XmlIgnore]
		public bool Include_Business_Unit_Hierarchy_ID_in_NameSpecified
		{
			get
			{
				return this.include_Business_Unit_Hierarchy_ID_in_NameFieldSpecified;
			}
			set
			{
				this.include_Business_Unit_Hierarchy_ID_in_NameFieldSpecified = value;
				this.RaisePropertyChanged("Include_Business_Unit_Hierarchy_ID_in_NameSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public bool Business_Unit_Hierarchy_is_Inactive
		{
			get
			{
				return this.business_Unit_Hierarchy_is_InactiveField;
			}
			set
			{
				this.business_Unit_Hierarchy_is_InactiveField = value;
				this.RaisePropertyChanged("Business_Unit_Hierarchy_is_Inactive");
			}
		}

		[XmlIgnore]
		public bool Business_Unit_Hierarchy_is_InactiveSpecified
		{
			get
			{
				return this.business_Unit_Hierarchy_is_InactiveFieldSpecified;
			}
			set
			{
				this.business_Unit_Hierarchy_is_InactiveFieldSpecified = value;
				this.RaisePropertyChanged("Business_Unit_Hierarchy_is_InactiveSpecified");
			}
		}

		[XmlElement(Order = 4)]
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

		[XmlElement(Order = 5)]
		public Business_Unit_HierarchyObjectType Parent_Business_Unit_Hierarchy_Reference
		{
			get
			{
				return this.parent_Business_Unit_Hierarchy_ReferenceField;
			}
			set
			{
				this.parent_Business_Unit_Hierarchy_ReferenceField = value;
				this.RaisePropertyChanged("Parent_Business_Unit_Hierarchy_Reference");
			}
		}

		[XmlElement("Contains_Business_Unit_Reference", Order = 6)]
		public Business_UnitObjectType[] Contains_Business_Unit_Reference
		{
			get
			{
				return this.contains_Business_Unit_ReferenceField;
			}
			set
			{
				this.contains_Business_Unit_ReferenceField = value;
				this.RaisePropertyChanged("Contains_Business_Unit_Reference");
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
