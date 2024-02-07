using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Billing_Rate_Rule_Break_DataType : INotifyPropertyChanged
	{
		private decimal begin_Break_Range_UnitsField;

		private bool begin_Break_Range_UnitsFieldSpecified;

		private decimal begin_Break_Range_AmountField;

		private bool begin_Break_Range_AmountFieldSpecified;

		private decimal end_Break_Range_UnitsField;

		private bool end_Break_Range_UnitsFieldSpecified;

		private decimal end_Break_Range_AmountField;

		private bool end_Break_Range_AmountFieldSpecified;

		private decimal itemField;

		private ItemChoiceType1 itemElementNameField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public decimal Begin_Break_Range_Units
		{
			get
			{
				return this.begin_Break_Range_UnitsField;
			}
			set
			{
				this.begin_Break_Range_UnitsField = value;
				this.RaisePropertyChanged("Begin_Break_Range_Units");
			}
		}

		[XmlIgnore]
		public bool Begin_Break_Range_UnitsSpecified
		{
			get
			{
				return this.begin_Break_Range_UnitsFieldSpecified;
			}
			set
			{
				this.begin_Break_Range_UnitsFieldSpecified = value;
				this.RaisePropertyChanged("Begin_Break_Range_UnitsSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public decimal Begin_Break_Range_Amount
		{
			get
			{
				return this.begin_Break_Range_AmountField;
			}
			set
			{
				this.begin_Break_Range_AmountField = value;
				this.RaisePropertyChanged("Begin_Break_Range_Amount");
			}
		}

		[XmlIgnore]
		public bool Begin_Break_Range_AmountSpecified
		{
			get
			{
				return this.begin_Break_Range_AmountFieldSpecified;
			}
			set
			{
				this.begin_Break_Range_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Begin_Break_Range_AmountSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public decimal End_Break_Range_Units
		{
			get
			{
				return this.end_Break_Range_UnitsField;
			}
			set
			{
				this.end_Break_Range_UnitsField = value;
				this.RaisePropertyChanged("End_Break_Range_Units");
			}
		}

		[XmlIgnore]
		public bool End_Break_Range_UnitsSpecified
		{
			get
			{
				return this.end_Break_Range_UnitsFieldSpecified;
			}
			set
			{
				this.end_Break_Range_UnitsFieldSpecified = value;
				this.RaisePropertyChanged("End_Break_Range_UnitsSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public decimal End_Break_Range_Amount
		{
			get
			{
				return this.end_Break_Range_AmountField;
			}
			set
			{
				this.end_Break_Range_AmountField = value;
				this.RaisePropertyChanged("End_Break_Range_Amount");
			}
		}

		[XmlIgnore]
		public bool End_Break_Range_AmountSpecified
		{
			get
			{
				return this.end_Break_Range_AmountFieldSpecified;
			}
			set
			{
				this.end_Break_Range_AmountFieldSpecified = value;
				this.RaisePropertyChanged("End_Break_Range_AmountSpecified");
			}
		}

		[XmlChoiceIdentifier("ItemElementName"), XmlElement("Rate_Adjustment_Amount", typeof(decimal), Order = 4), XmlElement("Rate_Adjustment_Percent", typeof(decimal), Order = 4)]
		public decimal Item
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

		[XmlElement(Order = 5), XmlIgnore]
		public ItemChoiceType1 ItemElementName
		{
			get
			{
				return this.itemElementNameField;
			}
			set
			{
				this.itemElementNameField = value;
				this.RaisePropertyChanged("ItemElementName");
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
