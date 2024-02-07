using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.HumanResources
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Academic_Pay_Setup_DataType : INotifyPropertyChanged
	{
		private decimal annual_Work_Period_Work_Percent_of_YearField;

		private bool annual_Work_Period_Work_Percent_of_YearFieldSpecified;

		private DateTime annual_Work_Period_Start_DateField;

		private bool annual_Work_Period_Start_DateFieldSpecified;

		private DateTime annual_Work_Period_End_DateField;

		private bool annual_Work_Period_End_DateFieldSpecified;

		private DateTime disbursement_Plan_Period_Start_DateField;

		private bool disbursement_Plan_Period_Start_DateFieldSpecified;

		private DateTime disbursement_Plan_Period_End_DateField;

		private bool disbursement_Plan_Period_End_DateFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public decimal Annual_Work_Period_Work_Percent_of_Year
		{
			get
			{
				return this.annual_Work_Period_Work_Percent_of_YearField;
			}
			set
			{
				this.annual_Work_Period_Work_Percent_of_YearField = value;
				this.RaisePropertyChanged("Annual_Work_Period_Work_Percent_of_Year");
			}
		}

		[XmlIgnore]
		public bool Annual_Work_Period_Work_Percent_of_YearSpecified
		{
			get
			{
				return this.annual_Work_Period_Work_Percent_of_YearFieldSpecified;
			}
			set
			{
				this.annual_Work_Period_Work_Percent_of_YearFieldSpecified = value;
				this.RaisePropertyChanged("Annual_Work_Period_Work_Percent_of_YearSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 1)]
		public DateTime Annual_Work_Period_Start_Date
		{
			get
			{
				return this.annual_Work_Period_Start_DateField;
			}
			set
			{
				this.annual_Work_Period_Start_DateField = value;
				this.RaisePropertyChanged("Annual_Work_Period_Start_Date");
			}
		}

		[XmlIgnore]
		public bool Annual_Work_Period_Start_DateSpecified
		{
			get
			{
				return this.annual_Work_Period_Start_DateFieldSpecified;
			}
			set
			{
				this.annual_Work_Period_Start_DateFieldSpecified = value;
				this.RaisePropertyChanged("Annual_Work_Period_Start_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 2)]
		public DateTime Annual_Work_Period_End_Date
		{
			get
			{
				return this.annual_Work_Period_End_DateField;
			}
			set
			{
				this.annual_Work_Period_End_DateField = value;
				this.RaisePropertyChanged("Annual_Work_Period_End_Date");
			}
		}

		[XmlIgnore]
		public bool Annual_Work_Period_End_DateSpecified
		{
			get
			{
				return this.annual_Work_Period_End_DateFieldSpecified;
			}
			set
			{
				this.annual_Work_Period_End_DateFieldSpecified = value;
				this.RaisePropertyChanged("Annual_Work_Period_End_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 3)]
		public DateTime Disbursement_Plan_Period_Start_Date
		{
			get
			{
				return this.disbursement_Plan_Period_Start_DateField;
			}
			set
			{
				this.disbursement_Plan_Period_Start_DateField = value;
				this.RaisePropertyChanged("Disbursement_Plan_Period_Start_Date");
			}
		}

		[XmlIgnore]
		public bool Disbursement_Plan_Period_Start_DateSpecified
		{
			get
			{
				return this.disbursement_Plan_Period_Start_DateFieldSpecified;
			}
			set
			{
				this.disbursement_Plan_Period_Start_DateFieldSpecified = value;
				this.RaisePropertyChanged("Disbursement_Plan_Period_Start_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 4)]
		public DateTime Disbursement_Plan_Period_End_Date
		{
			get
			{
				return this.disbursement_Plan_Period_End_DateField;
			}
			set
			{
				this.disbursement_Plan_Period_End_DateField = value;
				this.RaisePropertyChanged("Disbursement_Plan_Period_End_Date");
			}
		}

		[XmlIgnore]
		public bool Disbursement_Plan_Period_End_DateSpecified
		{
			get
			{
				return this.disbursement_Plan_Period_End_DateFieldSpecified;
			}
			set
			{
				this.disbursement_Plan_Period_End_DateFieldSpecified = value;
				this.RaisePropertyChanged("Disbursement_Plan_Period_End_DateSpecified");
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
