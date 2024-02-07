using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.CashManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Bank_Account_TransferType : INotifyPropertyChanged
	{
		private Bank_Account_TransferObjectType bank_Account_Transfer_ReferenceField;

		private Bank_Account_Transfer_DataType[] bank_Account_Transfer_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Bank_Account_TransferObjectType Bank_Account_Transfer_Reference
		{
			get
			{
				return this.bank_Account_Transfer_ReferenceField;
			}
			set
			{
				this.bank_Account_Transfer_ReferenceField = value;
				this.RaisePropertyChanged("Bank_Account_Transfer_Reference");
			}
		}

		[XmlElement("Bank_Account_Transfer_Data", Order = 1)]
		public Bank_Account_Transfer_DataType[] Bank_Account_Transfer_Data
		{
			get
			{
				return this.bank_Account_Transfer_DataField;
			}
			set
			{
				this.bank_Account_Transfer_DataField = value;
				this.RaisePropertyChanged("Bank_Account_Transfer_Data");
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
