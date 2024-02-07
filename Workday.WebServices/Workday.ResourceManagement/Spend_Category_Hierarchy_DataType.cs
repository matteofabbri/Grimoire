using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Spend_Category_Hierarchy_DataType : INotifyPropertyChanged
	{
		private string spend_Category_Hierarchy_IDField;

		private string spend_Category_Hierarchy_NamesField;

		private Hierarchy_LevelObjectType hierarchy_Level_ReferenceField;

		private Spend_Category_HierarchyObjectType parent_ReferenceField;

		private bool enable_for_External_WebsiteField;

		private bool enable_for_External_WebsiteFieldSpecified;

		private Spend_CategoryObjectType[] included_Spend_Categories_ReferenceField;

		private string commodity_CodeField;

		private string descriptionField;

		private bool inactiveField;

		private bool inactiveFieldSpecified;

		private Spend_Category_or_Hierarchy_Display_OptionObjectType spend_Category_Hierarchy_Display_Option_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Spend_Category_Hierarchy_ID
		{
			get
			{
				return this.spend_Category_Hierarchy_IDField;
			}
			set
			{
				this.spend_Category_Hierarchy_IDField = value;
				this.RaisePropertyChanged("Spend_Category_Hierarchy_ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Spend_Category_Hierarchy_Names
		{
			get
			{
				return this.spend_Category_Hierarchy_NamesField;
			}
			set
			{
				this.spend_Category_Hierarchy_NamesField = value;
				this.RaisePropertyChanged("Spend_Category_Hierarchy_Names");
			}
		}

		[XmlElement(Order = 2)]
		public Hierarchy_LevelObjectType Hierarchy_Level_Reference
		{
			get
			{
				return this.hierarchy_Level_ReferenceField;
			}
			set
			{
				this.hierarchy_Level_ReferenceField = value;
				this.RaisePropertyChanged("Hierarchy_Level_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public Spend_Category_HierarchyObjectType Parent_Reference
		{
			get
			{
				return this.parent_ReferenceField;
			}
			set
			{
				this.parent_ReferenceField = value;
				this.RaisePropertyChanged("Parent_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public bool Enable_for_External_Website
		{
			get
			{
				return this.enable_for_External_WebsiteField;
			}
			set
			{
				this.enable_for_External_WebsiteField = value;
				this.RaisePropertyChanged("Enable_for_External_Website");
			}
		}

		[XmlIgnore]
		public bool Enable_for_External_WebsiteSpecified
		{
			get
			{
				return this.enable_for_External_WebsiteFieldSpecified;
			}
			set
			{
				this.enable_for_External_WebsiteFieldSpecified = value;
				this.RaisePropertyChanged("Enable_for_External_WebsiteSpecified");
			}
		}

		[XmlElement("Included_Spend_Categories_Reference", Order = 5)]
		public Spend_CategoryObjectType[] Included_Spend_Categories_Reference
		{
			get
			{
				return this.included_Spend_Categories_ReferenceField;
			}
			set
			{
				this.included_Spend_Categories_ReferenceField = value;
				this.RaisePropertyChanged("Included_Spend_Categories_Reference");
			}
		}

		[XmlElement(Order = 6)]
		public string Commodity_Code
		{
			get
			{
				return this.commodity_CodeField;
			}
			set
			{
				this.commodity_CodeField = value;
				this.RaisePropertyChanged("Commodity_Code");
			}
		}

		[XmlElement(Order = 7)]
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

		[XmlElement(Order = 8)]
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

		[XmlElement(Order = 9)]
		public Spend_Category_or_Hierarchy_Display_OptionObjectType Spend_Category_Hierarchy_Display_Option_Reference
		{
			get
			{
				return this.spend_Category_Hierarchy_Display_Option_ReferenceField;
			}
			set
			{
				this.spend_Category_Hierarchy_Display_Option_ReferenceField = value;
				this.RaisePropertyChanged("Spend_Category_Hierarchy_Display_Option_Reference");
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
