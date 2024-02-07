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
	public class Company_Customer_Payment_Auto_Application_Configuration_DataType : INotifyPropertyChanged
	{
		private bool advancedField;

		private bool advancedFieldSpecified;

		private Customer_Payment_Application_Rule_SetObjectType customer_Payment_Application_Rule_Set_ReferenceField;

		private bool do_Not_Apply_Payment_to_Invoices_on_HoldField;

		private bool do_Not_Apply_Payment_to_Invoices_on_HoldFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public bool Advanced
		{
			get
			{
				return this.advancedField;
			}
			set
			{
				this.advancedField = value;
				this.RaisePropertyChanged("Advanced");
			}
		}

		[XmlIgnore]
		public bool AdvancedSpecified
		{
			get
			{
				return this.advancedFieldSpecified;
			}
			set
			{
				this.advancedFieldSpecified = value;
				this.RaisePropertyChanged("AdvancedSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public Customer_Payment_Application_Rule_SetObjectType Customer_Payment_Application_Rule_Set_Reference
		{
			get
			{
				return this.customer_Payment_Application_Rule_Set_ReferenceField;
			}
			set
			{
				this.customer_Payment_Application_Rule_Set_ReferenceField = value;
				this.RaisePropertyChanged("Customer_Payment_Application_Rule_Set_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public bool Do_Not_Apply_Payment_to_Invoices_on_Hold
		{
			get
			{
				return this.do_Not_Apply_Payment_to_Invoices_on_HoldField;
			}
			set
			{
				this.do_Not_Apply_Payment_to_Invoices_on_HoldField = value;
				this.RaisePropertyChanged("Do_Not_Apply_Payment_to_Invoices_on_Hold");
			}
		}

		[XmlIgnore]
		public bool Do_Not_Apply_Payment_to_Invoices_on_HoldSpecified
		{
			get
			{
				return this.do_Not_Apply_Payment_to_Invoices_on_HoldFieldSpecified;
			}
			set
			{
				this.do_Not_Apply_Payment_to_Invoices_on_HoldFieldSpecified = value;
				this.RaisePropertyChanged("Do_Not_Apply_Payment_to_Invoices_on_HoldSpecified");
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
