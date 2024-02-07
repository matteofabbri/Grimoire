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
	public class Contract_Line_Renewal_DataType : INotifyPropertyChanged
	{
		private Customer_Contract_LineObjectType customer_Contract_Line_ReferenceField;

		private decimal renewal_QuantityField;

		private bool renewal_QuantityFieldSpecified;

		private decimal renewal_Quantity_2Field;

		private bool renewal_Quantity_2FieldSpecified;

		private decimal renewal_RateField;

		private bool renewal_RateFieldSpecified;

		private decimal renewal_AmountField;

		private bool renewal_AmountFieldSpecified;

		private decimal renewal_PercentField;

		private bool renewal_PercentFieldSpecified;

		private DateTime from_DateField;

		private bool from_DateFieldSpecified;

		private DateTime to_DateField;

		private bool to_DateFieldSpecified;

		private bool coTermField;

		private bool coTermFieldSpecified;

		private bool auto_RenewField;

		private bool auto_RenewFieldSpecified;

		private Business_Entity_ContactObjectType customer_Bill_To_Contact_ReferenceField;

		private string optOut_PeriodField;

		private string notesField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Customer_Contract_LineObjectType Customer_Contract_Line_Reference
		{
			get
			{
				return this.customer_Contract_Line_ReferenceField;
			}
			set
			{
				this.customer_Contract_Line_ReferenceField = value;
				this.RaisePropertyChanged("Customer_Contract_Line_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public decimal Renewal_Quantity
		{
			get
			{
				return this.renewal_QuantityField;
			}
			set
			{
				this.renewal_QuantityField = value;
				this.RaisePropertyChanged("Renewal_Quantity");
			}
		}

		[XmlIgnore]
		public bool Renewal_QuantitySpecified
		{
			get
			{
				return this.renewal_QuantityFieldSpecified;
			}
			set
			{
				this.renewal_QuantityFieldSpecified = value;
				this.RaisePropertyChanged("Renewal_QuantitySpecified");
			}
		}

		[XmlElement(Order = 2)]
		public decimal Renewal_Quantity_2
		{
			get
			{
				return this.renewal_Quantity_2Field;
			}
			set
			{
				this.renewal_Quantity_2Field = value;
				this.RaisePropertyChanged("Renewal_Quantity_2");
			}
		}

		[XmlIgnore]
		public bool Renewal_Quantity_2Specified
		{
			get
			{
				return this.renewal_Quantity_2FieldSpecified;
			}
			set
			{
				this.renewal_Quantity_2FieldSpecified = value;
				this.RaisePropertyChanged("Renewal_Quantity_2Specified");
			}
		}

		[XmlElement(Order = 3)]
		public decimal Renewal_Rate
		{
			get
			{
				return this.renewal_RateField;
			}
			set
			{
				this.renewal_RateField = value;
				this.RaisePropertyChanged("Renewal_Rate");
			}
		}

		[XmlIgnore]
		public bool Renewal_RateSpecified
		{
			get
			{
				return this.renewal_RateFieldSpecified;
			}
			set
			{
				this.renewal_RateFieldSpecified = value;
				this.RaisePropertyChanged("Renewal_RateSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public decimal Renewal_Amount
		{
			get
			{
				return this.renewal_AmountField;
			}
			set
			{
				this.renewal_AmountField = value;
				this.RaisePropertyChanged("Renewal_Amount");
			}
		}

		[XmlIgnore]
		public bool Renewal_AmountSpecified
		{
			get
			{
				return this.renewal_AmountFieldSpecified;
			}
			set
			{
				this.renewal_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Renewal_AmountSpecified");
			}
		}

		[XmlElement(Order = 5)]
		public decimal Renewal_Percent
		{
			get
			{
				return this.renewal_PercentField;
			}
			set
			{
				this.renewal_PercentField = value;
				this.RaisePropertyChanged("Renewal_Percent");
			}
		}

		[XmlIgnore]
		public bool Renewal_PercentSpecified
		{
			get
			{
				return this.renewal_PercentFieldSpecified;
			}
			set
			{
				this.renewal_PercentFieldSpecified = value;
				this.RaisePropertyChanged("Renewal_PercentSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 6)]
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

		[XmlElement(DataType = "date", Order = 7)]
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

		[XmlElement(Order = 8)]
		public bool CoTerm
		{
			get
			{
				return this.coTermField;
			}
			set
			{
				this.coTermField = value;
				this.RaisePropertyChanged("CoTerm");
			}
		}

		[XmlIgnore]
		public bool CoTermSpecified
		{
			get
			{
				return this.coTermFieldSpecified;
			}
			set
			{
				this.coTermFieldSpecified = value;
				this.RaisePropertyChanged("CoTermSpecified");
			}
		}

		[XmlElement(Order = 9)]
		public bool Auto_Renew
		{
			get
			{
				return this.auto_RenewField;
			}
			set
			{
				this.auto_RenewField = value;
				this.RaisePropertyChanged("Auto_Renew");
			}
		}

		[XmlIgnore]
		public bool Auto_RenewSpecified
		{
			get
			{
				return this.auto_RenewFieldSpecified;
			}
			set
			{
				this.auto_RenewFieldSpecified = value;
				this.RaisePropertyChanged("Auto_RenewSpecified");
			}
		}

		[XmlElement(Order = 10)]
		public Business_Entity_ContactObjectType Customer_Bill_To_Contact_Reference
		{
			get
			{
				return this.customer_Bill_To_Contact_ReferenceField;
			}
			set
			{
				this.customer_Bill_To_Contact_ReferenceField = value;
				this.RaisePropertyChanged("Customer_Bill_To_Contact_Reference");
			}
		}

		[XmlElement(Order = 11)]
		public string OptOut_Period
		{
			get
			{
				return this.optOut_PeriodField;
			}
			set
			{
				this.optOut_PeriodField = value;
				this.RaisePropertyChanged("OptOut_Period");
			}
		}

		[XmlElement(Order = 12)]
		public string Notes
		{
			get
			{
				return this.notesField;
			}
			set
			{
				this.notesField = value;
				this.RaisePropertyChanged("Notes");
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
