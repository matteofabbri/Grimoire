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
	public class Payroll_Payee_County_Election_for_State_and_LocalType : INotifyPropertyChanged
	{
		private DateTime effective_DateField;

		private bool effective_DateFieldSpecified;

		private Tax_Address_TypeObjectType tax_Address_Type_ReferenceField;

		private Payroll_Local_AuthorityObjectType payroll_Local_County_Authority_ReferenceField;

		private decimal county_Additional_AmountField;

		private bool county_Additional_AmountFieldSpecified;

		private bool inactivate_State_TaxField;

		private bool inactivate_State_TaxFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(DataType = "date", Order = 0)]
		public DateTime Effective_Date
		{
			get
			{
				return this.effective_DateField;
			}
			set
			{
				this.effective_DateField = value;
				this.RaisePropertyChanged("Effective_Date");
			}
		}

		[XmlIgnore]
		public bool Effective_DateSpecified
		{
			get
			{
				return this.effective_DateFieldSpecified;
			}
			set
			{
				this.effective_DateFieldSpecified = value;
				this.RaisePropertyChanged("Effective_DateSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public Tax_Address_TypeObjectType Tax_Address_Type_Reference
		{
			get
			{
				return this.tax_Address_Type_ReferenceField;
			}
			set
			{
				this.tax_Address_Type_ReferenceField = value;
				this.RaisePropertyChanged("Tax_Address_Type_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public Payroll_Local_AuthorityObjectType Payroll_Local_County_Authority_Reference
		{
			get
			{
				return this.payroll_Local_County_Authority_ReferenceField;
			}
			set
			{
				this.payroll_Local_County_Authority_ReferenceField = value;
				this.RaisePropertyChanged("Payroll_Local_County_Authority_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public decimal County_Additional_Amount
		{
			get
			{
				return this.county_Additional_AmountField;
			}
			set
			{
				this.county_Additional_AmountField = value;
				this.RaisePropertyChanged("County_Additional_Amount");
			}
		}

		[XmlIgnore]
		public bool County_Additional_AmountSpecified
		{
			get
			{
				return this.county_Additional_AmountFieldSpecified;
			}
			set
			{
				this.county_Additional_AmountFieldSpecified = value;
				this.RaisePropertyChanged("County_Additional_AmountSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public bool Inactivate_State_Tax
		{
			get
			{
				return this.inactivate_State_TaxField;
			}
			set
			{
				this.inactivate_State_TaxField = value;
				this.RaisePropertyChanged("Inactivate_State_Tax");
			}
		}

		[XmlIgnore]
		public bool Inactivate_State_TaxSpecified
		{
			get
			{
				return this.inactivate_State_TaxFieldSpecified;
			}
			set
			{
				this.inactivate_State_TaxFieldSpecified = value;
				this.RaisePropertyChanged("Inactivate_State_TaxSpecified");
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
