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
	public class Loan_Referral_TypeType : INotifyPropertyChanged
	{
		private Loan_Referral_TypeObjectType loan_Referral_Type_ReferenceField;

		private Loan_Referral_Type_DataType[] loan_Referral_Type_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Loan_Referral_TypeObjectType Loan_Referral_Type_Reference
		{
			get
			{
				return this.loan_Referral_Type_ReferenceField;
			}
			set
			{
				this.loan_Referral_Type_ReferenceField = value;
				this.RaisePropertyChanged("Loan_Referral_Type_Reference");
			}
		}

		[XmlElement("Loan_Referral_Type_Data", Order = 1)]
		public Loan_Referral_Type_DataType[] Loan_Referral_Type_Data
		{
			get
			{
				return this.loan_Referral_Type_DataField;
			}
			set
			{
				this.loan_Referral_Type_DataField = value;
				this.RaisePropertyChanged("Loan_Referral_Type_Data");
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
