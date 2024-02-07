using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.FinancialAid
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class NSLDS_Pell_Grant_DataType : INotifyPropertyChanged
	{
		private Financial_Aid_Award_YearObjectType award_Year_ReferenceField;

		private decimal pell_Sequence_NumberField;

		private bool pell_Sequence_NumberFieldSpecified;

		private decimal eFCField;

		private bool eFCFieldSpecified;

		private string pell_OPEIDField;

		private decimal transaction_NumberField;

		private bool transaction_NumberFieldSpecified;

		private DateTime pell_Last_Update_DateField;

		private bool pell_Last_Update_DateFieldSpecified;

		private decimal scheduled_Award_AmountField;

		private bool scheduled_Award_AmountFieldSpecified;

		private decimal pell_Amount_Paid_to_DateField;

		private bool pell_Amount_Paid_to_DateFieldSpecified;

		private decimal pell_Percent_Scheduled_Award_Used_by_Award_YearField;

		private bool pell_Percent_Scheduled_Award_Used_by_Award_YearFieldSpecified;

		private decimal pell_Award_AmountField;

		private bool pell_Award_AmountFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Financial_Aid_Award_YearObjectType Award_Year_Reference
		{
			get
			{
				return this.award_Year_ReferenceField;
			}
			set
			{
				this.award_Year_ReferenceField = value;
				this.RaisePropertyChanged("Award_Year_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public decimal Pell_Sequence_Number
		{
			get
			{
				return this.pell_Sequence_NumberField;
			}
			set
			{
				this.pell_Sequence_NumberField = value;
				this.RaisePropertyChanged("Pell_Sequence_Number");
			}
		}

		[XmlIgnore]
		public bool Pell_Sequence_NumberSpecified
		{
			get
			{
				return this.pell_Sequence_NumberFieldSpecified;
			}
			set
			{
				this.pell_Sequence_NumberFieldSpecified = value;
				this.RaisePropertyChanged("Pell_Sequence_NumberSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public decimal EFC
		{
			get
			{
				return this.eFCField;
			}
			set
			{
				this.eFCField = value;
				this.RaisePropertyChanged("EFC");
			}
		}

		[XmlIgnore]
		public bool EFCSpecified
		{
			get
			{
				return this.eFCFieldSpecified;
			}
			set
			{
				this.eFCFieldSpecified = value;
				this.RaisePropertyChanged("EFCSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public string Pell_OPEID
		{
			get
			{
				return this.pell_OPEIDField;
			}
			set
			{
				this.pell_OPEIDField = value;
				this.RaisePropertyChanged("Pell_OPEID");
			}
		}

		[XmlElement(Order = 4)]
		public decimal Transaction_Number
		{
			get
			{
				return this.transaction_NumberField;
			}
			set
			{
				this.transaction_NumberField = value;
				this.RaisePropertyChanged("Transaction_Number");
			}
		}

		[XmlIgnore]
		public bool Transaction_NumberSpecified
		{
			get
			{
				return this.transaction_NumberFieldSpecified;
			}
			set
			{
				this.transaction_NumberFieldSpecified = value;
				this.RaisePropertyChanged("Transaction_NumberSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 5)]
		public DateTime Pell_Last_Update_Date
		{
			get
			{
				return this.pell_Last_Update_DateField;
			}
			set
			{
				this.pell_Last_Update_DateField = value;
				this.RaisePropertyChanged("Pell_Last_Update_Date");
			}
		}

		[XmlIgnore]
		public bool Pell_Last_Update_DateSpecified
		{
			get
			{
				return this.pell_Last_Update_DateFieldSpecified;
			}
			set
			{
				this.pell_Last_Update_DateFieldSpecified = value;
				this.RaisePropertyChanged("Pell_Last_Update_DateSpecified");
			}
		}

		[XmlElement(Order = 6)]
		public decimal Scheduled_Award_Amount
		{
			get
			{
				return this.scheduled_Award_AmountField;
			}
			set
			{
				this.scheduled_Award_AmountField = value;
				this.RaisePropertyChanged("Scheduled_Award_Amount");
			}
		}

		[XmlIgnore]
		public bool Scheduled_Award_AmountSpecified
		{
			get
			{
				return this.scheduled_Award_AmountFieldSpecified;
			}
			set
			{
				this.scheduled_Award_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Scheduled_Award_AmountSpecified");
			}
		}

		[XmlElement(Order = 7)]
		public decimal Pell_Amount_Paid_to_Date
		{
			get
			{
				return this.pell_Amount_Paid_to_DateField;
			}
			set
			{
				this.pell_Amount_Paid_to_DateField = value;
				this.RaisePropertyChanged("Pell_Amount_Paid_to_Date");
			}
		}

		[XmlIgnore]
		public bool Pell_Amount_Paid_to_DateSpecified
		{
			get
			{
				return this.pell_Amount_Paid_to_DateFieldSpecified;
			}
			set
			{
				this.pell_Amount_Paid_to_DateFieldSpecified = value;
				this.RaisePropertyChanged("Pell_Amount_Paid_to_DateSpecified");
			}
		}

		[XmlElement(Order = 8)]
		public decimal Pell_Percent_Scheduled_Award_Used_by_Award_Year
		{
			get
			{
				return this.pell_Percent_Scheduled_Award_Used_by_Award_YearField;
			}
			set
			{
				this.pell_Percent_Scheduled_Award_Used_by_Award_YearField = value;
				this.RaisePropertyChanged("Pell_Percent_Scheduled_Award_Used_by_Award_Year");
			}
		}

		[XmlIgnore]
		public bool Pell_Percent_Scheduled_Award_Used_by_Award_YearSpecified
		{
			get
			{
				return this.pell_Percent_Scheduled_Award_Used_by_Award_YearFieldSpecified;
			}
			set
			{
				this.pell_Percent_Scheduled_Award_Used_by_Award_YearFieldSpecified = value;
				this.RaisePropertyChanged("Pell_Percent_Scheduled_Award_Used_by_Award_YearSpecified");
			}
		}

		[XmlElement(Order = 9)]
		public decimal Pell_Award_Amount
		{
			get
			{
				return this.pell_Award_AmountField;
			}
			set
			{
				this.pell_Award_AmountField = value;
				this.RaisePropertyChanged("Pell_Award_Amount");
			}
		}

		[XmlIgnore]
		public bool Pell_Award_AmountSpecified
		{
			get
			{
				return this.pell_Award_AmountFieldSpecified;
			}
			set
			{
				this.pell_Award_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Pell_Award_AmountSpecified");
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
