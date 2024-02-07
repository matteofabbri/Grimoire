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
	public class Expense_Item_Attribute_Group_Request_ReferencesType : INotifyPropertyChanged
	{
		private Expense_Item_Attribute_GroupObjectType[] expense_Item_Attribute_Group_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Expense_Item_Attribute_Group_Reference", Order = 0)]
		public Expense_Item_Attribute_GroupObjectType[] Expense_Item_Attribute_Group_Reference
		{
			get
			{
				return this.expense_Item_Attribute_Group_ReferenceField;
			}
			set
			{
				this.expense_Item_Attribute_Group_ReferenceField = value;
				this.RaisePropertyChanged("Expense_Item_Attribute_Group_Reference");
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
