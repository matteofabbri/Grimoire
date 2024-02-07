using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Staffing
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Compensatable_Summary_Amount_Annualized_In_Reporting_Currency_DataType : INotifyPropertyChanged
	{
		private decimal total_Base_PayField;

		private bool total_Base_PayFieldSpecified;

		private decimal total_Salary_and_AllowancesField;

		private bool total_Salary_and_AllowancesFieldSpecified;

		private decimal primary_Compensation_BasisField;

		private bool primary_Compensation_BasisFieldSpecified;

		private CurrencyObjectType currency_ReferenceField;

		private FrequencyObjectType frequency_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public decimal Total_Base_Pay
		{
			get
			{
				return this.total_Base_PayField;
			}
			set
			{
				this.total_Base_PayField = value;
				this.RaisePropertyChanged("Total_Base_Pay");
			}
		}

		[XmlIgnore]
		public bool Total_Base_PaySpecified
		{
			get
			{
				return this.total_Base_PayFieldSpecified;
			}
			set
			{
				this.total_Base_PayFieldSpecified = value;
				this.RaisePropertyChanged("Total_Base_PaySpecified");
			}
		}

		[XmlElement(Order = 1)]
		public decimal Total_Salary_and_Allowances
		{
			get
			{
				return this.total_Salary_and_AllowancesField;
			}
			set
			{
				this.total_Salary_and_AllowancesField = value;
				this.RaisePropertyChanged("Total_Salary_and_Allowances");
			}
		}

		[XmlIgnore]
		public bool Total_Salary_and_AllowancesSpecified
		{
			get
			{
				return this.total_Salary_and_AllowancesFieldSpecified;
			}
			set
			{
				this.total_Salary_and_AllowancesFieldSpecified = value;
				this.RaisePropertyChanged("Total_Salary_and_AllowancesSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public decimal Primary_Compensation_Basis
		{
			get
			{
				return this.primary_Compensation_BasisField;
			}
			set
			{
				this.primary_Compensation_BasisField = value;
				this.RaisePropertyChanged("Primary_Compensation_Basis");
			}
		}

		[XmlIgnore]
		public bool Primary_Compensation_BasisSpecified
		{
			get
			{
				return this.primary_Compensation_BasisFieldSpecified;
			}
			set
			{
				this.primary_Compensation_BasisFieldSpecified = value;
				this.RaisePropertyChanged("Primary_Compensation_BasisSpecified");
			}
		}

		[XmlElement(Order = 3)]
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

		[XmlElement(Order = 4)]
		public FrequencyObjectType Frequency_Reference
		{
			get
			{
				return this.frequency_ReferenceField;
			}
			set
			{
				this.frequency_ReferenceField = value;
				this.RaisePropertyChanged("Frequency_Reference");
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
