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
	public class Revenue_Recognition_Installment_DataType : INotifyPropertyChanged
	{
		private string revenue_Recognition_Installment_Reference_IDField;

		private Revenue_Recognition_InstallmentObjectType revenue_Recognition_Installment_ReferenceField;

		private Document_StatusObjectType[] status_ReferenceField;

		private DateTime installment_DateField;

		private bool installment_DateFieldSpecified;

		private DateTime from_DateField;

		private bool from_DateFieldSpecified;

		private DateTime to_DateField;

		private bool to_DateFieldSpecified;

		private bool on_HoldField;

		private bool on_HoldFieldSpecified;

		private decimal total_AmountField;

		private bool total_AmountFieldSpecified;

		private CurrencyObjectType currency_ReferenceField;

		private Milestone_AbstractObjectType[] milestone_ReferenceField;

		private Revenue_Recognition_Installment_Line_DataType[] revenue_Recognition_Installment_Line_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Revenue_Recognition_Installment_Reference_ID
		{
			get
			{
				return this.revenue_Recognition_Installment_Reference_IDField;
			}
			set
			{
				this.revenue_Recognition_Installment_Reference_IDField = value;
				this.RaisePropertyChanged("Revenue_Recognition_Installment_Reference_ID");
			}
		}

		[XmlElement(Order = 1)]
		public Revenue_Recognition_InstallmentObjectType Revenue_Recognition_Installment_Reference
		{
			get
			{
				return this.revenue_Recognition_Installment_ReferenceField;
			}
			set
			{
				this.revenue_Recognition_Installment_ReferenceField = value;
				this.RaisePropertyChanged("Revenue_Recognition_Installment_Reference");
			}
		}

		[XmlElement("Status_Reference", Order = 2)]
		public Document_StatusObjectType[] Status_Reference
		{
			get
			{
				return this.status_ReferenceField;
			}
			set
			{
				this.status_ReferenceField = value;
				this.RaisePropertyChanged("Status_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 3)]
		public DateTime Installment_Date
		{
			get
			{
				return this.installment_DateField;
			}
			set
			{
				this.installment_DateField = value;
				this.RaisePropertyChanged("Installment_Date");
			}
		}

		[XmlIgnore]
		public bool Installment_DateSpecified
		{
			get
			{
				return this.installment_DateFieldSpecified;
			}
			set
			{
				this.installment_DateFieldSpecified = value;
				this.RaisePropertyChanged("Installment_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 4)]
		public DateTime From_Date
		{
			get
			{
				return this.from_DateField;
			}
			set
			{
				this.from_DateField = value;
				this.RaisePropertyChanged("From_Date");
			}
		}

		[XmlIgnore]
		public bool From_DateSpecified
		{
			get
			{
				return this.from_DateFieldSpecified;
			}
			set
			{
				this.from_DateFieldSpecified = value;
				this.RaisePropertyChanged("From_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 5)]
		public DateTime To_Date
		{
			get
			{
				return this.to_DateField;
			}
			set
			{
				this.to_DateField = value;
				this.RaisePropertyChanged("To_Date");
			}
		}

		[XmlIgnore]
		public bool To_DateSpecified
		{
			get
			{
				return this.to_DateFieldSpecified;
			}
			set
			{
				this.to_DateFieldSpecified = value;
				this.RaisePropertyChanged("To_DateSpecified");
			}
		}

		[XmlElement(Order = 6)]
		public bool On_Hold
		{
			get
			{
				return this.on_HoldField;
			}
			set
			{
				this.on_HoldField = value;
				this.RaisePropertyChanged("On_Hold");
			}
		}

		[XmlIgnore]
		public bool On_HoldSpecified
		{
			get
			{
				return this.on_HoldFieldSpecified;
			}
			set
			{
				this.on_HoldFieldSpecified = value;
				this.RaisePropertyChanged("On_HoldSpecified");
			}
		}

		[XmlElement(Order = 7)]
		public decimal Total_Amount
		{
			get
			{
				return this.total_AmountField;
			}
			set
			{
				this.total_AmountField = value;
				this.RaisePropertyChanged("Total_Amount");
			}
		}

		[XmlIgnore]
		public bool Total_AmountSpecified
		{
			get
			{
				return this.total_AmountFieldSpecified;
			}
			set
			{
				this.total_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Total_AmountSpecified");
			}
		}

		[XmlElement(Order = 8)]
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

		[XmlElement("Milestone_Reference", Order = 9)]
		public Milestone_AbstractObjectType[] Milestone_Reference
		{
			get
			{
				return this.milestone_ReferenceField;
			}
			set
			{
				this.milestone_ReferenceField = value;
				this.RaisePropertyChanged("Milestone_Reference");
			}
		}

		[XmlElement("Revenue_Recognition_Installment_Line_Data", Order = 10)]
		public Revenue_Recognition_Installment_Line_DataType[] Revenue_Recognition_Installment_Line_Data
		{
			get
			{
				return this.revenue_Recognition_Installment_Line_DataField;
			}
			set
			{
				this.revenue_Recognition_Installment_Line_DataField = value;
				this.RaisePropertyChanged("Revenue_Recognition_Installment_Line_Data");
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
