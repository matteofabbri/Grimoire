using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.HumanResources
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Contract_Details_DataType : INotifyPropertyChanged
	{
		private decimal contract_Pay_RateField;

		private bool contract_Pay_RateFieldSpecified;

		private Currency_Reference_DataType currency_Reference_DataField;

		private Frequency_Reference_DataType[] frequency_Reference_DataField;

		private string contract_Assignment_DetailsField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public decimal Contract_Pay_Rate
		{
			get
			{
				return this.contract_Pay_RateField;
			}
			set
			{
				this.contract_Pay_RateField = value;
				this.RaisePropertyChanged("Contract_Pay_Rate");
			}
		}

		[XmlIgnore]
		public bool Contract_Pay_RateSpecified
		{
			get
			{
				return this.contract_Pay_RateFieldSpecified;
			}
			set
			{
				this.contract_Pay_RateFieldSpecified = value;
				this.RaisePropertyChanged("Contract_Pay_RateSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public Currency_Reference_DataType Currency_Reference_Data
		{
			get
			{
				return this.currency_Reference_DataField;
			}
			set
			{
				this.currency_Reference_DataField = value;
				this.RaisePropertyChanged("Currency_Reference_Data");
			}
		}

		[XmlElement("Frequency_Reference_Data", Order = 2)]
		public Frequency_Reference_DataType[] Frequency_Reference_Data
		{
			get
			{
				return this.frequency_Reference_DataField;
			}
			set
			{
				this.frequency_Reference_DataField = value;
				this.RaisePropertyChanged("Frequency_Reference_Data");
			}
		}

		[XmlElement(Order = 3)]
		public string Contract_Assignment_Details
		{
			get
			{
				return this.contract_Assignment_DetailsField;
			}
			set
			{
				this.contract_Assignment_DetailsField = value;
				this.RaisePropertyChanged("Contract_Assignment_Details");
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
