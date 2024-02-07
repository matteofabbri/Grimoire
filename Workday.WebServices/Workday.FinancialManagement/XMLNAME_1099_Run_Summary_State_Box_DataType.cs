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
	public class XMLNAME_1099_Run_Summary_State_Box_DataType : INotifyPropertyChanged
	{
		private Country_RegionObjectType country_Region_ReferenceField;

		private decimal total_State_Income_AmountField;

		private bool total_State_Income_AmountFieldSpecified;

		private decimal total_State_Income_Tax_Withholding_AmountField;

		private bool total_State_Income_Tax_Withholding_AmountFieldSpecified;

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
		public decimal Total_State_Income_Amount
		{
			get
			{
				return this.total_State_Income_AmountField;
			}
			set
			{
				this.total_State_Income_AmountField = value;
				this.RaisePropertyChanged("Total_State_Income_Amount");
			}
		}

		[XmlIgnore]
		public bool Total_State_Income_AmountSpecified
		{
			get
			{
				return this.total_State_Income_AmountFieldSpecified;
			}
			set
			{
				this.total_State_Income_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Total_State_Income_AmountSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public decimal Total_State_Income_Tax_Withholding_Amount
		{
			get
			{
				return this.total_State_Income_Tax_Withholding_AmountField;
			}
			set
			{
				this.total_State_Income_Tax_Withholding_AmountField = value;
				this.RaisePropertyChanged("Total_State_Income_Tax_Withholding_Amount");
			}
		}

		[XmlIgnore]
		public bool Total_State_Income_Tax_Withholding_AmountSpecified
		{
			get
			{
				return this.total_State_Income_Tax_Withholding_AmountFieldSpecified;
			}
			set
			{
				this.total_State_Income_Tax_Withholding_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Total_State_Income_Tax_Withholding_AmountSpecified");
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
