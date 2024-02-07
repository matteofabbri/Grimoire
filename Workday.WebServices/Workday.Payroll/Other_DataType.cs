using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Payroll
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Other_DataType : INotifyPropertyChanged
	{
		private string labelField;

		private decimal amountField;

		private bool amountFieldSpecified;

		private bool customer_OwnedField;

		private bool customer_OwnedFieldSpecified;

		private string plan_NumberField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Label
		{
			get
			{
				return this.labelField;
			}
			set
			{
				this.labelField = value;
				this.RaisePropertyChanged("Label");
			}
		}

		[XmlElement(Order = 1)]
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

		[XmlElement(Order = 2)]
		public bool Customer_Owned
		{
			get
			{
				return this.customer_OwnedField;
			}
			set
			{
				this.customer_OwnedField = value;
				this.RaisePropertyChanged("Customer_Owned");
			}
		}

		[XmlIgnore]
		public bool Customer_OwnedSpecified
		{
			get
			{
				return this.customer_OwnedFieldSpecified;
			}
			set
			{
				this.customer_OwnedFieldSpecified = value;
				this.RaisePropertyChanged("Customer_OwnedSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public string Plan_Number
		{
			get
			{
				return this.plan_NumberField;
			}
			set
			{
				this.plan_NumberField = value;
				this.RaisePropertyChanged("Plan_Number");
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
