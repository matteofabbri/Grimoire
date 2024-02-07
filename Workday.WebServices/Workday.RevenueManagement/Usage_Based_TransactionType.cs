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
	public class Usage_Based_TransactionType : INotifyPropertyChanged
	{
		private Usage_Based_TransactionObjectType usage_Based_Transaction_ReferenceField;

		private Usage_Based_Transaction_DataType[] usage_Based_Transaction_DataField;

		private decimal amount_To_BillField;

		private bool amount_To_BillFieldSpecified;

		private CurrencyObjectType currency_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Usage_Based_TransactionObjectType Usage_Based_Transaction_Reference
		{
			get
			{
				return this.usage_Based_Transaction_ReferenceField;
			}
			set
			{
				this.usage_Based_Transaction_ReferenceField = value;
				this.RaisePropertyChanged("Usage_Based_Transaction_Reference");
			}
		}

		[XmlElement("Usage_Based_Transaction_Data", Order = 1)]
		public Usage_Based_Transaction_DataType[] Usage_Based_Transaction_Data
		{
			get
			{
				return this.usage_Based_Transaction_DataField;
			}
			set
			{
				this.usage_Based_Transaction_DataField = value;
				this.RaisePropertyChanged("Usage_Based_Transaction_Data");
			}
		}

		[XmlElement(Order = 2)]
		public decimal Amount_To_Bill
		{
			get
			{
				return this.amount_To_BillField;
			}
			set
			{
				this.amount_To_BillField = value;
				this.RaisePropertyChanged("Amount_To_Bill");
			}
		}

		[XmlIgnore]
		public bool Amount_To_BillSpecified
		{
			get
			{
				return this.amount_To_BillFieldSpecified;
			}
			set
			{
				this.amount_To_BillFieldSpecified = value;
				this.RaisePropertyChanged("Amount_To_BillSpecified");
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
