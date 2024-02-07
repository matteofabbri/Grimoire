using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.CompensationReview
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Employee_Award_Merit_DataType : INotifyPropertyChanged
	{
		private decimal merit_Increase_PercentField;

		private bool merit_Increase_PercentFieldSpecified;

		private decimal merit_FactorField;

		private bool merit_FactorFieldSpecified;

		private decimal merit_AmountField;

		private bool merit_AmountFieldSpecified;

		private decimal merit_New_Pay_AmountField;

		private bool merit_New_Pay_AmountFieldSpecified;

		private string merit_NotesField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public decimal Merit_Increase_Percent
		{
			get
			{
				return this.merit_Increase_PercentField;
			}
			set
			{
				this.merit_Increase_PercentField = value;
				this.RaisePropertyChanged("Merit_Increase_Percent");
			}
		}

		[XmlIgnore]
		public bool Merit_Increase_PercentSpecified
		{
			get
			{
				return this.merit_Increase_PercentFieldSpecified;
			}
			set
			{
				this.merit_Increase_PercentFieldSpecified = value;
				this.RaisePropertyChanged("Merit_Increase_PercentSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public decimal Merit_Factor
		{
			get
			{
				return this.merit_FactorField;
			}
			set
			{
				this.merit_FactorField = value;
				this.RaisePropertyChanged("Merit_Factor");
			}
		}

		[XmlIgnore]
		public bool Merit_FactorSpecified
		{
			get
			{
				return this.merit_FactorFieldSpecified;
			}
			set
			{
				this.merit_FactorFieldSpecified = value;
				this.RaisePropertyChanged("Merit_FactorSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public decimal Merit_Amount
		{
			get
			{
				return this.merit_AmountField;
			}
			set
			{
				this.merit_AmountField = value;
				this.RaisePropertyChanged("Merit_Amount");
			}
		}

		[XmlIgnore]
		public bool Merit_AmountSpecified
		{
			get
			{
				return this.merit_AmountFieldSpecified;
			}
			set
			{
				this.merit_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Merit_AmountSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public decimal Merit_New_Pay_Amount
		{
			get
			{
				return this.merit_New_Pay_AmountField;
			}
			set
			{
				this.merit_New_Pay_AmountField = value;
				this.RaisePropertyChanged("Merit_New_Pay_Amount");
			}
		}

		[XmlIgnore]
		public bool Merit_New_Pay_AmountSpecified
		{
			get
			{
				return this.merit_New_Pay_AmountFieldSpecified;
			}
			set
			{
				this.merit_New_Pay_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Merit_New_Pay_AmountSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public string Merit_Notes
		{
			get
			{
				return this.merit_NotesField;
			}
			set
			{
				this.merit_NotesField = value;
				this.RaisePropertyChanged("Merit_Notes");
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
