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
	public class Grant_Hierarchy_DataType : INotifyPropertyChanged
	{
		private string grant_Hierarchy_IDField;

		private string grant_Hierarchy_NameField;

		private bool include_Grant_Hierarchy_ID_in_NameField;

		private bool include_Grant_Hierarchy_ID_in_NameFieldSpecified;

		private bool grant_Hierarchy_is_InactiveField;

		private bool grant_Hierarchy_is_InactiveFieldSpecified;

		private Organization_SubtypeObjectType organization_Subtype_ReferenceField;

		private Grant_HierarchyObjectType superior_Grant_Hierarchy_ReferenceField;

		private GrantObjectType[] included_Grant_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Grant_Hierarchy_ID
		{
			get
			{
				return this.grant_Hierarchy_IDField;
			}
			set
			{
				this.grant_Hierarchy_IDField = value;
				this.RaisePropertyChanged("Grant_Hierarchy_ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Grant_Hierarchy_Name
		{
			get
			{
				return this.grant_Hierarchy_NameField;
			}
			set
			{
				this.grant_Hierarchy_NameField = value;
				this.RaisePropertyChanged("Grant_Hierarchy_Name");
			}
		}

		[XmlElement(Order = 2)]
		public bool Include_Grant_Hierarchy_ID_in_Name
		{
			get
			{
				return this.include_Grant_Hierarchy_ID_in_NameField;
			}
			set
			{
				this.include_Grant_Hierarchy_ID_in_NameField = value;
				this.RaisePropertyChanged("Include_Grant_Hierarchy_ID_in_Name");
			}
		}

		[XmlIgnore]
		public bool Include_Grant_Hierarchy_ID_in_NameSpecified
		{
			get
			{
				return this.include_Grant_Hierarchy_ID_in_NameFieldSpecified;
			}
			set
			{
				this.include_Grant_Hierarchy_ID_in_NameFieldSpecified = value;
				this.RaisePropertyChanged("Include_Grant_Hierarchy_ID_in_NameSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public bool Grant_Hierarchy_is_Inactive
		{
			get
			{
				return this.grant_Hierarchy_is_InactiveField;
			}
			set
			{
				this.grant_Hierarchy_is_InactiveField = value;
				this.RaisePropertyChanged("Grant_Hierarchy_is_Inactive");
			}
		}

		[XmlIgnore]
		public bool Grant_Hierarchy_is_InactiveSpecified
		{
			get
			{
				return this.grant_Hierarchy_is_InactiveFieldSpecified;
			}
			set
			{
				this.grant_Hierarchy_is_InactiveFieldSpecified = value;
				this.RaisePropertyChanged("Grant_Hierarchy_is_InactiveSpecified");
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
		public Grant_HierarchyObjectType Superior_Grant_Hierarchy_Reference
		{
			get
			{
				return this.superior_Grant_Hierarchy_ReferenceField;
			}
			set
			{
				this.superior_Grant_Hierarchy_ReferenceField = value;
				this.RaisePropertyChanged("Superior_Grant_Hierarchy_Reference");
			}
		}

		[XmlElement("Included_Grant_Reference", Order = 6)]
		public GrantObjectType[] Included_Grant_Reference
		{
			get
			{
				return this.included_Grant_ReferenceField;
			}
			set
			{
				this.included_Grant_ReferenceField = value;
				this.RaisePropertyChanged("Included_Grant_Reference");
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
