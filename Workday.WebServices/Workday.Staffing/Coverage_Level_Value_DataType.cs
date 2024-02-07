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
	public class Coverage_Level_Value_DataType : INotifyPropertyChanged
	{
		private decimal coverage_Level_ValueField;

		private decimal buy_Up_AmountField;

		private bool buy_Up_AmountFieldSpecified;

		private decimal guarantee_Issue_AmountField;

		private bool guarantee_Issue_AmountFieldSpecified;

		private decimal coverage_Level_MultiplierField;

		private string coverage_Level_TypeField;

		private CurrencyObjectType currency_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public decimal Coverage_Level_Value
		{
			get
			{
				return this.coverage_Level_ValueField;
			}
			set
			{
				this.coverage_Level_ValueField = value;
				this.RaisePropertyChanged("Coverage_Level_Value");
			}
		}

		[XmlElement(Order = 1)]
		public decimal Buy_Up_Amount
		{
			get
			{
				return this.buy_Up_AmountField;
			}
			set
			{
				this.buy_Up_AmountField = value;
				this.RaisePropertyChanged("Buy_Up_Amount");
			}
		}

		[XmlIgnore]
		public bool Buy_Up_AmountSpecified
		{
			get
			{
				return this.buy_Up_AmountFieldSpecified;
			}
			set
			{
				this.buy_Up_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Buy_Up_AmountSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public decimal Guarantee_Issue_Amount
		{
			get
			{
				return this.guarantee_Issue_AmountField;
			}
			set
			{
				this.guarantee_Issue_AmountField = value;
				this.RaisePropertyChanged("Guarantee_Issue_Amount");
			}
		}

		[XmlIgnore]
		public bool Guarantee_Issue_AmountSpecified
		{
			get
			{
				return this.guarantee_Issue_AmountFieldSpecified;
			}
			set
			{
				this.guarantee_Issue_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Guarantee_Issue_AmountSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public decimal Coverage_Level_Multiplier
		{
			get
			{
				return this.coverage_Level_MultiplierField;
			}
			set
			{
				this.coverage_Level_MultiplierField = value;
				this.RaisePropertyChanged("Coverage_Level_Multiplier");
			}
		}

		[XmlElement(Order = 4)]
		public string Coverage_Level_Type
		{
			get
			{
				return this.coverage_Level_TypeField;
			}
			set
			{
				this.coverage_Level_TypeField = value;
				this.RaisePropertyChanged("Coverage_Level_Type");
			}
		}

		[XmlElement(Order = 5)]
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
