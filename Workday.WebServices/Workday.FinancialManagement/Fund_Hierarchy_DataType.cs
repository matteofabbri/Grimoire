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
	public class Fund_Hierarchy_DataType : INotifyPropertyChanged
	{
		private string fund_Hierarchy_IDField;

		private string fund_Hierarchy_NameField;

		private bool include_Fund_Hierarchy_ID_in_NameField;

		private bool include_Fund_Hierarchy_ID_in_NameFieldSpecified;

		private bool fund_Hierarchy_is_InactiveField;

		private bool fund_Hierarchy_is_InactiveFieldSpecified;

		private Organization_SubtypeObjectType organization_Subtype_ReferenceField;

		private Fund_HierarchyObjectType parent_Fund_Hierarchy_ReferenceField;

		private FundObjectType[] contains_Funds_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Fund_Hierarchy_ID
		{
			get
			{
				return this.fund_Hierarchy_IDField;
			}
			set
			{
				this.fund_Hierarchy_IDField = value;
				this.RaisePropertyChanged("Fund_Hierarchy_ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Fund_Hierarchy_Name
		{
			get
			{
				return this.fund_Hierarchy_NameField;
			}
			set
			{
				this.fund_Hierarchy_NameField = value;
				this.RaisePropertyChanged("Fund_Hierarchy_Name");
			}
		}

		[XmlElement(Order = 2)]
		public bool Include_Fund_Hierarchy_ID_in_Name
		{
			get
			{
				return this.include_Fund_Hierarchy_ID_in_NameField;
			}
			set
			{
				this.include_Fund_Hierarchy_ID_in_NameField = value;
				this.RaisePropertyChanged("Include_Fund_Hierarchy_ID_in_Name");
			}
		}

		[XmlIgnore]
		public bool Include_Fund_Hierarchy_ID_in_NameSpecified
		{
			get
			{
				return this.include_Fund_Hierarchy_ID_in_NameFieldSpecified;
			}
			set
			{
				this.include_Fund_Hierarchy_ID_in_NameFieldSpecified = value;
				this.RaisePropertyChanged("Include_Fund_Hierarchy_ID_in_NameSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public bool Fund_Hierarchy_is_Inactive
		{
			get
			{
				return this.fund_Hierarchy_is_InactiveField;
			}
			set
			{
				this.fund_Hierarchy_is_InactiveField = value;
				this.RaisePropertyChanged("Fund_Hierarchy_is_Inactive");
			}
		}

		[XmlIgnore]
		public bool Fund_Hierarchy_is_InactiveSpecified
		{
			get
			{
				return this.fund_Hierarchy_is_InactiveFieldSpecified;
			}
			set
			{
				this.fund_Hierarchy_is_InactiveFieldSpecified = value;
				this.RaisePropertyChanged("Fund_Hierarchy_is_InactiveSpecified");
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
		public Fund_HierarchyObjectType Parent_Fund_Hierarchy_Reference
		{
			get
			{
				return this.parent_Fund_Hierarchy_ReferenceField;
			}
			set
			{
				this.parent_Fund_Hierarchy_ReferenceField = value;
				this.RaisePropertyChanged("Parent_Fund_Hierarchy_Reference");
			}
		}

		[XmlElement("Contains_Funds_Reference", Order = 6)]
		public FundObjectType[] Contains_Funds_Reference
		{
			get
			{
				return this.contains_Funds_ReferenceField;
			}
			set
			{
				this.contains_Funds_ReferenceField = value;
				this.RaisePropertyChanged("Contains_Funds_Reference");
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
