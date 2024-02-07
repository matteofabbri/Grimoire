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
	public class Gift_HierarchyType : INotifyPropertyChanged
	{
		private Gift_HierarchyObjectType gift_Hierarchy_ReferenceField;

		private Gift_Hierarchy_DataType gift_Hierarchy_DataField;

		private Gift_HierarchyObjectType[] gift_Hierarchy_ChildrenField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Gift_HierarchyObjectType Gift_Hierarchy_Reference
		{
			get
			{
				return this.gift_Hierarchy_ReferenceField;
			}
			set
			{
				this.gift_Hierarchy_ReferenceField = value;
				this.RaisePropertyChanged("Gift_Hierarchy_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Gift_Hierarchy_DataType Gift_Hierarchy_Data
		{
			get
			{
				return this.gift_Hierarchy_DataField;
			}
			set
			{
				this.gift_Hierarchy_DataField = value;
				this.RaisePropertyChanged("Gift_Hierarchy_Data");
			}
		}

		[XmlArray(Order = 2), XmlArrayItem("Child_Gift_Hierarchy_Reference", IsNullable = false)]
		public Gift_HierarchyObjectType[] Gift_Hierarchy_Children
		{
			get
			{
				return this.gift_Hierarchy_ChildrenField;
			}
			set
			{
				this.gift_Hierarchy_ChildrenField = value;
				this.RaisePropertyChanged("Gift_Hierarchy_Children");
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
