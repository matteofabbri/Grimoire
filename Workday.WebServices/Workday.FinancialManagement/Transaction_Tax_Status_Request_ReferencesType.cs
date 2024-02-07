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
	public class Transaction_Tax_Status_Request_ReferencesType : INotifyPropertyChanged
	{
		private Transaction_Tax_StatusObjectType[] transaction_Tax_Status_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Transaction_Tax_Status_Reference", Order = 0)]
		public Transaction_Tax_StatusObjectType[] Transaction_Tax_Status_Reference
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
