using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Expense_Credit_Card_Transaction_Request_CriteriaType : INotifyPropertyChanged
	{
		private Corporate_Credit_Card_AccountObjectType[] corporate_Account_ReferenceField;

		private Credit_Card_Account_Usage_IndicatorObjectType[] usage_Indicator_ReferenceField;

		private Expense_StatusObjectType[] status_ReferenceField;

		private DateTime date_Loaded_From_DateField;

		private bool date_Loaded_From_DateFieldSpecified;

		private DateTime date_Loaded_To_DateField;

		private bool date_Loaded_To_DateFieldSpecified;

		private DateTime charge_Date_From_DateField;

		private bool charge_Date_From_DateFieldSpecified;

		private DateTime charge_Date_To_DateField;

		private bool charge_Date_To_DateFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Corporate_Account_Reference", Order = 0)]
		public Corporate_Credit_Card_AccountObjectType[] Corporate_Account_Reference
		{
			get
			{
				return this.corporate_Account_ReferenceField;
			}
			set
			{
				this.corporate_Account_ReferenceField = value;
				this.RaisePropertyChanged("Corporate_Account_Reference");
			}
		}

		[XmlElement("Usage_Indicator_Reference", Order = 1)]
		public Credit_Card_Account_Usage_IndicatorObjectType[] Usage_Indicator_Reference
		{
			get
			{
				return this.usage_Indicator_ReferenceField;
			}
			set
			{
				this.usage_Indicator_ReferenceField = value;
				this.RaisePropertyChanged("Usage_Indicator_Reference");
			}
		}

		[XmlElement("Status_Reference", Order = 2)]
		public Expense_StatusObjectType[] Status_Reference
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
		public DateTime Date_Loaded_From_Date
		{
			get
			{
				return this.date_Loaded_From_DateField;
			}
			set
			{
				this.date_Loaded_From_DateField = value;
				this.RaisePropertyChanged("Date_Loaded_From_Date");
			}
		}

		[XmlIgnore]
		public bool Date_Loaded_From_DateSpecified
		{
			get
			{
				return this.date_Loaded_From_DateFieldSpecified;
			}
			set
			{
				this.date_Loaded_From_DateFieldSpecified = value;
				this.RaisePropertyChanged("Date_Loaded_From_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 4)]
		public DateTime Date_Loaded_To_Date
		{
			get
			{
				return this.date_Loaded_To_DateField;
			}
			set
			{
				this.date_Loaded_To_DateField = value;
				this.RaisePropertyChanged("Date_Loaded_To_Date");
			}
		}

		[XmlIgnore]
		public bool Date_Loaded_To_DateSpecified
		{
			get
			{
				return this.date_Loaded_To_DateFieldSpecified;
			}
			set
			{
				this.date_Loaded_To_DateFieldSpecified = value;
				this.RaisePropertyChanged("Date_Loaded_To_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 5)]
		public DateTime Charge_Date_From_Date
		{
			get
			{
				return this.charge_Date_From_DateField;
			}
			set
			{
				this.charge_Date_From_DateField = value;
				this.RaisePropertyChanged("Charge_Date_From_Date");
			}
		}

		[XmlIgnore]
		public bool Charge_Date_From_DateSpecified
		{
			get
			{
				return this.charge_Date_From_DateFieldSpecified;
			}
			set
			{
				this.charge_Date_From_DateFieldSpecified = value;
				this.RaisePropertyChanged("Charge_Date_From_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 6)]
		public DateTime Charge_Date_To_Date
		{
			get
			{
				return this.charge_Date_To_DateField;
			}
			set
			{
				this.charge_Date_To_DateField = value;
				this.RaisePropertyChanged("Charge_Date_To_Date");
			}
		}

		[XmlIgnore]
		public bool Charge_Date_To_DateSpecified
		{
			get
			{
				return this.charge_Date_To_DateFieldSpecified;
			}
			set
			{
				this.charge_Date_To_DateFieldSpecified = value;
				this.RaisePropertyChanged("Charge_Date_To_DateSpecified");
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
