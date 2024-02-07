using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Revenue_Recognition_Schedule_DataType : INotifyPropertyChanged
	{
		private string revenue_Recognition_Schedule_Reference_IDField;

		private bool submitField;

		private bool submitFieldSpecified;

		private bool generate_InstallmentsField;

		private bool generate_InstallmentsFieldSpecified;

		private Document_StatusObjectType[] schedule_Status_ReferenceField;

		private Revenue_Recognition_Schedule_Controlling_TransactionObjectType controlling_Transaction_ReferenceField;

		private CurrencyObjectType currency_ReferenceField;

		private CompanyObjectType company_ReferenceField;

		private CompanyObjectType intercompany_Header_Company_ReferenceField;

		private Billable_EntityObjectType customer_ReferenceField;

		private Schedule_TypeObjectType[] schedule_Type_ReferenceField;

		private bool schedule_On_HoldField;

		private bool schedule_On_HoldFieldSpecified;

		private string schedule_DescriptionField;

		private Milestone_AbstractObjectType[] milestone_ReferenceField;

		private Schedule_Distribution_MethodObjectType amount_Distribution_Method_ReferenceField;

		private Frequency_BehaviorObjectType frequency_ReferenceField;

		private Percent_Complete_MethodObjectType percent_Complete_Method_ReferenceField;

		private bool create_ReversalField;

		private bool create_ReversalFieldSpecified;

		private DateTime from_DateField;

		private bool from_DateFieldSpecified;

		private DateTime to_DateField;

		private bool to_DateFieldSpecified;

		private decimal number_of_InstallmentsField;

		private bool number_of_InstallmentsFieldSpecified;

		private Customer_Installment_ItemObjectType[] line_ReferenceField;

		private Revenue_Recognition_Installment_DataType[] revenue_Recognition_Installment_DataField;

		private Customer_Contract_Schedule_Installment_Schedule_DataType[] revenue_Recognition_Schedule_Installment_Schedule_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Revenue_Recognition_Schedule_Reference_ID
		{
			get
			{
				return this.revenue_Recognition_Schedule_Reference_IDField;
			}
			set
			{
				this.revenue_Recognition_Schedule_Reference_IDField = value;
				this.RaisePropertyChanged("Revenue_Recognition_Schedule_Reference_ID");
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

		[XmlElement(Order = 2)]
		public bool Generate_Installments
		{
			get
			{
				return this.generate_InstallmentsField;
			}
			set
			{
				this.generate_InstallmentsField = value;
				this.RaisePropertyChanged("Generate_Installments");
			}
		}

		[XmlIgnore]
		public bool Generate_InstallmentsSpecified
		{
			get
			{
				return this.generate_InstallmentsFieldSpecified;
			}
			set
			{
				this.generate_InstallmentsFieldSpecified = value;
				this.RaisePropertyChanged("Generate_InstallmentsSpecified");
			}
		}

		[XmlElement("Schedule_Status_Reference", Order = 3)]
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

		[XmlElement(Order = 4)]
		public Revenue_Recognition_Schedule_Controlling_TransactionObjectType Controlling_Transaction_Reference
		{
			get
			{
				return this.controlling_Transaction_ReferenceField;
			}
			set
			{
				this.controlling_Transaction_ReferenceField = value;
				this.RaisePropertyChanged("Controlling_Transaction_Reference");
			}
		}

		[XmlElement(Order = 5)]
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

		[XmlElement(Order = 6)]
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

		[XmlElement(Order = 7)]
		public CompanyObjectType Intercompany_Header_Company_Reference
		{
			get
			{
				return this.intercompany_Header_Company_ReferenceField;
			}
			set
			{
				this.intercompany_Header_Company_ReferenceField = value;
				this.RaisePropertyChanged("Intercompany_Header_Company_Reference");
			}
		}

		[XmlElement(Order = 8)]
		public Billable_EntityObjectType Customer_Reference
		{
			get
			{
				return this.customer_ReferenceField;
			}
			set
			{
				this.customer_ReferenceField = value;
				this.RaisePropertyChanged("Customer_Reference");
			}
		}

		[XmlElement("Schedule_Type_Reference", Order = 9)]
		public Schedule_TypeObjectType[] Schedule_Type_Reference
		{
			get
			{
				return this.schedule_Type_ReferenceField;
			}
			set
			{
				this.schedule_Type_ReferenceField = value;
				this.RaisePropertyChanged("Schedule_Type_Reference");
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

		[XmlElement("Milestone_Reference", Order = 12)]
		public Milestone_AbstractObjectType[] Milestone_Reference
		{
			get
			{
				return this.milestone_ReferenceField;
			}
			set
			{
				this.milestone_ReferenceField = value;
				this.RaisePropertyChanged("Milestone_Reference");
			}
		}

		[XmlElement(Order = 13)]
		public Schedule_Distribution_MethodObjectType Amount_Distribution_Method_Reference
		{
			get
			{
				return this.amount_Distribution_Method_ReferenceField;
			}
			set
			{
				this.amount_Distribution_Method_ReferenceField = value;
				this.RaisePropertyChanged("Amount_Distribution_Method_Reference");
			}
		}

		[XmlElement(Order = 14)]
		public Frequency_BehaviorObjectType Frequency_Reference
		{
			get
			{
				return this.frequency_ReferenceField;
			}
			set
			{
				this.frequency_ReferenceField = value;
				this.RaisePropertyChanged("Frequency_Reference");
			}
		}

		[XmlElement(Order = 15)]
		public Percent_Complete_MethodObjectType Percent_Complete_Method_Reference
		{
			get
			{
				return this.percent_Complete_Method_ReferenceField;
			}
			set
			{
				this.percent_Complete_Method_ReferenceField = value;
				this.RaisePropertyChanged("Percent_Complete_Method_Reference");
			}
		}

		[XmlElement(Order = 16)]
		public bool Create_Reversal
		{
			get
			{
				return this.create_ReversalField;
			}
			set
			{
				this.create_ReversalField = value;
				this.RaisePropertyChanged("Create_Reversal");
			}
		}

		[XmlIgnore]
		public bool Create_ReversalSpecified
		{
			get
			{
				return this.create_ReversalFieldSpecified;
			}
			set
			{
				this.create_ReversalFieldSpecified = value;
				this.RaisePropertyChanged("Create_ReversalSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 17)]
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

		[XmlElement(DataType = "date", Order = 18)]
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

		[XmlElement(Order = 19)]
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

		[XmlElement("Line_Reference", Order = 20)]
		public Customer_Installment_ItemObjectType[] Line_Reference
		{
			get
			{
				return this.line_ReferenceField;
			}
			set
			{
				this.line_ReferenceField = value;
				this.RaisePropertyChanged("Line_Reference");
			}
		}

		[XmlElement("Revenue_Recognition_Installment_Data", Order = 21)]
		public Revenue_Recognition_Installment_DataType[] Revenue_Recognition_Installment_Data
		{
			get
			{
				return this.revenue_Recognition_Installment_DataField;
			}
			set
			{
				this.revenue_Recognition_Installment_DataField = value;
				this.RaisePropertyChanged("Revenue_Recognition_Installment_Data");
			}
		}

		[XmlElement("Revenue_Recognition_Schedule_Installment_Schedule_Data", Order = 22)]
		public Customer_Contract_Schedule_Installment_Schedule_DataType[] Revenue_Recognition_Schedule_Installment_Schedule_Data
		{
			get
			{
				return this.revenue_Recognition_Schedule_Installment_Schedule_DataField;
			}
			set
			{
				this.revenue_Recognition_Schedule_Installment_Schedule_DataField = value;
				this.RaisePropertyChanged("Revenue_Recognition_Schedule_Installment_Schedule_Data");
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
