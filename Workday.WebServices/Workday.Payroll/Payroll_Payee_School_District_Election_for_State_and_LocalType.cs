using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Payroll
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Payroll_Payee_School_District_Election_for_State_and_LocalType : INotifyPropertyChanged
	{
		private DateTime effective_DateField;

		private bool effective_DateFieldSpecified;

		private Payroll_Local_AuthorityObjectType payroll_Local_School_District_Authority_ReferenceField;

		private bool exemptField;

		private bool exemptFieldSpecified;

		private Payroll_Constant_TextObjectType exempt_Reason_ReferenceField;

		private decimal previous_Employer_Deducted_AmountField;

		private bool previous_Employer_Deducted_AmountFieldSpecified;

		private bool inactivate_State_TaxField;

		private bool inactivate_State_TaxFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(DataType = "date", Order = 0)]
		public DateTime Effective_Date
		{
			get
			{
				return this.effective_DateField;
			}
			set
			{
				this.effective_DateField = value;
				this.RaisePropertyChanged("Effective_Date");
			}
		}

		[XmlIgnore]
		public bool Effective_DateSpecified
		{
			get
			{
				return this.effective_DateFieldSpecified;
			}
			set
			{
				this.effective_DateFieldSpecified = value;
				this.RaisePropertyChanged("Effective_DateSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public Payroll_Local_AuthorityObjectType Payroll_Local_School_District_Authority_Reference
		{
			get
			{
				return this.payroll_Local_School_District_Authority_ReferenceField;
			}
			set
			{
				this.payroll_Local_School_District_Authority_ReferenceField = value;
				this.RaisePropertyChanged("Payroll_Local_School_District_Authority_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public bool Exempt
		{
			get
			{
				return this.exemptField;
			}
			set
			{
				this.exemptField = value;
				this.RaisePropertyChanged("Exempt");
			}
		}

		[XmlIgnore]
		public bool ExemptSpecified
		{
			get
			{
				return this.exemptFieldSpecified;
			}
			set
			{
				this.exemptFieldSpecified = value;
				this.RaisePropertyChanged("ExemptSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public Payroll_Constant_TextObjectType Exempt_Reason_Reference
		{
			get
			{
				return this.exempt_Reason_ReferenceField;
			}
			set
			{
				this.exempt_Reason_ReferenceField = value;
				this.RaisePropertyChanged("Exempt_Reason_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public decimal Previous_Employer_Deducted_Amount
		{
			get
			{
				return this.previous_Employer_Deducted_AmountField;
			}
			set
			{
				this.previous_Employer_Deducted_AmountField = value;
				this.RaisePropertyChanged("Previous_Employer_Deducted_Amount");
			}
		}

		[XmlIgnore]
		public bool Previous_Employer_Deducted_AmountSpecified
		{
			get
			{
				return this.previous_Employer_Deducted_AmountFieldSpecified;
			}
			set
			{
				this.previous_Employer_Deducted_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Previous_Employer_Deducted_AmountSpecified");
			}
		}

		[XmlElement(Order = 5)]
		public bool Inactivate_State_Tax
		{
			get
			{
				return this.inactivate_State_TaxField;
			}
			set
			{
				this.inactivate_State_TaxField = value;
				this.RaisePropertyChanged("Inactivate_State_Tax");
			}
		}

		[XmlIgnore]
		public bool Inactivate_State_TaxSpecified
		{
			get
			{
				return this.inactivate_State_TaxFieldSpecified;
			}
			set
			{
				this.inactivate_State_TaxFieldSpecified = value;
				this.RaisePropertyChanged("Inactivate_State_TaxSpecified");
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
