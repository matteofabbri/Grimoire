using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.Payroll.Interface
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(TypeName = "Payee_W-4_Withholding_DataType", Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Payee_W4_Withholding_DataType : INotifyPropertyChanged
	{
		private DateTime creation_Date_TimeField;

		private bool creation_Date_TimeFieldSpecified;

		private WorkerObjectType last_Updated_By_Worker_ReferenceField;

		private decimal number_Of_AllowancesField;

		private bool number_Of_AllowancesFieldSpecified;

		private decimal additional_AmountField;

		private bool additional_AmountFieldSpecified;

		private bool exemptField;

		private bool exemptFieldSpecified;

		private bool nonresident_AlienField;

		private bool nonresident_AlienFieldSpecified;

		private bool last_Name_Differs_From_SSField;

		private bool last_Name_Differs_From_SSFieldSpecified;

		private DateTime eSS_Electronic_Signature_ConfirmationField;

		private bool eSS_Electronic_Signature_ConfirmationFieldSpecified;

		private bool lock_In_LetterField;

		private bool lock_In_LetterFieldSpecified;

		private Payroll_Withholding_StatusObjectType payroll_Marital_Status_ReferenceField;

		private CurrencyObjectType currency_ReferenceField;

		private DateTime effective_DateField;

		private bool effective_DateFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public DateTime Creation_Date_Time
		{
			get
			{
				return this.creation_Date_TimeField;
			}
			set
			{
				this.creation_Date_TimeField = value;
				this.RaisePropertyChanged("Creation_Date_Time");
			}
		}

		[XmlIgnore]
		public bool Creation_Date_TimeSpecified
		{
			get
			{
				return this.creation_Date_TimeFieldSpecified;
			}
			set
			{
				this.creation_Date_TimeFieldSpecified = value;
				this.RaisePropertyChanged("Creation_Date_TimeSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public WorkerObjectType Last_Updated_By_Worker_Reference
		{
			get
			{
				return this.last_Updated_By_Worker_ReferenceField;
			}
			set
			{
				this.last_Updated_By_Worker_ReferenceField = value;
				this.RaisePropertyChanged("Last_Updated_By_Worker_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public decimal Number_Of_Allowances
		{
			get
			{
				return this.number_Of_AllowancesField;
			}
			set
			{
				this.number_Of_AllowancesField = value;
				this.RaisePropertyChanged("Number_Of_Allowances");
			}
		}

		[XmlIgnore]
		public bool Number_Of_AllowancesSpecified
		{
			get
			{
				return this.number_Of_AllowancesFieldSpecified;
			}
			set
			{
				this.number_Of_AllowancesFieldSpecified = value;
				this.RaisePropertyChanged("Number_Of_AllowancesSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public decimal Additional_Amount
		{
			get
			{
				return this.additional_AmountField;
			}
			set
			{
				this.additional_AmountField = value;
				this.RaisePropertyChanged("Additional_Amount");
			}
		}

		[XmlIgnore]
		public bool Additional_AmountSpecified
		{
			get
			{
				return this.additional_AmountFieldSpecified;
			}
			set
			{
				this.additional_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Additional_AmountSpecified");
			}
		}

		[XmlElement(Order = 4)]
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

		[XmlElement(Order = 5)]
		public bool Nonresident_Alien
		{
			get
			{
				return this.nonresident_AlienField;
			}
			set
			{
				this.nonresident_AlienField = value;
				this.RaisePropertyChanged("Nonresident_Alien");
			}
		}

		[XmlIgnore]
		public bool Nonresident_AlienSpecified
		{
			get
			{
				return this.nonresident_AlienFieldSpecified;
			}
			set
			{
				this.nonresident_AlienFieldSpecified = value;
				this.RaisePropertyChanged("Nonresident_AlienSpecified");
			}
		}

		[XmlElement(Order = 6)]
		public bool Last_Name_Differs_From_SS
		{
			get
			{
				return this.last_Name_Differs_From_SSField;
			}
			set
			{
				this.last_Name_Differs_From_SSField = value;
				this.RaisePropertyChanged("Last_Name_Differs_From_SS");
			}
		}

		[XmlIgnore]
		public bool Last_Name_Differs_From_SSSpecified
		{
			get
			{
				return this.last_Name_Differs_From_SSFieldSpecified;
			}
			set
			{
				this.last_Name_Differs_From_SSFieldSpecified = value;
				this.RaisePropertyChanged("Last_Name_Differs_From_SSSpecified");
			}
		}

		[XmlElement(Order = 7)]
		public DateTime ESS_Electronic_Signature_Confirmation
		{
			get
			{
				return this.eSS_Electronic_Signature_ConfirmationField;
			}
			set
			{
				this.eSS_Electronic_Signature_ConfirmationField = value;
				this.RaisePropertyChanged("ESS_Electronic_Signature_Confirmation");
			}
		}

		[XmlIgnore]
		public bool ESS_Electronic_Signature_ConfirmationSpecified
		{
			get
			{
				return this.eSS_Electronic_Signature_ConfirmationFieldSpecified;
			}
			set
			{
				this.eSS_Electronic_Signature_ConfirmationFieldSpecified = value;
				this.RaisePropertyChanged("ESS_Electronic_Signature_ConfirmationSpecified");
			}
		}

		[XmlElement(Order = 8)]
		public bool Lock_In_Letter
		{
			get
			{
				return this.lock_In_LetterField;
			}
			set
			{
				this.lock_In_LetterField = value;
				this.RaisePropertyChanged("Lock_In_Letter");
			}
		}

		[XmlIgnore]
		public bool Lock_In_LetterSpecified
		{
			get
			{
				return this.lock_In_LetterFieldSpecified;
			}
			set
			{
				this.lock_In_LetterFieldSpecified = value;
				this.RaisePropertyChanged("Lock_In_LetterSpecified");
			}
		}

		[XmlElement(Order = 9)]
		public Payroll_Withholding_StatusObjectType Payroll_Marital_Status_Reference
		{
			get
			{
				return this.payroll_Marital_Status_ReferenceField;
			}
			set
			{
				this.payroll_Marital_Status_ReferenceField = value;
				this.RaisePropertyChanged("Payroll_Marital_Status_Reference");
			}
		}

		[XmlElement(Order = 10)]
		public CurrencyObjectType Currency_Reference
		{
			get
			{
				return this.currency_ReferenceField;
			}
			set
			{
				this.currency_ReferenceField = value;
				this.RaisePropertyChanged("Currency_Reference");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified, DataType = "date")]
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
