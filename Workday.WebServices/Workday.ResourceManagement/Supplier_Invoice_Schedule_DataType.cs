using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Supplier_Invoice_Schedule_DataType : INotifyPropertyChanged
	{
		private string supplier_Invoice_Schedule_IDField;

		private bool submitField;

		private bool submitFieldSpecified;

		private Document_StatusObjectType[] schedule_Status_ReferenceField;

		private CompanyObjectType company_ReferenceField;

		private Resource_ProviderObjectType supplier_ReferenceField;

		private object itemField;

		private CurrencyObjectType currency_ReferenceField;

		private Supplier_ContractObjectType supplier_Contract_ReferenceField;

		private Installment_ItemObjectType[] supplier_Contract_Lines_ReferenceField;

		private string schedule_DescriptionField;

		private bool schedule_On_HoldField;

		private bool schedule_On_HoldFieldSpecified;

		private Tax_CodeObjectType tax_Code_ReferenceField;

		private Payment_TermsObjectType payment_Terms_ReferenceField;

		private Payment_TypeObjectType override_Payment_Type_ReferenceField;

		private bool autosubmit_for_ApprovalField;

		private bool autosubmit_for_ApprovalFieldSpecified;

		private string supplier_Invoice_Reference_NumberField;

		private Schedule_Distribution_MethodObjectType distribution_Method_ReferenceField;

		private bool distribute_by_QuantityField;

		private bool distribute_by_QuantityFieldSpecified;

		private Frequency_BehaviorObjectType frequency__ReferenceField;

		private DateTime from_DateField;

		private bool from_DateFieldSpecified;

		private DateTime to_DateField;

		private bool to_DateFieldSpecified;

		private decimal number_of_InstallmentsField;

		private bool number_of_InstallmentsFieldSpecified;

		private Procurement_Date_OptionObjectType date_Option_ReferenceField;

		private decimal day_of_MonthField;

		private bool day_of_MonthFieldSpecified;

		private bool automatically_Regenerate_InstallmentsField;

		private bool automatically_Regenerate_InstallmentsFieldSpecified;

		private bool automatically_Submit_SchedulesField;

		private bool automatically_Submit_SchedulesFieldSpecified;

		private bool system_GeneratedField;

		private bool system_GeneratedFieldSpecified;

		private Supplier_Invoice_Installment_Replacement_DataType[] supplier_Invoice_Installment_Replacement_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Supplier_Invoice_Schedule_ID
		{
			get
			{
				return this.supplier_Invoice_Schedule_IDField;
			}
			set
			{
				this.supplier_Invoice_Schedule_IDField = value;
				this.RaisePropertyChanged("Supplier_Invoice_Schedule_ID");
			}
		}

		[XmlElement(Order = 1)]
		public bool Submit
		{
			get
			{
				return this.submitField;
			}
			set
			{
				this.submitField = value;
				this.RaisePropertyChanged("Submit");
			}
		}

		[XmlIgnore]
		public bool SubmitSpecified
		{
			get
			{
				return this.submitFieldSpecified;
			}
			set
			{
				this.submitFieldSpecified = value;
				this.RaisePropertyChanged("SubmitSpecified");
			}
		}

		[XmlElement("Schedule_Status_Reference", Order = 2)]
		public Document_StatusObjectType[] Schedule_Status_Reference
		{
			get
			{
				return this.schedule_Status_ReferenceField;
			}
			set
			{
				this.schedule_Status_ReferenceField = value;
				this.RaisePropertyChanged("Schedule_Status_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public CompanyObjectType Company_Reference
		{
			get
			{
				return this.company_ReferenceField;
			}
			set
			{
				this.company_ReferenceField = value;
				this.RaisePropertyChanged("Company_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public Resource_ProviderObjectType Supplier_Reference
		{
			get
			{
				return this.supplier_ReferenceField;
			}
			set
			{
				this.supplier_ReferenceField = value;
				this.RaisePropertyChanged("Supplier_Reference");
			}
		}

		[XmlElement("Supplier_Connection_Reference", typeof(Supplier_ConnectionObjectType), Order = 5), XmlElement("Use_Default_Supplier_Connection", typeof(bool), Order = 5)]
		public object Item
		{
			get
			{
				return this.itemField;
			}
			set
			{
				this.itemField = value;
				this.RaisePropertyChanged("Item");
			}
		}

		[XmlElement(Order = 6)]
		public CurrencyObjectType Currency_Reference
		{
			get
			{
				return this.currency_ReferenceField;
			}
			set
			{
				this.currency_ReferenceField = value;
				this.RaisePropertyChanged("Currency_Reference");
			}
		}

		[XmlElement(Order = 7)]
		public Supplier_ContractObjectType Supplier_Contract_Reference
		{
			get
			{
				return this.supplier_Contract_ReferenceField;
			}
			set
			{
				this.supplier_Contract_ReferenceField = value;
				this.RaisePropertyChanged("Supplier_Contract_Reference");
			}
		}

		[XmlElement("Supplier_Contract_Lines_Reference", Order = 8)]
		public Installment_ItemObjectType[] Supplier_Contract_Lines_Reference
		{
			get
			{
				return this.supplier_Contract_Lines_ReferenceField;
			}
			set
			{
				this.supplier_Contract_Lines_ReferenceField = value;
				this.RaisePropertyChanged("Supplier_Contract_Lines_Reference");
			}
		}

		[XmlElement(Order = 9)]
		public string Schedule_Description
		{
			get
			{
				return this.schedule_DescriptionField;
			}
			set
			{
				this.schedule_DescriptionField = value;
				this.RaisePropertyChanged("Schedule_Description");
			}
		}

		[XmlElement(Order = 10)]
		public bool Schedule_On_Hold
		{
			get
			{
				return this.schedule_On_HoldField;
			}
			set
			{
				this.schedule_On_HoldField = value;
				this.RaisePropertyChanged("Schedule_On_Hold");
			}
		}

		[XmlIgnore]
		public bool Schedule_On_HoldSpecified
		{
			get
			{
				return this.schedule_On_HoldFieldSpecified;
			}
			set
			{
				this.schedule_On_HoldFieldSpecified = value;
				this.RaisePropertyChanged("Schedule_On_HoldSpecified");
			}
		}

		[XmlElement(Order = 11)]
		public Tax_CodeObjectType Tax_Code_Reference
		{
			get
			{
				return this.tax_Code_ReferenceField;
			}
			set
			{
				this.tax_Code_ReferenceField = value;
				this.RaisePropertyChanged("Tax_Code_Reference");
			}
		}

		[XmlElement(Order = 12)]
		public Payment_TermsObjectType Payment_Terms_Reference
		{
			get
			{
				return this.payment_Terms_ReferenceField;
			}
			set
			{
				this.payment_Terms_ReferenceField = value;
				this.RaisePropertyChanged("Payment_Terms_Reference");
			}
		}

		[XmlElement(Order = 13)]
		public Payment_TypeObjectType Override_Payment_Type_Reference
		{
			get
			{
				return this.override_Payment_Type_ReferenceField;
			}
			set
			{
				this.override_Payment_Type_ReferenceField = value;
				this.RaisePropertyChanged("Override_Payment_Type_Reference");
			}
		}

		[XmlElement("Auto-submit_for_Approval", Order = 14)]
		public bool Autosubmit_for_Approval
		{
			get
			{
				return this.autosubmit_for_ApprovalField;
			}
			set
			{
				this.autosubmit_for_ApprovalField = value;
				this.RaisePropertyChanged("Autosubmit_for_Approval");
			}
		}

		[XmlIgnore]
		public bool Autosubmit_for_ApprovalSpecified
		{
			get
			{
				return this.autosubmit_for_ApprovalFieldSpecified;
			}
			set
			{
				this.autosubmit_for_ApprovalFieldSpecified = value;
				this.RaisePropertyChanged("Autosubmit_for_ApprovalSpecified");
			}
		}

		[XmlElement(Order = 15)]
		public string Supplier_Invoice_Reference_Number
		{
			get
			{
				return this.supplier_Invoice_Reference_NumberField;
			}
			set
			{
				this.supplier_Invoice_Reference_NumberField = value;
				this.RaisePropertyChanged("Supplier_Invoice_Reference_Number");
			}
		}

		[XmlElement(Order = 16)]
		public Schedule_Distribution_MethodObjectType Distribution_Method_Reference
		{
			get
			{
				return this.distribution_Method_ReferenceField;
			}
			set
			{
				this.distribution_Method_ReferenceField = value;
				this.RaisePropertyChanged("Distribution_Method_Reference");
			}
		}

		[XmlElement(Order = 17)]
		public bool Distribute_by_Quantity
		{
			get
			{
				return this.distribute_by_QuantityField;
			}
			set
			{
				this.distribute_by_QuantityField = value;
				this.RaisePropertyChanged("Distribute_by_Quantity");
			}
		}

		[XmlIgnore]
		public bool Distribute_by_QuantitySpecified
		{
			get
			{
				return this.distribute_by_QuantityFieldSpecified;
			}
			set
			{
				this.distribute_by_QuantityFieldSpecified = value;
				this.RaisePropertyChanged("Distribute_by_QuantitySpecified");
			}
		}

		[XmlElement(Order = 18)]
		public Frequency_BehaviorObjectType Frequency__Reference
		{
			get
			{
				return this.frequency__ReferenceField;
			}
			set
			{
				this.frequency__ReferenceField = value;
				this.RaisePropertyChanged("Frequency__Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 19)]
		public DateTime From_Date
		{
			get
			{
				return this.from_DateField;
			}
			set
			{
				this.from_DateField = value;
				this.RaisePropertyChanged("From_Date");
			}
		}

		[XmlIgnore]
		public bool From_DateSpecified
		{
			get
			{
				return this.from_DateFieldSpecified;
			}
			set
			{
				this.from_DateFieldSpecified = value;
				this.RaisePropertyChanged("From_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 20)]
		public DateTime To_Date
		{
			get
			{
				return this.to_DateField;
			}
			set
			{
				this.to_DateField = value;
				this.RaisePropertyChanged("To_Date");
			}
		}

		[XmlIgnore]
		public bool To_DateSpecified
		{
			get
			{
				return this.to_DateFieldSpecified;
			}
			set
			{
				this.to_DateFieldSpecified = value;
				this.RaisePropertyChanged("To_DateSpecified");
			}
		}

		[XmlElement(Order = 21)]
		public decimal Number_of_Installments
		{
			get
			{
				return this.number_of_InstallmentsField;
			}
			set
			{
				this.number_of_InstallmentsField = value;
				this.RaisePropertyChanged("Number_of_Installments");
			}
		}

		[XmlIgnore]
		public bool Number_of_InstallmentsSpecified
		{
			get
			{
				return this.number_of_InstallmentsFieldSpecified;
			}
			set
			{
				this.number_of_InstallmentsFieldSpecified = value;
				this.RaisePropertyChanged("Number_of_InstallmentsSpecified");
			}
		}

		[XmlElement(Order = 22)]
		public Procurement_Date_OptionObjectType Date_Option_Reference
		{
			get
			{
				return this.date_Option_ReferenceField;
			}
			set
			{
				this.date_Option_ReferenceField = value;
				this.RaisePropertyChanged("Date_Option_Reference");
			}
		}

		[XmlElement(Order = 23)]
		public decimal Day_of_Month
		{
			get
			{
				return this.day_of_MonthField;
			}
			set
			{
				this.day_of_MonthField = value;
				this.RaisePropertyChanged("Day_of_Month");
			}
		}

		[XmlIgnore]
		public bool Day_of_MonthSpecified
		{
			get
			{
				return this.day_of_MonthFieldSpecified;
			}
			set
			{
				this.day_of_MonthFieldSpecified = value;
				this.RaisePropertyChanged("Day_of_MonthSpecified");
			}
		}

		[XmlElement(Order = 24)]
		public bool Automatically_Regenerate_Installments
		{
			get
			{
				return this.automatically_Regenerate_InstallmentsField;
			}
			set
			{
				this.automatically_Regenerate_InstallmentsField = value;
				this.RaisePropertyChanged("Automatically_Regenerate_Installments");
			}
		}

		[XmlIgnore]
		public bool Automatically_Regenerate_InstallmentsSpecified
		{
			get
			{
				return this.automatically_Regenerate_InstallmentsFieldSpecified;
			}
			set
			{
				this.automatically_Regenerate_InstallmentsFieldSpecified = value;
				this.RaisePropertyChanged("Automatically_Regenerate_InstallmentsSpecified");
			}
		}

		[XmlElement(Order = 25)]
		public bool Automatically_Submit_Schedules
		{
			get
			{
				return this.automatically_Submit_SchedulesField;
			}
			set
			{
				this.automatically_Submit_SchedulesField = value;
				this.RaisePropertyChanged("Automatically_Submit_Schedules");
			}
		}

		[XmlIgnore]
		public bool Automatically_Submit_SchedulesSpecified
		{
			get
			{
				return this.automatically_Submit_SchedulesFieldSpecified;
			}
			set
			{
				this.automatically_Submit_SchedulesFieldSpecified = value;
				this.RaisePropertyChanged("Automatically_Submit_SchedulesSpecified");
			}
		}

		[XmlElement(Order = 26)]
		public bool System_Generated
		{
			get
			{
				return this.system_GeneratedField;
			}
			set
			{
				this.system_GeneratedField = value;
				this.RaisePropertyChanged("System_Generated");
			}
		}

		[XmlIgnore]
		public bool System_GeneratedSpecified
		{
			get
			{
				return this.system_GeneratedFieldSpecified;
			}
			set
			{
				this.system_GeneratedFieldSpecified = value;
				this.RaisePropertyChanged("System_GeneratedSpecified");
			}
		}

		[XmlElement("Supplier_Invoice_Installment_Replacement_Data", Order = 27)]
		public Supplier_Invoice_Installment_Replacement_DataType[] Supplier_Invoice_Installment_Replacement_Data
		{
			get
			{
				return this.supplier_Invoice_Installment_Replacement_DataField;
			}
			set
			{
				this.supplier_Invoice_Installment_Replacement_DataField = value;
				this.RaisePropertyChanged("Supplier_Invoice_Installment_Replacement_Data");
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
