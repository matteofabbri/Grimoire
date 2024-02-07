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
	public class Bank_BranchType : INotifyPropertyChanged
	{
		private Bank_BranchObjectType bank_Branch_ReferenceField;

		private Bank_Branch_DataType[] bank_Branch_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Bank_BranchObjectType Bank_Branch_Reference
		{
			get
			{
				return this.bank_Branch_ReferenceField;
			}
			set
			{
				this.bank_Branch_ReferenceField = value;
				this.RaisePropertyChanged("Bank_Branch_Reference");
			}
		}

		[XmlElement("Bank_Branch_Data", Order = 1)]
		public Bank_Branch_DataType[] Bank_Branch_Data
		{
			get
			{
				return this.bank_Branch_DataField;
			}
			set
			{
				this.bank_Branch_DataField = value;
				this.RaisePropertyChanged("Bank_Branch_Data");
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
