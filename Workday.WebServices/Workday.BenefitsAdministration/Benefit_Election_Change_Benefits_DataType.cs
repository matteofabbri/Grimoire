using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.BenefitsAdministration
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Benefit_Election_Change_Benefits_DataType : INotifyPropertyChanged
	{
		private DateTime coverage_Begin_DateField;

		private bool coverage_Begin_DateFieldSpecified;

		private DateTime original_Coverage_Begin_DateField;

		private bool original_Coverage_Begin_DateFieldSpecified;

		private DateTime deduction_Begin_DateField;

		private bool deduction_Begin_DateFieldSpecified;

		private DateTime original_Deduction_Begin_DateField;

		private bool original_Deduction_Begin_DateFieldSpecified;

		private object itemField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(DataType = "date", Order = 0)]
		public DateTime Coverage_Begin_Date
		{
			get
			{
				return this.coverage_Begin_DateField;
			}
			set
			{
				this.coverage_Begin_DateField = value;
				this.RaisePropertyChanged("Coverage_Begin_Date");
			}
		}

		[XmlIgnore]
		public bool Coverage_Begin_DateSpecified
		{
			get
			{
				return this.coverage_Begin_DateFieldSpecified;
			}
			set
			{
				this.coverage_Begin_DateFieldSpecified = value;
				this.RaisePropertyChanged("Coverage_Begin_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 1)]
		public DateTime Original_Coverage_Begin_Date
		{
			get
			{
				return this.original_Coverage_Begin_DateField;
			}
			set
			{
				this.original_Coverage_Begin_DateField = value;
				this.RaisePropertyChanged("Original_Coverage_Begin_Date");
			}
		}

		[XmlIgnore]
		public bool Original_Coverage_Begin_DateSpecified
		{
			get
			{
				return this.original_Coverage_Begin_DateFieldSpecified;
			}
			set
			{
				this.original_Coverage_Begin_DateFieldSpecified = value;
				this.RaisePropertyChanged("Original_Coverage_Begin_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 2)]
		public DateTime Deduction_Begin_Date
		{
			get
			{
				return this.deduction_Begin_DateField;
			}
			set
			{
				this.deduction_Begin_DateField = value;
				this.RaisePropertyChanged("Deduction_Begin_Date");
			}
		}

		[XmlIgnore]
		public bool Deduction_Begin_DateSpecified
		{
			get
			{
				return this.deduction_Begin_DateFieldSpecified;
			}
			set
			{
				this.deduction_Begin_DateFieldSpecified = value;
				this.RaisePropertyChanged("Deduction_Begin_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 3)]
		public DateTime Original_Deduction_Begin_Date
		{
			get
			{
				return this.original_Deduction_Begin_DateField;
			}
			set
			{
				this.original_Deduction_Begin_DateField = value;
				this.RaisePropertyChanged("Original_Deduction_Begin_Date");
			}
		}

		[XmlIgnore]
		public bool Original_Deduction_Begin_DateSpecified
		{
			get
			{
				return this.original_Deduction_Begin_DateFieldSpecified;
			}
			set
			{
				this.original_Deduction_Begin_DateFieldSpecified = value;
				this.RaisePropertyChanged("Original_Deduction_Begin_DateSpecified");
			}
		}

		[XmlElement("Additional_Benefits_Election_Data", typeof(Additional_Benefits_Election_DataType), Order = 4), XmlElement("Health_Care_Election_Data", typeof(Health_Care_Election_Change_Benefits_DataType), Order = 4), XmlElement("Health_Savings_Account_Election_Data", typeof(Health_Savings_Account_Election_DataType), Order = 4), XmlElement("Insurance_Election_Data", typeof(Insurance_Election_Data_Change_BenefitsType), Order = 4), XmlElement("Retirement_Savings_Election_Data", typeof(Retirement_Savings_Election_DataType), Order = 4), XmlElement("Spending_Account_Election_Data", typeof(Spending_Account_Election_DataType), Order = 4)]
		public object Item
		{
			get
			{
				return this.itemField;
			}
			set
			{
				this.itemField = value;
				this.RaisePropertyChanged("Item");
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
