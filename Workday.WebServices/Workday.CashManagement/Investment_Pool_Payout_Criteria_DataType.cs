using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.CashManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Investment_Pool_Payout_Criteria_DataType : INotifyPropertyChanged
	{
		private decimal payout_per_unitField;

		private bool payout_per_unitFieldSpecified;

		private decimal administrative_Fee_per_unitField;

		private bool administrative_Fee_per_unitFieldSpecified;

		private DateTime end_DateField;

		private bool end_DateFieldSpecified;

		private Investment_Pool_PayoutObjectType investment_Pool_Payout_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public decimal Payout_per_unit
		{
			get
			{
				return this.payout_per_unitField;
			}
			set
			{
				this.payout_per_unitField = value;
				this.RaisePropertyChanged("Payout_per_unit");
			}
		}

		[XmlIgnore]
		public bool Payout_per_unitSpecified
		{
			get
			{
				return this.payout_per_unitFieldSpecified;
			}
			set
			{
				this.payout_per_unitFieldSpecified = value;
				this.RaisePropertyChanged("Payout_per_unitSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public decimal Administrative_Fee_per_unit
		{
			get
			{
				return this.administrative_Fee_per_unitField;
			}
			set
			{
				this.administrative_Fee_per_unitField = value;
				this.RaisePropertyChanged("Administrative_Fee_per_unit");
			}
		}

		[XmlIgnore]
		public bool Administrative_Fee_per_unitSpecified
		{
			get
			{
				return this.administrative_Fee_per_unitFieldSpecified;
			}
			set
			{
				this.administrative_Fee_per_unitFieldSpecified = value;
				this.RaisePropertyChanged("Administrative_Fee_per_unitSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 2)]
		public DateTime End_Date
		{
			get
			{
				return this.end_DateField;
			}
			set
			{
				this.end_DateField = value;
				this.RaisePropertyChanged("End_Date");
			}
		}

		[XmlIgnore]
		public bool End_DateSpecified
		{
			get
			{
				return this.end_DateFieldSpecified;
			}
			set
			{
				this.end_DateFieldSpecified = value;
				this.RaisePropertyChanged("End_DateSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public Investment_Pool_PayoutObjectType Investment_Pool_Payout_Reference
		{
			get
			{
				return this.investment_Pool_Payout_ReferenceField;
			}
			set
			{
				this.investment_Pool_Payout_ReferenceField = value;
				this.RaisePropertyChanged("Investment_Pool_Payout_Reference");
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
