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
	public class Payee_Period_Calculated_Time_Summary_DataType : INotifyPropertyChanged
	{
		private decimal total_Calculated_QuantityField;

		private bool total_Calculated_QuantityFieldSpecified;

		private decimal override_RateField;

		private bool override_RateFieldSpecified;

		private CurrencyObjectType currency_ReferenceField;

		private Worker_Time_Block_Worktag_DataType[] worktag_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
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

		[XmlElement(Order = 1)]
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

		[XmlElement(Order = 2)]
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

		[XmlElement("Worktag_Data", Order = 3)]
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
