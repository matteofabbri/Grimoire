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
	public class Gift_Hierarchy_DataType : INotifyPropertyChanged
	{
		private string idField;

		private string nameField;

		private bool include_Gift_Hierarchy_ID_in_NameField;

		private bool include_Gift_Hierarchy_ID_in_NameFieldSpecified;

		private bool inactiveField;

		private bool inactiveFieldSpecified;

		private Organization_SubtypeObjectType organization_Subtype_ReferenceField;

		private Gift_HierarchyObjectType superior_Gift_Hierarchy_ReferenceField;

		private GiftObjectType[] gift_ReferenceField;

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
		public bool Include_Gift_Hierarchy_ID_in_Name
		{
			get
			{
				return this.include_Gift_Hierarchy_ID_in_NameField;
			}
			set
			{
				this.include_Gift_Hierarchy_ID_in_NameField = value;
				this.RaisePropertyChanged("Include_Gift_Hierarchy_ID_in_Name");
			}
		}

		[XmlIgnore]
		public bool Include_Gift_Hierarchy_ID_in_NameSpecified
		{
			get
			{
				return this.include_Gift_Hierarchy_ID_in_NameFieldSpecified;
			}
			set
			{
				this.include_Gift_Hierarchy_ID_in_NameFieldSpecified = value;
				this.RaisePropertyChanged("Include_Gift_Hierarchy_ID_in_NameSpecified");
			}
		}

		[XmlElement(Order = 3)]
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
		public Gift_HierarchyObjectType Superior_Gift_Hierarchy_Reference
		{
			get
			{
				return this.superior_Gift_Hierarchy_ReferenceField;
			}
			set
			{
				this.superior_Gift_Hierarchy_ReferenceField = value;
				this.RaisePropertyChanged("Superior_Gift_Hierarchy_Reference");
			}
		}

		[XmlElement("Gift_Reference", Order = 6)]
		public GiftObjectType[] Gift_Reference
		{
			get
			{
				return this.gift_ReferenceField;
			}
			set
			{
				this.gift_ReferenceField = value;
				this.RaisePropertyChanged("Gift_Reference");
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
