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
	public class LoanType : INotifyPropertyChanged
	{
		private LoanObjectType loan_ReferenceField;

		private Loan_DataType loan_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public LoanObjectType Loan_Reference
		{
			get
			{
				return this.loan_ReferenceField;
			}
			set
			{
				this.loan_ReferenceField = value;
				this.RaisePropertyChanged("Loan_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Loan_DataType Loan_Data
		{
			get
			{
				return this.loan_DataField;
			}
			set
			{
				this.loan_DataField = value;
				this.RaisePropertyChanged("Loan_Data");
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
