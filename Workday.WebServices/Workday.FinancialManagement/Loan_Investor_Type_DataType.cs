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
	public class Loan_Investor_Type_DataType : INotifyPropertyChanged
	{
		private string loan_Investor_Type_IDField;

		private string loan_Investor_Type_NameField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Loan_Investor_Type_ID
		{
			get
			{
				return this.loan_Investor_Type_IDField;
			}
			set
			{
				this.loan_Investor_Type_IDField = value;
				this.RaisePropertyChanged("Loan_Investor_Type_ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Loan_Investor_Type_Name
		{
			get
			{
				return this.loan_Investor_Type_NameField;
			}
			set
			{
				this.loan_Investor_Type_NameField = value;
				this.RaisePropertyChanged("Loan_Investor_Type_Name");
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
