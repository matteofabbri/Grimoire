using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class XMLNAME_1099_MISC_State_Box_DataType : INotifyPropertyChanged
	{
		private Country_RegionObjectType country_Region_ReferenceField;

		private string state_Payer_IDField;

		private decimal state_Income_AmountField;

		private bool state_Income_AmountFieldSpecified;

		private decimal state_Income_Tax_Withholding_AmountField;

		private bool state_Income_Tax_Withholding_AmountFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Country_RegionObjectType Country_Region_Reference
		{
			get
			{
				return this.country_Region_ReferenceField;
			}
			set
			{
				this.country_Region_ReferenceField = value;
				this.RaisePropertyChanged("Country_Region_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public string State_Payer_ID
		{
			get
			{
				return this.state_Payer_IDField;
			}
			set
			{
				this.state_Payer_IDField = value;
				this.RaisePropertyChanged("State_Payer_ID");
			}
		}

		[XmlElement(Order = 2)]
		public decimal State_Income_Amount
		{
			get
			{
				return this.state_Income_AmountField;
			}
			set
			{
				this.state_Income_AmountField = value;
				this.RaisePropertyChanged("State_Income_Amount");
			}
		}

		[XmlIgnore]
		public bool State_Income_AmountSpecified
		{
			get
			{
				return this.state_Income_AmountFieldSpecified;
			}
			set
			{
				this.state_Income_AmountFieldSpecified = value;
				this.RaisePropertyChanged("State_Income_AmountSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public decimal State_Income_Tax_Withholding_Amount
		{
			get
			{
				return this.state_Income_Tax_Withholding_AmountField;
			}
			set
			{
				this.state_Income_Tax_Withholding_AmountField = value;
				this.RaisePropertyChanged("State_Income_Tax_Withholding_Amount");
			}
		}

		[XmlIgnore]
		public bool State_Income_Tax_Withholding_AmountSpecified
		{
			get
			{
				return this.state_Income_Tax_Withholding_AmountFieldSpecified;
			}
			set
			{
				this.state_Income_Tax_Withholding_AmountFieldSpecified = value;
				this.RaisePropertyChanged("State_Income_Tax_Withholding_AmountSpecified");
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
