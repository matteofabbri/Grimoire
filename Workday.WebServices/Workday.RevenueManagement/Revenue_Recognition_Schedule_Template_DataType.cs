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
	public class Revenue_Recognition_Schedule_Template_DataType : INotifyPropertyChanged
	{
		private string revenue_Recognition_Schedule_Template_IDField;

		private string revenue_Recognition_Schedule_Template_NameField;

		private string schedule_DescriptionField;

		private Schedule_Distribution_MethodObjectType revenue_Recognition_Method_ReferenceField;

		private Frequency_BehaviorObjectType frequency_ReferenceField;

		private Percent_Complete_MethodObjectType percent_Complete_Method_ReferenceField;

		private Schedule_TypeObjectType schedule_Type_ReferenceField;

		private Sales_ItemObjectType[] sales_Item_ReferenceField;

		private decimal number_of_InstallmentsField;

		private bool number_of_InstallmentsFieldSpecified;

		private bool use_To_Date_on_ContractField;

		private bool use_To_Date_on_ContractFieldSpecified;

		private bool automatically_Generate_InstallmentsField;

		private bool automatically_Generate_InstallmentsFieldSpecified;

		private bool automatically_Submit_Schedule_for_ApprovalField;

		private bool automatically_Submit_Schedule_for_ApprovalFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Revenue_Recognition_Schedule_Template_ID
		{
			get
			{
				return this.revenue_Recognition_Schedule_Template_IDField;
			}
			set
			{
				this.revenue_Recognition_Schedule_Template_IDField = value;
				this.RaisePropertyChanged("Revenue_Recognition_Schedule_Template_ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Revenue_Recognition_Schedule_Template_Name
		{
			get
			{
				return this.revenue_Recognition_Schedule_Template_NameField;
			}
			set
			{
				this.revenue_Recognition_Schedule_Template_NameField = value;
				this.RaisePropertyChanged("Revenue_Recognition_Schedule_Template_Name");
			}
		}

		[XmlElement(Order = 2)]
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

		[XmlElement(Order = 3)]
		public Schedule_Distribution_MethodObjectType Revenue_Recognition_Method_Reference
		{
			get
			{
				return this.revenue_Recognition_Method_ReferenceField;
			}
			set
			{
				this.revenue_Recognition_Method_ReferenceField = value;
				this.RaisePropertyChanged("Revenue_Recognition_Method_Reference");
			}
		}

		[XmlElement(Order = 4)]
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

		[XmlElement(Order = 5)]
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

		[XmlElement(Order = 6)]
		public Schedule_TypeObjectType Schedule_Type_Reference
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

		[XmlElement("Sales_Item_Reference", Order = 7)]
		public Sales_ItemObjectType[] Sales_Item_Reference
		{
			get
			{
				return this.sales_Item_ReferenceField;
			}
			set
			{
				this.sales_Item_ReferenceField = value;
				this.RaisePropertyChanged("Sales_Item_Reference");
			}
		}

		[XmlElement(Order = 8)]
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

		[XmlElement(Order = 9)]
		public bool Use_To_Date_on_Contract
		{
			get
			{
				return this.use_To_Date_on_ContractField;
			}
			set
			{
				this.use_To_Date_on_ContractField = value;
				this.RaisePropertyChanged("Use_To_Date_on_Contract");
			}
		}

		[XmlIgnore]
		public bool Use_To_Date_on_ContractSpecified
		{
			get
			{
				return this.use_To_Date_on_ContractFieldSpecified;
			}
			set
			{
				this.use_To_Date_on_ContractFieldSpecified = value;
				this.RaisePropertyChanged("Use_To_Date_on_ContractSpecified");
			}
		}

		[XmlElement(Order = 10)]
		public bool Automatically_Generate_Installments
		{
			get
			{
				return this.automatically_Generate_InstallmentsField;
			}
			set
			{
				this.automatically_Generate_InstallmentsField = value;
				this.RaisePropertyChanged("Automatically_Generate_Installments");
			}
		}

		[XmlIgnore]
		public bool Automatically_Generate_InstallmentsSpecified
		{
			get
			{
				return this.automatically_Generate_InstallmentsFieldSpecified;
			}
			set
			{
				this.automatically_Generate_InstallmentsFieldSpecified = value;
				this.RaisePropertyChanged("Automatically_Generate_InstallmentsSpecified");
			}
		}

		[XmlElement(Order = 11)]
		public bool Automatically_Submit_Schedule_for_Approval
		{
			get
			{
				return this.automatically_Submit_Schedule_for_ApprovalField;
			}
			set
			{
				this.automatically_Submit_Schedule_for_ApprovalField = value;
				this.RaisePropertyChanged("Automatically_Submit_Schedule_for_Approval");
			}
		}

		[XmlIgnore]
		public bool Automatically_Submit_Schedule_for_ApprovalSpecified
		{
			get
			{
				return this.automatically_Submit_Schedule_for_ApprovalFieldSpecified;
			}
			set
			{
				this.automatically_Submit_Schedule_for_ApprovalFieldSpecified = value;
				this.RaisePropertyChanged("Automatically_Submit_Schedule_for_ApprovalSpecified");
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
