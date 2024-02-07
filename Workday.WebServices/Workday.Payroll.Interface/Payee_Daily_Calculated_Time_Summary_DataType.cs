using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Payroll.Interface
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Payee_Daily_Calculated_Time_Summary_DataType : INotifyPropertyChanged
	{
		private DateTime daily_Summary_Start_DateField;

		private bool daily_Summary_Start_DateFieldSpecified;

		private decimal total_Calculated_QuantityField;

		private bool total_Calculated_QuantityFieldSpecified;

		private decimal override_RateField;

		private bool override_RateFieldSpecified;

		private CurrencyObjectType currency_ReferenceField;

		private Worker_Time_Block_Worktag_DataType[] worktag_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(DataType = "date", Order = 0)]
		public DateTime Daily_Summary_Start_Date
		{
			get
			{
				return this.daily_Summary_Start_DateField;
			}
			set
			{
				this.daily_Summary_Start_DateField = value;
				this.RaisePropertyChanged("Daily_Summary_Start_Date");
			}
		}

		[XmlIgnore]
		public bool Daily_Summary_Start_DateSpecified
		{
			get
			{
				return this.daily_Summary_Start_DateFieldSpecified;
			}
			set
			{
				this.daily_Summary_Start_DateFieldSpecified = value;
				this.RaisePropertyChanged("Daily_Summary_Start_DateSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public decimal Total_Calculated_Quantity
		{
			get
			{
				return this.total_Calculated_QuantityField;
			}
			set
			{
				this.total_Calculated_QuantityField = value;
				this.RaisePropertyChanged("Total_Calculated_Quantity");
			}
		}

		[XmlIgnore]
		public bool Total_Calculated_QuantitySpecified
		{
			get
			{
				return this.total_Calculated_QuantityFieldSpecified;
			}
			set
			{
				this.total_Calculated_QuantityFieldSpecified = value;
				this.RaisePropertyChanged("Total_Calculated_QuantitySpecified");
			}
		}

		[XmlElement(Order = 2)]
		public decimal Override_Rate
		{
			get
			{
				return this.override_RateField;
			}
			set
			{
				this.override_RateField = value;
				this.RaisePropertyChanged("Override_Rate");
			}
		}

		[XmlIgnore]
		public bool Override_RateSpecified
		{
			get
			{
				return this.override_RateFieldSpecified;
			}
			set
			{
				this.override_RateFieldSpecified = value;
				this.RaisePropertyChanged("Override_RateSpecified");
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

		[XmlElement("Worktag_Data", Order = 4)]
		public Worker_Time_Block_Worktag_DataType[] Worktag_Data
		{
			get
			{
				return this.worktag_DataField;
			}
			set
			{
				this.worktag_DataField = value;
				this.RaisePropertyChanged("Worktag_Data");
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
