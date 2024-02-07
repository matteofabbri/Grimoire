using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.SettlementServices
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Payroll_Remittance_Taxable_Wages_DataType : INotifyPropertyChanged
	{
		private string gB_NameField;

		private string nameField;

		private decimal amountField;

		private bool amountFieldSpecified;

		private decimal yTDField;

		private bool yTDFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string GB_Name
		{
			get
			{
				return this.gB_NameField;
			}
			set
			{
				this.gB_NameField = value;
				this.RaisePropertyChanged("GB_Name");
			}
		}

		[XmlElement(Order = 1)]
		public string Name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
				this.RaisePropertyChanged("Name");
			}
		}

		[XmlElement(Order = 2)]
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

		[XmlElement(Order = 3)]
		public decimal YTD
		{
			get
			{
				return this.yTDField;
			}
			set
			{
				this.yTDField = value;
				this.RaisePropertyChanged("YTD");
			}
		}

		[XmlIgnore]
		public bool YTDSpecified
		{
			get
			{
				return this.yTDFieldSpecified;
			}
			set
			{
				this.yTDFieldSpecified = value;
				this.RaisePropertyChanged("YTDSpecified");
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
