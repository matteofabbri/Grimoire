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
	public class Tax_Levy_Deduction_for_Override_DataType : INotifyPropertyChanged
	{
		private DateTime effective_DateField;

		private DeductionObjectType deduction_ReferenceField;

		private decimal amountField;

		private bool amountFieldSpecified;

		private decimal percentField;

		private bool percentFieldSpecified;

		private bool never_Reduces_DEField;

		private bool never_Reduces_DEFieldSpecified;

		private bool always_Reduces_DEField;

		private bool always_Reduces_DEFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(DataType = "date", Order = 0)]
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

		[XmlElement(Order = 1)]
		public DeductionObjectType Deduction_Reference
		{
			get
			{
				return this.deduction_ReferenceField;
			}
			set
			{
				this.deduction_ReferenceField = value;
				this.RaisePropertyChanged("Deduction_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public decimal Amount
		{
			get
			{
				return this.amountField;
			}
			set
			{
				this.amountField = value;
				this.RaisePropertyChanged("Amount");
			}
		}

		[XmlIgnore]
		public bool AmountSpecified
		{
			get
			{
				return this.amountFieldSpecified;
			}
			set
			{
				this.amountFieldSpecified = value;
				this.RaisePropertyChanged("AmountSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public decimal Percent
		{
			get
			{
				return this.percentField;
			}
			set
			{
				this.percentField = value;
				this.RaisePropertyChanged("Percent");
			}
		}

		[XmlIgnore]
		public bool PercentSpecified
		{
			get
			{
				return this.percentFieldSpecified;
			}
			set
			{
				this.percentFieldSpecified = value;
				this.RaisePropertyChanged("PercentSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public bool Never_Reduces_DE
		{
			get
			{
				return this.never_Reduces_DEField;
			}
			set
			{
				this.never_Reduces_DEField = value;
				this.RaisePropertyChanged("Never_Reduces_DE");
			}
		}

		[XmlIgnore]
		public bool Never_Reduces_DESpecified
		{
			get
			{
				return this.never_Reduces_DEFieldSpecified;
			}
			set
			{
				this.never_Reduces_DEFieldSpecified = value;
				this.RaisePropertyChanged("Never_Reduces_DESpecified");
			}
		}

		[XmlElement(Order = 5)]
		public bool Always_Reduces_DE
		{
			get
			{
				return this.always_Reduces_DEField;
			}
			set
			{
				this.always_Reduces_DEField = value;
				this.RaisePropertyChanged("Always_Reduces_DE");
			}
		}

		[XmlIgnore]
		public bool Always_Reduces_DESpecified
		{
			get
			{
				return this.always_Reduces_DEFieldSpecified;
			}
			set
			{
				this.always_Reduces_DEFieldSpecified = value;
				this.RaisePropertyChanged("Always_Reduces_DESpecified");
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
