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
	public class Petty_Cash_AccountType : INotifyPropertyChanged
	{
		private Petty_Cash_AccountObjectType petty_Cash_Account_ReferenceField;

		private Petty_Cash_Account_DataType[] petty_Cash_Account_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Petty_Cash_AccountObjectType Petty_Cash_Account_Reference
		{
			get
			{
				return this.petty_Cash_Account_ReferenceField;
			}
			set
			{
				this.petty_Cash_Account_ReferenceField = value;
				this.RaisePropertyChanged("Petty_Cash_Account_Reference");
			}
		}

		[XmlElement("Petty_Cash_Account_Data", Order = 1)]
		public Petty_Cash_Account_DataType[] Petty_Cash_Account_Data
		{
			get
			{
				return this.petty_Cash_Account_DataField;
			}
			set
			{
				this.petty_Cash_Account_DataField = value;
				this.RaisePropertyChanged("Petty_Cash_Account_Data");
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
