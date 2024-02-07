using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.Payroll.Interface
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Payee_T1_Withholding_DataType : INotifyPropertyChanged
	{
		private DateTime creation_Date_TimeField;

		private bool creation_Date_TimeFieldSpecified;

		private WorkerObjectType last_Updated_By_Worker_ReferenceField;

		private decimal basic_Personal_AmountField;

		private bool basic_Personal_AmountFieldSpecified;

		private decimal child_AmountField;

		private bool child_AmountFieldSpecified;

		private decimal age_AmountField;

		private bool age_AmountFieldSpecified;

		private decimal pension_Income_AmountField;

		private bool pension_Income_AmountFieldSpecified;

		private decimal education_AmountField;

		private bool education_AmountFieldSpecified;

		private decimal disability_AmountField;

		private bool disability_AmountFieldSpecified;

		private decimal spouse_AmountField;

		private bool spouse_AmountFieldSpecified;

		private decimal dependent_AmountField;

		private bool dependent_AmountFieldSpecified;

		private decimal caregiver_AmountField;

		private bool caregiver_AmountFieldSpecified;

		private decimal infirm_Dependents_AmountField;

		private bool infirm_Dependents_AmountFieldSpecified;

		private decimal amount_Transferred_From_SpouseField;

		private bool amount_Transferred_From_SpouseFieldSpecified;

		private decimal amount_Transferred_from_DependentsField;

		private bool amount_Transferred_from_DependentsFieldSpecified;

		private decimal total_Claim_AmountField;

		private bool total_Claim_AmountFieldSpecified;

		private bool more_than_One_EmployerField;

		private bool more_than_One_EmployerFieldSpecified;

		private bool total_Income_Less_Than_Claim_AmountField;

		private bool total_Income_Less_Than_Claim_AmountFieldSpecified;

		private decimal additional_AmountField;

		private bool additional_AmountFieldSpecified;

		private decimal prescribed_Zone_AmountField;

		private bool prescribed_Zone_AmountFieldSpecified;

		private DateTime eSS_Electronic_Signature_ConfirmationField;

		private bool eSS_Electronic_Signature_ConfirmationFieldSpecified;

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
		public decimal Basic_Personal_Amount
		{
			get
			{
				return this.basic_Personal_AmountField;
			}
			set
			{
				this.basic_Personal_AmountField = value;
				this.RaisePropertyChanged("Basic_Personal_Amount");
			}
		}

		[XmlIgnore]
		public bool Basic_Personal_AmountSpecified
		{
			get
			{
				return this.basic_Personal_AmountFieldSpecified;
			}
			set
			{
				this.basic_Personal_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Basic_Personal_AmountSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public decimal Child_Amount
		{
			get
			{
				return this.child_AmountField;
			}
			set
			{
				this.child_AmountField = value;
				this.RaisePropertyChanged("Child_Amount");
			}
		}

		[XmlIgnore]
		public bool Child_AmountSpecified
		{
			get
			{
				return this.child_AmountFieldSpecified;
			}
			set
			{
				this.child_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Child_AmountSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public decimal Age_Amount
		{
			get
			{
				return this.age_AmountField;
			}
			set
			{
				this.age_AmountField = value;
				this.RaisePropertyChanged("Age_Amount");
			}
		}

		[XmlIgnore]
		public bool Age_AmountSpecified
		{
			get
			{
				return this.age_AmountFieldSpecified;
			}
			set
			{
				this.age_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Age_AmountSpecified");
			}
		}

		[XmlElement(Order = 5)]
		public decimal Pension_Income_Amount
		{
			get
			{
				return this.pension_Income_AmountField;
			}
			set
			{
				this.pension_Income_AmountField = value;
				this.RaisePropertyChanged("Pension_Income_Amount");
			}
		}

		[XmlIgnore]
		public bool Pension_Income_AmountSpecified
		{
			get
			{
				return this.pension_Income_AmountFieldSpecified;
			}
			set
			{
				this.pension_Income_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Pension_Income_AmountSpecified");
			}
		}

		[XmlElement(Order = 6)]
		public decimal Education_Amount
		{
			get
			{
				return this.education_AmountField;
			}
			set
			{
				this.education_AmountField = value;
				this.RaisePropertyChanged("Education_Amount");
			}
		}

		[XmlIgnore]
		public bool Education_AmountSpecified
		{
			get
			{
				return this.education_AmountFieldSpecified;
			}
			set
			{
				this.education_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Education_AmountSpecified");
			}
		}

		[XmlElement(Order = 7)]
		public decimal Disability_Amount
		{
			get
			{
				return this.disability_AmountField;
			}
			set
			{
				this.disability_AmountField = value;
				this.RaisePropertyChanged("Disability_Amount");
			}
		}

		[XmlIgnore]
		public bool Disability_AmountSpecified
		{
			get
			{
				return this.disability_AmountFieldSpecified;
			}
			set
			{
				this.disability_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Disability_AmountSpecified");
			}
		}

		[XmlElement(Order = 8)]
		public decimal Spouse_Amount
		{
			get
			{
				return this.spouse_AmountField;
			}
			set
			{
				this.spouse_AmountField = value;
				this.RaisePropertyChanged("Spouse_Amount");
			}
		}

		[XmlIgnore]
		public bool Spouse_AmountSpecified
		{
			get
			{
				return this.spouse_AmountFieldSpecified;
			}
			set
			{
				this.spouse_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Spouse_AmountSpecified");
			}
		}

		[XmlElement(Order = 9)]
		public decimal Dependent_Amount
		{
			get
			{
				return this.dependent_AmountField;
			}
			set
			{
				this.dependent_AmountField = value;
				this.RaisePropertyChanged("Dependent_Amount");
			}
		}

		[XmlIgnore]
		public bool Dependent_AmountSpecified
		{
			get
			{
				return this.dependent_AmountFieldSpecified;
			}
			set
			{
				this.dependent_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Dependent_AmountSpecified");
			}
		}

		[XmlElement(Order = 10)]
		public decimal Caregiver_Amount
		{
			get
			{
				return this.caregiver_AmountField;
			}
			set
			{
				this.caregiver_AmountField = value;
				this.RaisePropertyChanged("Caregiver_Amount");
			}
		}

		[XmlIgnore]
		public bool Caregiver_AmountSpecified
		{
			get
			{
				return this.caregiver_AmountFieldSpecified;
			}
			set
			{
				this.caregiver_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Caregiver_AmountSpecified");
			}
		}

		[XmlElement(Order = 11)]
		public decimal Infirm_Dependents_Amount
		{
			get
			{
				return this.infirm_Dependents_AmountField;
			}
			set
			{
				this.infirm_Dependents_AmountField = value;
				this.RaisePropertyChanged("Infirm_Dependents_Amount");
			}
		}

		[XmlIgnore]
		public bool Infirm_Dependents_AmountSpecified
		{
			get
			{
				return this.infirm_Dependents_AmountFieldSpecified;
			}
			set
			{
				this.infirm_Dependents_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Infirm_Dependents_AmountSpecified");
			}
		}

		[XmlElement(Order = 12)]
		public decimal Amount_Transferred_From_Spouse
		{
			get
			{
				return this.amount_Transferred_From_SpouseField;
			}
			set
			{
				this.amount_Transferred_From_SpouseField = value;
				this.RaisePropertyChanged("Amount_Transferred_From_Spouse");
			}
		}

		[XmlIgnore]
		public bool Amount_Transferred_From_SpouseSpecified
		{
			get
			{
				return this.amount_Transferred_From_SpouseFieldSpecified;
			}
			set
			{
				this.amount_Transferred_From_SpouseFieldSpecified = value;
				this.RaisePropertyChanged("Amount_Transferred_From_SpouseSpecified");
			}
		}

		[XmlElement(Order = 13)]
		public decimal Amount_Transferred_from_Dependents
		{
			get
			{
				return this.amount_Transferred_from_DependentsField;
			}
			set
			{
				this.amount_Transferred_from_DependentsField = value;
				this.RaisePropertyChanged("Amount_Transferred_from_Dependents");
			}
		}

		[XmlIgnore]
		public bool Amount_Transferred_from_DependentsSpecified
		{
			get
			{
				return this.amount_Transferred_from_DependentsFieldSpecified;
			}
			set
			{
				this.amount_Transferred_from_DependentsFieldSpecified = value;
				this.RaisePropertyChanged("Amount_Transferred_from_DependentsSpecified");
			}
		}

		[XmlElement(Order = 14)]
		public decimal Total_Claim_Amount
		{
			get
			{
				return this.total_Claim_AmountField;
			}
			set
			{
				this.total_Claim_AmountField = value;
				this.RaisePropertyChanged("Total_Claim_Amount");
			}
		}

		[XmlIgnore]
		public bool Total_Claim_AmountSpecified
		{
			get
			{
				return this.total_Claim_AmountFieldSpecified;
			}
			set
			{
				this.total_Claim_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Total_Claim_AmountSpecified");
			}
		}

		[XmlElement(Order = 15)]
		public bool More_than_One_Employer
		{
			get
			{
				return this.more_than_One_EmployerField;
			}
			set
			{
				this.more_than_One_EmployerField = value;
				this.RaisePropertyChanged("More_than_One_Employer");
			}
		}

		[XmlIgnore]
		public bool More_than_One_EmployerSpecified
		{
			get
			{
				return this.more_than_One_EmployerFieldSpecified;
			}
			set
			{
				this.more_than_One_EmployerFieldSpecified = value;
				this.RaisePropertyChanged("More_than_One_EmployerSpecified");
			}
		}

		[XmlElement(Order = 16)]
		public bool Total_Income_Less_Than_Claim_Amount
		{
			get
			{
				return this.total_Income_Less_Than_Claim_AmountField;
			}
			set
			{
				this.total_Income_Less_Than_Claim_AmountField = value;
				this.RaisePropertyChanged("Total_Income_Less_Than_Claim_Amount");
			}
		}

		[XmlIgnore]
		public bool Total_Income_Less_Than_Claim_AmountSpecified
		{
			get
			{
				return this.total_Income_Less_Than_Claim_AmountFieldSpecified;
			}
			set
			{
				this.total_Income_Less_Than_Claim_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Total_Income_Less_Than_Claim_AmountSpecified");
			}
		}

		[XmlElement(Order = 17)]
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

		[XmlElement(Order = 18)]
		public decimal Prescribed_Zone_Amount
		{
			get
			{
				return this.prescribed_Zone_AmountField;
			}
			set
			{
				this.prescribed_Zone_AmountField = value;
				this.RaisePropertyChanged("Prescribed_Zone_Amount");
			}
		}

		[XmlIgnore]
		public bool Prescribed_Zone_AmountSpecified
		{
			get
			{
				return this.prescribed_Zone_AmountFieldSpecified;
			}
			set
			{
				this.prescribed_Zone_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Prescribed_Zone_AmountSpecified");
			}
		}

		[XmlElement(Order = 19)]
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

		[XmlElement(Order = 20)]
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
