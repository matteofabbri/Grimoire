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
	public class Payment_Election_Option_DataType : INotifyPropertyChanged
	{
		private WorkerObjectType worker_ReferenceField;

		private CountryObjectType default_Country_ReferenceField;

		private CurrencyObjectType default_Currency_ReferenceField;

		private Pay_Type_Payment_Election_Option_DataType[] pay_Type_Payment_Election_Option_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public WorkerObjectType Worker_Reference
		{
			get
			{
				return this.worker_ReferenceField;
			}
			set
			{
				this.worker_ReferenceField = value;
				this.RaisePropertyChanged("Worker_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public CountryObjectType Default_Country_Reference
		{
			get
			{
				return this.default_Country_ReferenceField;
			}
			set
			{
				this.default_Country_ReferenceField = value;
				this.RaisePropertyChanged("Default_Country_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public CurrencyObjectType Default_Currency_Reference
		{
			get
			{
				return this.default_Currency_ReferenceField;
			}
			set
			{
				this.default_Currency_ReferenceField = value;
				this.RaisePropertyChanged("Default_Currency_Reference");
			}
		}

		[XmlElement("Pay_Type_Payment_Election_Option_Data", Order = 3)]
		public Pay_Type_Payment_Election_Option_DataType[] Pay_Type_Payment_Election_Option_Data
		{
			get
			{
				return this.pay_Type_Payment_Election_Option_DataField;
			}
			set
			{
				this.pay_Type_Payment_Election_Option_DataField = value;
				this.RaisePropertyChanged("Pay_Type_Payment_Election_Option_Data");
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
