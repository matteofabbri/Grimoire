using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Payroll.Gbr
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Payee_Tax_Code_DataType : INotifyPropertyChanged
	{
		private WorkerObjectType worker_ReferenceField;

		private DateTime effective_As_OfField;

		private CompanyObjectType company_ReferenceField;

		private Payroll_Constant_TextObjectType tax_Code_Notification_Source_ReferenceField;

		private Calendar_YearObjectType tax_Year_End_ReferenceField;

		private DateTime p45_Leaving_DateField;

		private bool p45_Leaving_DateFieldSpecified;

		private decimal previous_Employment_PayField;

		private bool previous_Employment_PayFieldSpecified;

		private decimal previous_Employment_TaxField;

		private bool previous_Employment_TaxFieldSpecified;

		private Payroll_Constant_TextObjectType starter_Checklist_Statement_ReferenceField;

		private Payroll_Constant_TextObjectType tax_Regime_ReferenceField;

		private string tax_CodeField;

		private bool w1_M1_Tax_BasisField;

		private bool w1_M1_Tax_BasisFieldSpecified;

		private DateTime p45_Leaver_Issue_DateField;

		private bool p45_Leaver_Issue_DateFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public WorkerObjectType Worker_Reference
		{
			get
			{
				return this.worker_ReferenceField;
			}
			set
			{
				this.worker_ReferenceField = value;
				this.RaisePropertyChanged("Worker_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 1)]
		public DateTime Effective_As_Of
		{
			get
			{
				return this.effective_As_OfField;
			}
			set
			{
				this.effective_As_OfField = value;
				this.RaisePropertyChanged("Effective_As_Of");
			}
		}

		[XmlElement(Order = 2)]
		public CompanyObjectType Company_Reference
		{
			get
			{
				return this.company_ReferenceField;
			}
			set
			{
				this.company_ReferenceField = value;
				this.RaisePropertyChanged("Company_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public Payroll_Constant_TextObjectType Tax_Code_Notification_Source_Reference
		{
			get
			{
				return this.tax_Code_Notification_Source_ReferenceField;
			}
			set
			{
				this.tax_Code_Notification_Source_ReferenceField = value;
				this.RaisePropertyChanged("Tax_Code_Notification_Source_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public Calendar_YearObjectType Tax_Year_End_Reference
		{
			get
			{
				return this.tax_Year_End_ReferenceField;
			}
			set
			{
				this.tax_Year_End_ReferenceField = value;
				this.RaisePropertyChanged("Tax_Year_End_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 5)]
		public DateTime P45_Leaving_Date
		{
			get
			{
				return this.p45_Leaving_DateField;
			}
			set
			{
				this.p45_Leaving_DateField = value;
				this.RaisePropertyChanged("P45_Leaving_Date");
			}
		}

		[XmlIgnore]
		public bool P45_Leaving_DateSpecified
		{
			get
			{
				return this.p45_Leaving_DateFieldSpecified;
			}
			set
			{
				this.p45_Leaving_DateFieldSpecified = value;
				this.RaisePropertyChanged("P45_Leaving_DateSpecified");
			}
		}

		[XmlElement(Order = 6)]
		public decimal Previous_Employment_Pay
		{
			get
			{
				return this.previous_Employment_PayField;
			}
			set
			{
				this.previous_Employment_PayField = value;
				this.RaisePropertyChanged("Previous_Employment_Pay");
			}
		}

		[XmlIgnore]
		public bool Previous_Employment_PaySpecified
		{
			get
			{
				return this.previous_Employment_PayFieldSpecified;
			}
			set
			{
				this.previous_Employment_PayFieldSpecified = value;
				this.RaisePropertyChanged("Previous_Employment_PaySpecified");
			}
		}

		[XmlElement(Order = 7)]
		public decimal Previous_Employment_Tax
		{
			get
			{
				return this.previous_Employment_TaxField;
			}
			set
			{
				this.previous_Employment_TaxField = value;
				this.RaisePropertyChanged("Previous_Employment_Tax");
			}
		}

		[XmlIgnore]
		public bool Previous_Employment_TaxSpecified
		{
			get
			{
				return this.previous_Employment_TaxFieldSpecified;
			}
			set
			{
				this.previous_Employment_TaxFieldSpecified = value;
				this.RaisePropertyChanged("Previous_Employment_TaxSpecified");
			}
		}

		[XmlElement(Order = 8)]
		public Payroll_Constant_TextObjectType Starter_Checklist_Statement_Reference
		{
			get
			{
				return this.starter_Checklist_Statement_ReferenceField;
			}
			set
			{
				this.starter_Checklist_Statement_ReferenceField = value;
				this.RaisePropertyChanged("Starter_Checklist_Statement_Reference");
			}
		}

		[XmlElement(Order = 9)]
		public Payroll_Constant_TextObjectType Tax_Regime_Reference
		{
			get
			{
				return this.tax_Regime_ReferenceField;
			}
			set
			{
				this.tax_Regime_ReferenceField = value;
				this.RaisePropertyChanged("Tax_Regime_Reference");
			}
		}

		[XmlElement(Order = 10)]
		public string Tax_Code
		{
			get
			{
				return this.tax_CodeField;
			}
			set
			{
				this.tax_CodeField = value;
				this.RaisePropertyChanged("Tax_Code");
			}
		}

		[XmlElement(Order = 11)]
		public bool W1_M1_Tax_Basis
		{
			get
			{
				return this.w1_M1_Tax_BasisField;
			}
			set
			{
				this.w1_M1_Tax_BasisField = value;
				this.RaisePropertyChanged("W1_M1_Tax_Basis");
			}
		}

		[XmlIgnore]
		public bool W1_M1_Tax_BasisSpecified
		{
			get
			{
				return this.w1_M1_Tax_BasisFieldSpecified;
			}
			set
			{
				this.w1_M1_Tax_BasisFieldSpecified = value;
				this.RaisePropertyChanged("W1_M1_Tax_BasisSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 12)]
		public DateTime P45_Leaver_Issue_Date
		{
			get
			{
				return this.p45_Leaver_Issue_DateField;
			}
			set
			{
				this.p45_Leaver_Issue_DateField = value;
				this.RaisePropertyChanged("P45_Leaver_Issue_Date");
			}
		}

		[XmlIgnore]
		public bool P45_Leaver_Issue_DateSpecified
		{
			get
			{
				return this.p45_Leaver_Issue_DateFieldSpecified;
			}
			set
			{
				this.p45_Leaver_Issue_DateFieldSpecified = value;
				this.RaisePropertyChanged("P45_Leaver_Issue_DateSpecified");
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
