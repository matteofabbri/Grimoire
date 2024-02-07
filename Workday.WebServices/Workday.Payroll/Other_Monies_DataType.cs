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
	public class Other_Monies_DataType : INotifyPropertyChanged
	{
		private string rOE_Other_Monies_CodeField;

		private DateTime rOE_Other_Monies_Start_DateField;

		private bool rOE_Other_Monies_Start_DateFieldSpecified;

		private DateTime rOE_Other_Monies_End_DateField;

		private bool rOE_Other_Monies_End_DateFieldSpecified;

		private decimal rOE_Other_Monies_AmountField;

		private bool rOE_Other_Monies_AmountFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string ROE_Other_Monies_Code
		{
			get
			{
				return this.rOE_Other_Monies_CodeField;
			}
			set
			{
				this.rOE_Other_Monies_CodeField = value;
				this.RaisePropertyChanged("ROE_Other_Monies_Code");
			}
		}

		[XmlElement(DataType = "date", Order = 1)]
		public DateTime ROE_Other_Monies_Start_Date
		{
			get
			{
				return this.rOE_Other_Monies_Start_DateField;
			}
			set
			{
				this.rOE_Other_Monies_Start_DateField = value;
				this.RaisePropertyChanged("ROE_Other_Monies_Start_Date");
			}
		}

		[XmlIgnore]
		public bool ROE_Other_Monies_Start_DateSpecified
		{
			get
			{
				return this.rOE_Other_Monies_Start_DateFieldSpecified;
			}
			set
			{
				this.rOE_Other_Monies_Start_DateFieldSpecified = value;
				this.RaisePropertyChanged("ROE_Other_Monies_Start_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 2)]
		public DateTime ROE_Other_Monies_End_Date
		{
			get
			{
				return this.rOE_Other_Monies_End_DateField;
			}
			set
			{
				this.rOE_Other_Monies_End_DateField = value;
				this.RaisePropertyChanged("ROE_Other_Monies_End_Date");
			}
		}

		[XmlIgnore]
		public bool ROE_Other_Monies_End_DateSpecified
		{
			get
			{
				return this.rOE_Other_Monies_End_DateFieldSpecified;
			}
			set
			{
				this.rOE_Other_Monies_End_DateFieldSpecified = value;
				this.RaisePropertyChanged("ROE_Other_Monies_End_DateSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public decimal ROE_Other_Monies_Amount
		{
			get
			{
				return this.rOE_Other_Monies_AmountField;
			}
			set
			{
				this.rOE_Other_Monies_AmountField = value;
				this.RaisePropertyChanged("ROE_Other_Monies_Amount");
			}
		}

		[XmlIgnore]
		public bool ROE_Other_Monies_AmountSpecified
		{
			get
			{
				return this.rOE_Other_Monies_AmountFieldSpecified;
			}
			set
			{
				this.rOE_Other_Monies_AmountFieldSpecified = value;
				this.RaisePropertyChanged("ROE_Other_Monies_AmountSpecified");
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
