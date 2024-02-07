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
	public class Transaction_Tax_Item_Group_Request_ReferencesType : INotifyPropertyChanged
	{
		private Transaction_Tax_Items_GroupObjectType[] transaction_Tax_Item_Group_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Transaction_Tax_Item_Group_Reference", Order = 0)]
		public Transaction_Tax_Items_GroupObjectType[] Transaction_Tax_Item_Group_Reference
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
