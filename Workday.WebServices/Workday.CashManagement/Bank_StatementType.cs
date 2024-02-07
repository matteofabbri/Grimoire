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
	public class Bank_StatementType : INotifyPropertyChanged
	{
		private Bank_StatementObjectType bank_Statement_ReferenceField;

		private Bank_Statement_DataType[] bank_Statement_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Bank_StatementObjectType Bank_Statement_Reference
		{
			get
			{
				return this.bank_Statement_ReferenceField;
			}
			set
			{
				this.bank_Statement_ReferenceField = value;
				this.RaisePropertyChanged("Bank_Statement_Reference");
			}
		}

		[XmlElement("Bank_Statement_Data", Order = 1)]
		public Bank_Statement_DataType[] Bank_Statement_Data
		{
			get
			{
				return this.bank_Statement_DataField;
			}
			set
			{
				this.bank_Statement_DataField = value;
				this.RaisePropertyChanged("Bank_Statement_Data");
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
