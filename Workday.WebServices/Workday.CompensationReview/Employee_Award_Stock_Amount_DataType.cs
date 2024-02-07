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
	public class Employee_Award_Stock_Amount_DataType : INotifyPropertyChanged
	{
		private Stock_PlanObjectType stock_Plan_ReferenceField;

		private decimal stock_PercentField;

		private bool stock_PercentFieldSpecified;

		private decimal stock_AmountField;

		private bool stock_AmountFieldSpecified;

		private decimal stock_FactorField;

		private bool stock_FactorFieldSpecified;

		private string stock_Amount_NotesField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Stock_PlanObjectType Stock_Plan_Reference
		{
			get
			{
				return this.stock_Plan_ReferenceField;
			}
			set
			{
				this.stock_Plan_ReferenceField = value;
				this.RaisePropertyChanged("Stock_Plan_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public decimal Stock_Percent
		{
			get
			{
				return this.stock_PercentField;
			}
			set
			{
				this.stock_PercentField = value;
				this.RaisePropertyChanged("Stock_Percent");
			}
		}

		[XmlIgnore]
		public bool Stock_PercentSpecified
		{
			get
			{
				return this.stock_PercentFieldSpecified;
			}
			set
			{
				this.stock_PercentFieldSpecified = value;
				this.RaisePropertyChanged("Stock_PercentSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public decimal Stock_Amount
		{
			get
			{
				return this.stock_AmountField;
			}
			set
			{
				this.stock_AmountField = value;
				this.RaisePropertyChanged("Stock_Amount");
			}
		}

		[XmlIgnore]
		public bool Stock_AmountSpecified
		{
			get
			{
				return this.stock_AmountFieldSpecified;
			}
			set
			{
				this.stock_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Stock_AmountSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public decimal Stock_Factor
		{
			get
			{
				return this.stock_FactorField;
			}
			set
			{
				this.stock_FactorField = value;
				this.RaisePropertyChanged("Stock_Factor");
			}
		}

		[XmlIgnore]
		public bool Stock_FactorSpecified
		{
			get
			{
				return this.stock_FactorFieldSpecified;
			}
			set
			{
				this.stock_FactorFieldSpecified = value;
				this.RaisePropertyChanged("Stock_FactorSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public string Stock_Amount_Notes
		{
			get
			{
				return this.stock_Amount_NotesField;
			}
			set
			{
				this.stock_Amount_NotesField = value;
				this.RaisePropertyChanged("Stock_Amount_Notes");
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
