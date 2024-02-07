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
	public class Transaction_Tax_StatusType : INotifyPropertyChanged
	{
		private Transaction_Tax_StatusObjectType transaction_Tax_Status_ReferenceField;

		private Transaction_Tax_Status_DataType[] transaction_Tax_Status_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Transaction_Tax_StatusObjectType Transaction_Tax_Status_Reference
		{
			get
			{
				return this.transaction_Tax_Status_ReferenceField;
			}
			set
			{
				this.transaction_Tax_Status_ReferenceField = value;
				this.RaisePropertyChanged("Transaction_Tax_Status_Reference");
			}
		}

		[XmlElement("Transaction_Tax_Status_Data", Order = 1)]
		public Transaction_Tax_Status_DataType[] Transaction_Tax_Status_Data
		{
			get
			{
				return this.transaction_Tax_Status_DataField;
			}
			set
			{
				this.transaction_Tax_Status_DataField = value;
				this.RaisePropertyChanged("Transaction_Tax_Status_Data");
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
