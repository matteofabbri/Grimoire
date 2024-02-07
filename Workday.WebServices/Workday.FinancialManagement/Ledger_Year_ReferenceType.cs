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
	public class Ledger_Year_ReferenceType : INotifyPropertyChanged
	{
		private Ledger_ReferenceType ledger_Reference_DataField;

		private Fiscal_YearObjectType fiscal_Year_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Ledger_ReferenceType Ledger_Reference_Data
		{
			get
			{
				return this.ledger_Reference_DataField;
			}
			set
			{
				this.ledger_Reference_DataField = value;
				this.RaisePropertyChanged("Ledger_Reference_Data");
			}
		}

		[XmlElement(Order = 1)]
		public Fiscal_YearObjectType Fiscal_Year_Reference
		{
			get
			{
				return this.fiscal_Year_ReferenceField;
			}
			set
			{
				this.fiscal_Year_ReferenceField = value;
				this.RaisePropertyChanged("Fiscal_Year_Reference");
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
