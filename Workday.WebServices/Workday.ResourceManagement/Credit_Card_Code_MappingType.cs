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
	public class Credit_Card_Code_MappingType : INotifyPropertyChanged
	{
		private Expense_ItemObjectType expense_Item_ReferenceField;

		private Credit_Card_Expense_CodeObjectType[] merchant_Codes_for_Expense_Item_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Expense_ItemObjectType Expense_Item_Reference
		{
			get
			{
				return this.expense_Item_ReferenceField;
			}
			set
			{
				this.expense_Item_ReferenceField = value;
				this.RaisePropertyChanged("Expense_Item_Reference");
			}
		}

		[XmlElement("Merchant_Codes_for_Expense_Item_Reference", Order = 1)]
		public Credit_Card_Expense_CodeObjectType[] Merchant_Codes_for_Expense_Item_Reference
		{
			get
			{
				return this.merchant_Codes_for_Expense_Item_ReferenceField;
			}
			set
			{
				this.merchant_Codes_for_Expense_Item_ReferenceField = value;
				this.RaisePropertyChanged("Merchant_Codes_for_Expense_Item_Reference");
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
