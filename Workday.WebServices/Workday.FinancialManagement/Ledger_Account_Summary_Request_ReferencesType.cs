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
	public class Ledger_Account_Summary_Request_ReferencesType : INotifyPropertyChanged
	{
		private Ledger_Account_SummaryObjectType[] ledger_Account_Summary_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Ledger_Account_Summary_Reference", Order = 0)]
		public Ledger_Account_SummaryObjectType[] Ledger_Account_Summary_Reference
		{
			get
			{
				return this.ledger_Account_Summary_ReferenceField;
			}
			set
			{
				this.ledger_Account_Summary_ReferenceField = value;
				this.RaisePropertyChanged("Ledger_Account_Summary_Reference");
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
