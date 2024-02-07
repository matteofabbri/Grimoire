using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Compensation
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Previous_System_Compensation_History_Detail_DataType : INotifyPropertyChanged
	{
		private string idField;

		private string worker_History_NameField;

		private DateTime action_DateField;

		private bool action_DateFieldSpecified;

		private string reasonField;

		private decimal amountField;

		private bool amountFieldSpecified;

		private CurrencyObjectType currency_ReferenceField;

		private FrequencyObjectType frequency_ReferenceField;

		private decimal amount_ChangeField;

		private bool amount_ChangeFieldSpecified;

		private string descriptionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string ID
		{
			get
			{
				return this.idField;
			}
			set
			{
				this.idField = value;
				this.RaisePropertyChanged("ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Worker_History_Name
		{
			get
			{
				return this.worker_History_NameField;
			}
			set
			{
				this.worker_History_NameField = value;
				this.RaisePropertyChanged("Worker_History_Name");
			}
		}

		[XmlElement(DataType = "date", Order = 2)]
		public DateTime Action_Date
		{
			get
			{
				return this.action_DateField;
			}
			set
			{
				this.action_DateField = value;
				this.RaisePropertyChanged("Action_Date");
			}
		}

		[XmlIgnore]
		public bool Action_DateSpecified
		{
			get
			{
				return this.action_DateFieldSpecified;
			}
			set
			{
				this.action_DateFieldSpecified = value;
				this.RaisePropertyChanged("Action_DateSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public string Reason
		{
			get
			{
				return this.reasonField;
			}
			set
			{
				this.reasonField = value;
				this.RaisePropertyChanged("Reason");
			}
		}

		[XmlElement(Order = 4)]
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

		[XmlElement(Order = 6)]
		public FrequencyObjectType Frequency_Reference
		{
			get
			{
				return this.frequency_ReferenceField;
			}
			set
			{
				this.frequency_ReferenceField = value;
				this.RaisePropertyChanged("Frequency_Reference");
			}
		}

		[XmlElement(Order = 7)]
		public decimal Amount_Change
		{
			get
			{
				return this.amount_ChangeField;
			}
			set
			{
				this.amount_ChangeField = value;
				this.RaisePropertyChanged("Amount_Change");
			}
		}

		[XmlIgnore]
		public bool Amount_ChangeSpecified
		{
			get
			{
				return this.amount_ChangeFieldSpecified;
			}
			set
			{
				this.amount_ChangeFieldSpecified = value;
				this.RaisePropertyChanged("Amount_ChangeSpecified");
			}
		}

		[XmlElement(Order = 8)]
		public string Description
		{
			get
			{
				return this.descriptionField;
			}
			set
			{
				this.descriptionField = value;
				this.RaisePropertyChanged("Description");
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
