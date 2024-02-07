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
	public class Revenue_Category_Hierarchy_DataType : INotifyPropertyChanged
	{
		private string idField;

		private string revenue_Category_Hierarchy_NameField;

		private Hierarchy_LevelObjectType hierarchy_Level_ReferenceField;

		private Revenue_Category_HierarchyObjectType parent_Revenue_Category_Hierarchy_ReferenceField;

		private Revenue_CategoryObjectType[] revenue_Categories_Included_ReferenceField;

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
		public string Revenue_Category_Hierarchy_Name
		{
			get
			{
				return this.revenue_Category_Hierarchy_NameField;
			}
			set
			{
				this.revenue_Category_Hierarchy_NameField = value;
				this.RaisePropertyChanged("Revenue_Category_Hierarchy_Name");
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
		public Revenue_Category_HierarchyObjectType Parent_Revenue_Category_Hierarchy_Reference
		{
			get
			{
				return this.parent_Revenue_Category_Hierarchy_ReferenceField;
			}
			set
			{
				this.parent_Revenue_Category_Hierarchy_ReferenceField = value;
				this.RaisePropertyChanged("Parent_Revenue_Category_Hierarchy_Reference");
			}
		}

		[XmlElement("Revenue_Categories_Included_Reference", Order = 4)]
		public Revenue_CategoryObjectType[] Revenue_Categories_Included_Reference
		{
			get
			{
				return this.revenue_Categories_Included_ReferenceField;
			}
			set
			{
				this.revenue_Categories_Included_ReferenceField = value;
				this.RaisePropertyChanged("Revenue_Categories_Included_Reference");
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
