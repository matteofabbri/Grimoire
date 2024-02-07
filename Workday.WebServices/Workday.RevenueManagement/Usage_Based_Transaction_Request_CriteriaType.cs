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
	public class Usage_Based_Transaction_Request_CriteriaType : INotifyPropertyChanged
	{
		private Customer_ContractObjectType[] contracts_ReferenceField;

		private CustomerObjectType[] customers_ReferenceField;

		private DateTime start_Transaction_DateField;

		private bool start_Transaction_DateFieldSpecified;

		private DateTime end_Transaction_DateField;

		private bool end_Transaction_DateFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Contracts_Reference", Order = 0)]
		public Customer_ContractObjectType[] Contracts_Reference
		{
			get
			{
				return this.contracts_ReferenceField;
			}
			set
			{
				this.contracts_ReferenceField = value;
				this.RaisePropertyChanged("Contracts_Reference");
			}
		}

		[XmlElement("Customers_Reference", Order = 1)]
		public CustomerObjectType[] Customers_Reference
		{
			get
			{
				return this.customers_ReferenceField;
			}
			set
			{
				this.customers_ReferenceField = value;
				this.RaisePropertyChanged("Customers_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 2)]
		public DateTime Start_Transaction_Date
		{
			get
			{
				return this.start_Transaction_DateField;
			}
			set
			{
				this.start_Transaction_DateField = value;
				this.RaisePropertyChanged("Start_Transaction_Date");
			}
		}

		[XmlIgnore]
		public bool Start_Transaction_DateSpecified
		{
			get
			{
				return this.start_Transaction_DateFieldSpecified;
			}
			set
			{
				this.start_Transaction_DateFieldSpecified = value;
				this.RaisePropertyChanged("Start_Transaction_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 3)]
		public DateTime End_Transaction_Date
		{
			get
			{
				return this.end_Transaction_DateField;
			}
			set
			{
				this.end_Transaction_DateField = value;
				this.RaisePropertyChanged("End_Transaction_Date");
			}
		}

		[XmlIgnore]
		public bool End_Transaction_DateSpecified
		{
			get
			{
				return this.end_Transaction_DateFieldSpecified;
			}
			set
			{
				this.end_Transaction_DateFieldSpecified = value;
				this.RaisePropertyChanged("End_Transaction_DateSpecified");
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
