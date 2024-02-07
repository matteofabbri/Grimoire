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
	public class On_Demand_Payment_DataType : INotifyPropertyChanged
	{
		private bool use_Supplemental_Tax_RateField;

		private bool use_Supplemental_Tax_RateFieldSpecified;

		private bool override_Payment_to_CheckField;

		private bool override_Payment_to_CheckFieldSpecified;

		private Payment_TypeObjectType payment_Type_ID_ReferenceField;

		private bool pay_to_Balance_AccountField;

		private bool pay_to_Balance_AccountFieldSpecified;

		private bool take_Additional_WithholdingField;

		private bool take_Additional_WithholdingFieldSpecified;

		private bool include_Retro_Differences_in_PaymentField;

		private bool include_Retro_Differences_in_PaymentFieldSpecified;

		private bool load_or_Refresh_InputField;

		private bool load_or_Refresh_InputFieldSpecified;

		private Tax_Frequency_Override_DataType[] tax_Frequency_OverrideField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public bool Use_Supplemental_Tax_Rate
		{
			get
			{
				return this.use_Supplemental_Tax_RateField;
			}
			set
			{
				this.use_Supplemental_Tax_RateField = value;
				this.RaisePropertyChanged("Use_Supplemental_Tax_Rate");
			}
		}

		[XmlIgnore]
		public bool Use_Supplemental_Tax_RateSpecified
		{
			get
			{
				return this.use_Supplemental_Tax_RateFieldSpecified;
			}
			set
			{
				this.use_Supplemental_Tax_RateFieldSpecified = value;
				this.RaisePropertyChanged("Use_Supplemental_Tax_RateSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public bool Override_Payment_to_Check
		{
			get
			{
				return this.override_Payment_to_CheckField;
			}
			set
			{
				this.override_Payment_to_CheckField = value;
				this.RaisePropertyChanged("Override_Payment_to_Check");
			}
		}

		[XmlIgnore]
		public bool Override_Payment_to_CheckSpecified
		{
			get
			{
				return this.override_Payment_to_CheckFieldSpecified;
			}
			set
			{
				this.override_Payment_to_CheckFieldSpecified = value;
				this.RaisePropertyChanged("Override_Payment_to_CheckSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public Payment_TypeObjectType Payment_Type_ID_Reference
		{
			get
			{
				return this.payment_Type_ID_ReferenceField;
			}
			set
			{
				this.payment_Type_ID_ReferenceField = value;
				this.RaisePropertyChanged("Payment_Type_ID_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public bool Pay_to_Balance_Account
		{
			get
			{
				return this.pay_to_Balance_AccountField;
			}
			set
			{
				this.pay_to_Balance_AccountField = value;
				this.RaisePropertyChanged("Pay_to_Balance_Account");
			}
		}

		[XmlIgnore]
		public bool Pay_to_Balance_AccountSpecified
		{
			get
			{
				return this.pay_to_Balance_AccountFieldSpecified;
			}
			set
			{
				this.pay_to_Balance_AccountFieldSpecified = value;
				this.RaisePropertyChanged("Pay_to_Balance_AccountSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public bool Take_Additional_Withholding
		{
			get
			{
				return this.take_Additional_WithholdingField;
			}
			set
			{
				this.take_Additional_WithholdingField = value;
				this.RaisePropertyChanged("Take_Additional_Withholding");
			}
		}

		[XmlIgnore]
		public bool Take_Additional_WithholdingSpecified
		{
			get
			{
				return this.take_Additional_WithholdingFieldSpecified;
			}
			set
			{
				this.take_Additional_WithholdingFieldSpecified = value;
				this.RaisePropertyChanged("Take_Additional_WithholdingSpecified");
			}
		}

		[XmlElement(Order = 5)]
		public bool Include_Retro_Differences_in_Payment
		{
			get
			{
				return this.include_Retro_Differences_in_PaymentField;
			}
			set
			{
				this.include_Retro_Differences_in_PaymentField = value;
				this.RaisePropertyChanged("Include_Retro_Differences_in_Payment");
			}
		}

		[XmlIgnore]
		public bool Include_Retro_Differences_in_PaymentSpecified
		{
			get
			{
				return this.include_Retro_Differences_in_PaymentFieldSpecified;
			}
			set
			{
				this.include_Retro_Differences_in_PaymentFieldSpecified = value;
				this.RaisePropertyChanged("Include_Retro_Differences_in_PaymentSpecified");
			}
		}

		[XmlElement(Order = 6)]
		public bool Load_or_Refresh_Input
		{
			get
			{
				return this.load_or_Refresh_InputField;
			}
			set
			{
				this.load_or_Refresh_InputField = value;
				this.RaisePropertyChanged("Load_or_Refresh_Input");
			}
		}

		[XmlIgnore]
		public bool Load_or_Refresh_InputSpecified
		{
			get
			{
				return this.load_or_Refresh_InputFieldSpecified;
			}
			set
			{
				this.load_or_Refresh_InputFieldSpecified = value;
				this.RaisePropertyChanged("Load_or_Refresh_InputSpecified");
			}
		}

		[XmlElement("Tax_Frequency_Override", Order = 7)]
		public Tax_Frequency_Override_DataType[] Tax_Frequency_Override
		{
			get
			{
				return this.tax_Frequency_OverrideField;
			}
			set
			{
				this.tax_Frequency_OverrideField = value;
				this.RaisePropertyChanged("Tax_Frequency_Override");
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
