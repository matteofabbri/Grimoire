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
	public class Worker_Puerto_Rico_Annual_Tax_DataType : INotifyPropertyChanged
	{
		private Worker_W2PR_DataType[] worker_W2PR_DataField;

		private decimal employer_Sponsored_Health_CareField;

		private bool employer_Sponsored_Health_CareFieldSpecified;

		private decimal charitable_ContributionsField;

		private bool charitable_ContributionsFieldSpecified;

		private decimal commissionsField;

		private bool commissionsFieldSpecified;

		private decimal allowancesField;

		private bool allowancesFieldSpecified;

		private decimal reimbursed_ExpensesField;

		private bool reimbursed_ExpensesFieldSpecified;

		private decimal governmental_Retirement_FundField;

		private bool governmental_Retirement_FundFieldSpecified;

		private decimal contributions_to_CODA_PlansField;

		private bool contributions_to_CODA_PlansFieldSpecified;

		private Box_16_Data_WrapperType[] exempt_Salaries_and_CodesField;

		private decimal contributions_to_SADYM_ProgramField;

		private bool contributions_to_SADYM_ProgramFieldSpecified;

		private decimal uncollected_Social_Security_Tax_on_TipsField;

		private bool uncollected_Social_Security_Tax_on_TipsFieldSpecified;

		private decimal uncollected_Medicare_Tax_on_TipsField;

		private bool uncollected_Medicare_Tax_on_TipsFieldSpecified;

		private string control_NumberField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Worker_W-2PR_Data", Order = 0)]
		public Worker_W2PR_DataType[] Worker_W2PR_Data
		{
			get
			{
				return this.worker_W2PR_DataField;
			}
			set
			{
				this.worker_W2PR_DataField = value;
				this.RaisePropertyChanged("Worker_W2PR_Data");
			}
		}

		[XmlElement(Order = 1)]
		public decimal Employer_Sponsored_Health_Care
		{
			get
			{
				return this.employer_Sponsored_Health_CareField;
			}
			set
			{
				this.employer_Sponsored_Health_CareField = value;
				this.RaisePropertyChanged("Employer_Sponsored_Health_Care");
			}
		}

		[XmlIgnore]
		public bool Employer_Sponsored_Health_CareSpecified
		{
			get
			{
				return this.employer_Sponsored_Health_CareFieldSpecified;
			}
			set
			{
				this.employer_Sponsored_Health_CareFieldSpecified = value;
				this.RaisePropertyChanged("Employer_Sponsored_Health_CareSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public decimal Charitable_Contributions
		{
			get
			{
				return this.charitable_ContributionsField;
			}
			set
			{
				this.charitable_ContributionsField = value;
				this.RaisePropertyChanged("Charitable_Contributions");
			}
		}

		[XmlIgnore]
		public bool Charitable_ContributionsSpecified
		{
			get
			{
				return this.charitable_ContributionsFieldSpecified;
			}
			set
			{
				this.charitable_ContributionsFieldSpecified = value;
				this.RaisePropertyChanged("Charitable_ContributionsSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public decimal Commissions
		{
			get
			{
				return this.commissionsField;
			}
			set
			{
				this.commissionsField = value;
				this.RaisePropertyChanged("Commissions");
			}
		}

		[XmlIgnore]
		public bool CommissionsSpecified
		{
			get
			{
				return this.commissionsFieldSpecified;
			}
			set
			{
				this.commissionsFieldSpecified = value;
				this.RaisePropertyChanged("CommissionsSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public decimal Allowances
		{
			get
			{
				return this.allowancesField;
			}
			set
			{
				this.allowancesField = value;
				this.RaisePropertyChanged("Allowances");
			}
		}

		[XmlIgnore]
		public bool AllowancesSpecified
		{
			get
			{
				return this.allowancesFieldSpecified;
			}
			set
			{
				this.allowancesFieldSpecified = value;
				this.RaisePropertyChanged("AllowancesSpecified");
			}
		}

		[XmlElement(Order = 5)]
		public decimal Reimbursed_Expenses
		{
			get
			{
				return this.reimbursed_ExpensesField;
			}
			set
			{
				this.reimbursed_ExpensesField = value;
				this.RaisePropertyChanged("Reimbursed_Expenses");
			}
		}

		[XmlIgnore]
		public bool Reimbursed_ExpensesSpecified
		{
			get
			{
				return this.reimbursed_ExpensesFieldSpecified;
			}
			set
			{
				this.reimbursed_ExpensesFieldSpecified = value;
				this.RaisePropertyChanged("Reimbursed_ExpensesSpecified");
			}
		}

		[XmlElement(Order = 6)]
		public decimal Governmental_Retirement_Fund
		{
			get
			{
				return this.governmental_Retirement_FundField;
			}
			set
			{
				this.governmental_Retirement_FundField = value;
				this.RaisePropertyChanged("Governmental_Retirement_Fund");
			}
		}

		[XmlIgnore]
		public bool Governmental_Retirement_FundSpecified
		{
			get
			{
				return this.governmental_Retirement_FundFieldSpecified;
			}
			set
			{
				this.governmental_Retirement_FundFieldSpecified = value;
				this.RaisePropertyChanged("Governmental_Retirement_FundSpecified");
			}
		}

		[XmlElement(Order = 7)]
		public decimal Contributions_to_CODA_Plans
		{
			get
			{
				return this.contributions_to_CODA_PlansField;
			}
			set
			{
				this.contributions_to_CODA_PlansField = value;
				this.RaisePropertyChanged("Contributions_to_CODA_Plans");
			}
		}

		[XmlIgnore]
		public bool Contributions_to_CODA_PlansSpecified
		{
			get
			{
				return this.contributions_to_CODA_PlansFieldSpecified;
			}
			set
			{
				this.contributions_to_CODA_PlansFieldSpecified = value;
				this.RaisePropertyChanged("Contributions_to_CODA_PlansSpecified");
			}
		}

		[XmlElement("Exempt_Salaries_and_Codes", Order = 8)]
		public Box_16_Data_WrapperType[] Exempt_Salaries_and_Codes
		{
			get
			{
				return this.exempt_Salaries_and_CodesField;
			}
			set
			{
				this.exempt_Salaries_and_CodesField = value;
				this.RaisePropertyChanged("Exempt_Salaries_and_Codes");
			}
		}

		[XmlElement(Order = 9)]
		public decimal Contributions_to_SADYM_Program
		{
			get
			{
				return this.contributions_to_SADYM_ProgramField;
			}
			set
			{
				this.contributions_to_SADYM_ProgramField = value;
				this.RaisePropertyChanged("Contributions_to_SADYM_Program");
			}
		}

		[XmlIgnore]
		public bool Contributions_to_SADYM_ProgramSpecified
		{
			get
			{
				return this.contributions_to_SADYM_ProgramFieldSpecified;
			}
			set
			{
				this.contributions_to_SADYM_ProgramFieldSpecified = value;
				this.RaisePropertyChanged("Contributions_to_SADYM_ProgramSpecified");
			}
		}

		[XmlElement(Order = 10)]
		public decimal Uncollected_Social_Security_Tax_on_Tips
		{
			get
			{
				return this.uncollected_Social_Security_Tax_on_TipsField;
			}
			set
			{
				this.uncollected_Social_Security_Tax_on_TipsField = value;
				this.RaisePropertyChanged("Uncollected_Social_Security_Tax_on_Tips");
			}
		}

		[XmlIgnore]
		public bool Uncollected_Social_Security_Tax_on_TipsSpecified
		{
			get
			{
				return this.uncollected_Social_Security_Tax_on_TipsFieldSpecified;
			}
			set
			{
				this.uncollected_Social_Security_Tax_on_TipsFieldSpecified = value;
				this.RaisePropertyChanged("Uncollected_Social_Security_Tax_on_TipsSpecified");
			}
		}

		[XmlElement(Order = 11)]
		public decimal Uncollected_Medicare_Tax_on_Tips
		{
			get
			{
				return this.uncollected_Medicare_Tax_on_TipsField;
			}
			set
			{
				this.uncollected_Medicare_Tax_on_TipsField = value;
				this.RaisePropertyChanged("Uncollected_Medicare_Tax_on_Tips");
			}
		}

		[XmlIgnore]
		public bool Uncollected_Medicare_Tax_on_TipsSpecified
		{
			get
			{
				return this.uncollected_Medicare_Tax_on_TipsFieldSpecified;
			}
			set
			{
				this.uncollected_Medicare_Tax_on_TipsFieldSpecified = value;
				this.RaisePropertyChanged("Uncollected_Medicare_Tax_on_TipsSpecified");
			}
		}

		[XmlElement(Order = 12)]
		public string Control_Number
		{
			get
			{
				return this.control_NumberField;
			}
			set
			{
				this.control_NumberField = value;
				this.RaisePropertyChanged("Control_Number");
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
