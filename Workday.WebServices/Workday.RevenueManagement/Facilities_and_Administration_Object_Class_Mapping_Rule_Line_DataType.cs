using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Facilities_and_Administration_Object_Class_Mapping_Rule_Line_DataType : INotifyPropertyChanged
	{
		private Spend_Category_or_HierarchyObjectType spend_Category_ReferenceField;

		private Pay_Component_Group__All_ObjectType pay_Component_Group_ReferenceField;

		private Accounting_WorktagObjectType exception_Worktag_ReferenceField;

		private Spend_Category_or_HierarchyObjectType[] exclude_Spend_Category_or_Hierarchy_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Spend_Category_or_HierarchyObjectType Spend_Category_Reference
		{
			get
			{
				return this.spend_Category_ReferenceField;
			}
			set
			{
				this.spend_Category_ReferenceField = value;
				this.RaisePropertyChanged("Spend_Category_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Pay_Component_Group__All_ObjectType Pay_Component_Group_Reference
		{
			get
			{
				return this.pay_Component_Group_ReferenceField;
			}
			set
			{
				this.pay_Component_Group_ReferenceField = value;
				this.RaisePropertyChanged("Pay_Component_Group_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public Accounting_WorktagObjectType Exception_Worktag_Reference
		{
			get
			{
				return this.exception_Worktag_ReferenceField;
			}
			set
			{
				this.exception_Worktag_ReferenceField = value;
				this.RaisePropertyChanged("Exception_Worktag_Reference");
			}
		}

		[XmlElement("Exclude_Spend_Category_or_Hierarchy_Reference", Order = 3)]
		public Spend_Category_or_HierarchyObjectType[] Exclude_Spend_Category_or_Hierarchy_Reference
		{
			get
			{
				return this.exclude_Spend_Category_or_Hierarchy_ReferenceField;
			}
			set
			{
				this.exclude_Spend_Category_or_Hierarchy_ReferenceField = value;
				this.RaisePropertyChanged("Exclude_Spend_Category_or_Hierarchy_Reference");
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
