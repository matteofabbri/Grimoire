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
	public class Billing_Rate_Rule_DataType : INotifyPropertyChanged
	{
		private Billing_Rate_RuleObjectType billing_Rate_Rule_ReferenceField;

		private string orderField;

		private Frequency_BehaviorObjectType reset_Frequency_ReferenceField;

		private DateTime start_Date_for_ResetField;

		private bool start_Date_for_ResetFieldSpecified;

		private Billing_Rate_Adjustment_TypeObjectType adjustment_Type_ReferenceField;

		private decimal amountField;

		private bool amountFieldSpecified;

		private decimal percentField;

		private bool percentFieldSpecified;

		private string mark_Up_or_Discount_LabelField;

		private Billing_Rate_Break_TypeObjectType by_Amount_or_Hours_ReferenceField;

		private decimal cap_AmountField;

		private bool cap_AmountFieldSpecified;

		private decimal cap_UnitsField;

		private bool cap_UnitsFieldSpecified;

		private Project_PhaseObjectType[] project_Phase_ReferenceField;

		private Project_TaskObjectType[] project_Task_ReferenceField;

		private Project_RoleObjectType[] project_Role_ReferenceField;

		private WorkerObjectType[] worker_ReferenceField;

		private Expense_ItemObjectType[] expense_Item_ReferenceField;

		private Spend_CategoryObjectType[] spend_Category_ReferenceField;

		private string internal_NameField;

		private string notesField;

		private Accounting_WorktagObjectType[] billing_Rate_Rule_Worktag_ReferenceField;

		private Billing_Rate_Rule_Break_DataType[] billing_Rate_Rule_Break_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Billing_Rate_RuleObjectType Billing_Rate_Rule_Reference
		{
			get
			{
				return this.billing_Rate_Rule_ReferenceField;
			}
			set
			{
				this.billing_Rate_Rule_ReferenceField = value;
				this.RaisePropertyChanged("Billing_Rate_Rule_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public string Order
		{
			get
			{
				return this.orderField;
			}
			set
			{
				this.orderField = value;
				this.RaisePropertyChanged("Order");
			}
		}

		[XmlElement(Order = 2)]
		public Frequency_BehaviorObjectType Reset_Frequency_Reference
		{
			get
			{
				return this.reset_Frequency_ReferenceField;
			}
			set
			{
				this.reset_Frequency_ReferenceField = value;
				this.RaisePropertyChanged("Reset_Frequency_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 3)]
		public DateTime Start_Date_for_Reset
		{
			get
			{
				return this.start_Date_for_ResetField;
			}
			set
			{
				this.start_Date_for_ResetField = value;
				this.RaisePropertyChanged("Start_Date_for_Reset");
			}
		}

		[XmlIgnore]
		public bool Start_Date_for_ResetSpecified
		{
			get
			{
				return this.start_Date_for_ResetFieldSpecified;
			}
			set
			{
				this.start_Date_for_ResetFieldSpecified = value;
				this.RaisePropertyChanged("Start_Date_for_ResetSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public Billing_Rate_Adjustment_TypeObjectType Adjustment_Type_Reference
		{
			get
			{
				return this.adjustment_Type_ReferenceField;
			}
			set
			{
				this.adjustment_Type_ReferenceField = value;
				this.RaisePropertyChanged("Adjustment_Type_Reference");
			}
		}

		[XmlElement(Order = 5)]
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

		[XmlElement(Order = 6)]
		public decimal Percent
		{
			get
			{
				return this.percentField;
			}
			set
			{
				this.percentField = value;
				this.RaisePropertyChanged("Percent");
			}
		}

		[XmlIgnore]
		public bool PercentSpecified
		{
			get
			{
				return this.percentFieldSpecified;
			}
			set
			{
				this.percentFieldSpecified = value;
				this.RaisePropertyChanged("PercentSpecified");
			}
		}

		[XmlElement(Order = 7)]
		public string Mark_Up_or_Discount_Label
		{
			get
			{
				return this.mark_Up_or_Discount_LabelField;
			}
			set
			{
				this.mark_Up_or_Discount_LabelField = value;
				this.RaisePropertyChanged("Mark_Up_or_Discount_Label");
			}
		}

		[XmlElement(Order = 8)]
		public Billing_Rate_Break_TypeObjectType By_Amount_or_Hours_Reference
		{
			get
			{
				return this.by_Amount_or_Hours_ReferenceField;
			}
			set
			{
				this.by_Amount_or_Hours_ReferenceField = value;
				this.RaisePropertyChanged("By_Amount_or_Hours_Reference");
			}
		}

		[XmlElement(Order = 9)]
		public decimal Cap_Amount
		{
			get
			{
				return this.cap_AmountField;
			}
			set
			{
				this.cap_AmountField = value;
				this.RaisePropertyChanged("Cap_Amount");
			}
		}

		[XmlIgnore]
		public bool Cap_AmountSpecified
		{
			get
			{
				return this.cap_AmountFieldSpecified;
			}
			set
			{
				this.cap_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Cap_AmountSpecified");
			}
		}

		[XmlElement(Order = 10)]
		public decimal Cap_Units
		{
			get
			{
				return this.cap_UnitsField;
			}
			set
			{
				this.cap_UnitsField = value;
				this.RaisePropertyChanged("Cap_Units");
			}
		}

		[XmlIgnore]
		public bool Cap_UnitsSpecified
		{
			get
			{
				return this.cap_UnitsFieldSpecified;
			}
			set
			{
				this.cap_UnitsFieldSpecified = value;
				this.RaisePropertyChanged("Cap_UnitsSpecified");
			}
		}

		[XmlElement("Project_Phase_Reference", Order = 11)]
		public Project_PhaseObjectType[] Project_Phase_Reference
		{
			get
			{
				return this.project_Phase_ReferenceField;
			}
			set
			{
				this.project_Phase_ReferenceField = value;
				this.RaisePropertyChanged("Project_Phase_Reference");
			}
		}

		[XmlElement("Project_Task_Reference", Order = 12)]
		public Project_TaskObjectType[] Project_Task_Reference
		{
			get
			{
				return this.project_Task_ReferenceField;
			}
			set
			{
				this.project_Task_ReferenceField = value;
				this.RaisePropertyChanged("Project_Task_Reference");
			}
		}

		[XmlElement("Project_Role_Reference", Order = 13)]
		public Project_RoleObjectType[] Project_Role_Reference
		{
			get
			{
				return this.project_Role_ReferenceField;
			}
			set
			{
				this.project_Role_ReferenceField = value;
				this.RaisePropertyChanged("Project_Role_Reference");
			}
		}

		[XmlElement("Worker_Reference", Order = 14)]
		public WorkerObjectType[] Worker_Reference
		{
			get
			{
				return this.worker_ReferenceField;
			}
			set
			{
				this.worker_ReferenceField = value;
				this.RaisePropertyChanged("Worker_Reference");
			}
		}

		[XmlElement("Expense_Item_Reference", Order = 15)]
		public Expense_ItemObjectType[] Expense_Item_Reference
		{
			get
			{
				return this.expense_Item_ReferenceField;
			}
			set
			{
				this.expense_Item_ReferenceField = value;
				this.RaisePropertyChanged("Expense_Item_Reference");
			}
		}

		[XmlElement("Spend_Category_Reference", Order = 16)]
		public Spend_CategoryObjectType[] Spend_Category_Reference
		{
			get
			{
				return this.spend_Category_ReferenceField;
			}
			set
			{
				this.spend_Category_ReferenceField = value;
				this.RaisePropertyChanged("Spend_Category_Reference");
			}
		}

		[XmlElement(Order = 17)]
		public string Internal_Name
		{
			get
			{
				return this.internal_NameField;
			}
			set
			{
				this.internal_NameField = value;
				this.RaisePropertyChanged("Internal_Name");
			}
		}

		[XmlElement(Order = 18)]
		public string Notes
		{
			get
			{
				return this.notesField;
			}
			set
			{
				this.notesField = value;
				this.RaisePropertyChanged("Notes");
			}
		}

		[XmlElement("Billing_Rate_Rule_Worktag_Reference", Order = 19)]
		public Accounting_WorktagObjectType[] Billing_Rate_Rule_Worktag_Reference
		{
			get
			{
				return this.billing_Rate_Rule_Worktag_ReferenceField;
			}
			set
			{
				this.billing_Rate_Rule_Worktag_ReferenceField = value;
				this.RaisePropertyChanged("Billing_Rate_Rule_Worktag_Reference");
			}
		}

		[XmlElement("Billing_Rate_Rule_Break_Data", Order = 20)]
		public Billing_Rate_Rule_Break_DataType[] Billing_Rate_Rule_Break_Data
		{
			get
			{
				return this.billing_Rate_Rule_Break_DataField;
			}
			set
			{
				this.billing_Rate_Rule_Break_DataField = value;
				this.RaisePropertyChanged("Billing_Rate_Rule_Break_Data");
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
