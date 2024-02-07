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
	public class Quarterly_Tax_Filing_Category_DataType : INotifyPropertyChanged
	{
		private bool third_Party_Sick_PayField;

		private bool third_Party_Sick_PayFieldSpecified;

		private Unique_IdentifierObjectType tax_Filing_Category_ReferenceField;

		private decimal total_Tax_Filing_Category_AmountField;

		private bool total_Tax_Filing_Category_AmountFieldSpecified;

		private decimal yTD_Total_Tax_Filing_Category_AmountField;

		private bool yTD_Total_Tax_Filing_Category_AmountFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public bool Third_Party_Sick_Pay
		{
			get
			{
				return this.third_Party_Sick_PayField;
			}
			set
			{
				this.third_Party_Sick_PayField = value;
				this.RaisePropertyChanged("Third_Party_Sick_Pay");
			}
		}

		[XmlIgnore]
		public bool Third_Party_Sick_PaySpecified
		{
			get
			{
				return this.third_Party_Sick_PayFieldSpecified;
			}
			set
			{
				this.third_Party_Sick_PayFieldSpecified = value;
				this.RaisePropertyChanged("Third_Party_Sick_PaySpecified");
			}
		}

		[XmlElement(Order = 1)]
		public Unique_IdentifierObjectType Tax_Filing_Category_Reference
		{
			get
			{
				return this.tax_Filing_Category_ReferenceField;
			}
			set
			{
				this.tax_Filing_Category_ReferenceField = value;
				this.RaisePropertyChanged("Tax_Filing_Category_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public decimal Total_Tax_Filing_Category_Amount
		{
			get
			{
				return this.total_Tax_Filing_Category_AmountField;
			}
			set
			{
				this.total_Tax_Filing_Category_AmountField = value;
				this.RaisePropertyChanged("Total_Tax_Filing_Category_Amount");
			}
		}

		[XmlIgnore]
		public bool Total_Tax_Filing_Category_AmountSpecified
		{
			get
			{
				return this.total_Tax_Filing_Category_AmountFieldSpecified;
			}
			set
			{
				this.total_Tax_Filing_Category_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Total_Tax_Filing_Category_AmountSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public decimal YTD_Total_Tax_Filing_Category_Amount
		{
			get
			{
				return this.yTD_Total_Tax_Filing_Category_AmountField;
			}
			set
			{
				this.yTD_Total_Tax_Filing_Category_AmountField = value;
				this.RaisePropertyChanged("YTD_Total_Tax_Filing_Category_Amount");
			}
		}

		[XmlIgnore]
		public bool YTD_Total_Tax_Filing_Category_AmountSpecified
		{
			get
			{
				return this.yTD_Total_Tax_Filing_Category_AmountFieldSpecified;
			}
			set
			{
				this.yTD_Total_Tax_Filing_Category_AmountFieldSpecified = value;
				this.RaisePropertyChanged("YTD_Total_Tax_Filing_Category_AmountSpecified");
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
