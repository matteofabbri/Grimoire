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
	public class Employee_Award_Additional_Adjustment_dataType : INotifyPropertyChanged
	{
		private decimal additional_Adjustment_AmountField;

		private bool additional_Adjustment_AmountFieldSpecified;

		private decimal additional_Adjustment_PercentField;

		private bool additional_Adjustment_PercentFieldSpecified;

		private decimal additional_Adjustment_New_Pay_AmountField;

		private bool additional_Adjustment_New_Pay_AmountFieldSpecified;

		private string additional_Adjustment_NotesField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public decimal Additional_Adjustment_Amount
		{
			get
			{
				return this.additional_Adjustment_AmountField;
			}
			set
			{
				this.additional_Adjustment_AmountField = value;
				this.RaisePropertyChanged("Additional_Adjustment_Amount");
			}
		}

		[XmlIgnore]
		public bool Additional_Adjustment_AmountSpecified
		{
			get
			{
				return this.additional_Adjustment_AmountFieldSpecified;
			}
			set
			{
				this.additional_Adjustment_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Additional_Adjustment_AmountSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public decimal Additional_Adjustment_Percent
		{
			get
			{
				return this.additional_Adjustment_PercentField;
			}
			set
			{
				this.additional_Adjustment_PercentField = value;
				this.RaisePropertyChanged("Additional_Adjustment_Percent");
			}
		}

		[XmlIgnore]
		public bool Additional_Adjustment_PercentSpecified
		{
			get
			{
				return this.additional_Adjustment_PercentFieldSpecified;
			}
			set
			{
				this.additional_Adjustment_PercentFieldSpecified = value;
				this.RaisePropertyChanged("Additional_Adjustment_PercentSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public decimal Additional_Adjustment_New_Pay_Amount
		{
			get
			{
				return this.additional_Adjustment_New_Pay_AmountField;
			}
			set
			{
				this.additional_Adjustment_New_Pay_AmountField = value;
				this.RaisePropertyChanged("Additional_Adjustment_New_Pay_Amount");
			}
		}

		[XmlIgnore]
		public bool Additional_Adjustment_New_Pay_AmountSpecified
		{
			get
			{
				return this.additional_Adjustment_New_Pay_AmountFieldSpecified;
			}
			set
			{
				this.additional_Adjustment_New_Pay_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Additional_Adjustment_New_Pay_AmountSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public string Additional_Adjustment_Notes
		{
			get
			{
				return this.additional_Adjustment_NotesField;
			}
			set
			{
				this.additional_Adjustment_NotesField = value;
				this.RaisePropertyChanged("Additional_Adjustment_Notes");
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
