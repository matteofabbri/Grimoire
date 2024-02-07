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
	public class Bank_Statements_Request_ReferencesType : INotifyPropertyChanged
	{
		private Bank_StatementObjectType[] bank_Statements_Request_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Bank_Statements_Request_Reference", Order = 0)]
		public Bank_StatementObjectType[] Bank_Statements_Request_Reference
		{
			get
			{
				return this.bank_Statements_Request_ReferenceField;
			}
			set
			{
				this.bank_Statements_Request_ReferenceField = value;
				this.RaisePropertyChanged("Bank_Statements_Request_Reference");
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
