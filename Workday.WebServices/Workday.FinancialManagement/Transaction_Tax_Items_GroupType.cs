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
	public class Transaction_Tax_Items_GroupType : INotifyPropertyChanged
	{
		private Transaction_Tax_Items_GroupObjectType transaction_Tax_Item_Group_ReferenceField;

		private Tax_Items_Group_DataType[] transaction_Tax_Item_Group_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Transaction_Tax_Items_GroupObjectType Transaction_Tax_Item_Group_Reference
		{
			get
			{
				return this.transaction_Tax_Item_Group_ReferenceField;
			}
			set
			{
				this.transaction_Tax_Item_Group_ReferenceField = value;
				this.RaisePropertyChanged("Transaction_Tax_Item_Group_Reference");
			}
		}

		[XmlElement("Transaction_Tax_Item_Group_Data", Order = 1)]
		public Tax_Items_Group_DataType[] Transaction_Tax_Item_Group_Data
		{
			get
			{
				return this.transaction_Tax_Item_Group_DataField;
			}
			set
			{
				this.transaction_Tax_Item_Group_DataField = value;
				this.RaisePropertyChanged("Transaction_Tax_Item_Group_Data");
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
