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
	public class Bank_Branch_Request_ReferencesType : INotifyPropertyChanged
	{
		private Bank_BranchObjectType[] bank_Branch_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Bank_Branch_Reference", Order = 0)]
		public Bank_BranchObjectType[] Bank_Branch_Reference
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
