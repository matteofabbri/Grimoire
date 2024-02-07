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
	public class Ad_Hoc_Billable_Time_Transaction_DataType : INotifyPropertyChanged
	{
		private ProjectObjectType billable_Project_ReferenceField;

		private Document_StatusObjectType billing_Status_ReferenceField;

		private DateTime transaction_DateField;

		private bool transaction_DateFieldSpecified;

		private WorkerObjectType worker_ReferenceField;

		private Project_Plan_TaskObjectType project_Plan_Task_ReferenceField;

		private Project_RoleObjectType project_Role_ReferenceField;

		private decimal hours_to_BillField;

		private bool hours_to_BillFieldSpecified;

		private decimal rate_to_BillField;

		private bool rate_to_BillFieldSpecified;

		private CurrencyObjectType currency_ReferenceField;

		private Accounting_WorktagObjectType[] worktags_ReferenceField;

		private string memoField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public ProjectObjectType Billable_Project_Reference
		{
			get
			{
				return this.billable_Project_ReferenceField;
			}
			set
			{
				this.billable_Project_ReferenceField = value;
				this.RaisePropertyChanged("Billable_Project_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Document_StatusObjectType Billing_Status_Reference
		{
			get
			{
				return this.billing_Status_ReferenceField;
			}
			set
			{
				this.billing_Status_ReferenceField = value;
				this.RaisePropertyChanged("Billing_Status_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 2)]
		public DateTime Transaction_Date
		{
			get
			{
				return this.transaction_DateField;
			}
			set
			{
				this.transaction_DateField = value;
				this.RaisePropertyChanged("Transaction_Date");
			}
		}

		[XmlIgnore]
		public bool Transaction_DateSpecified
		{
			get
			{
				return this.transaction_DateFieldSpecified;
			}
			set
			{
				this.transaction_DateFieldSpecified = value;
				this.RaisePropertyChanged("Transaction_DateSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public WorkerObjectType Worker_Reference
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

		[XmlElement(Order = 4)]
		public Project_Plan_TaskObjectType Project_Plan_Task_Reference
		{
			get
			{
				return this.project_Plan_Task_ReferenceField;
			}
			set
			{
				this.project_Plan_Task_ReferenceField = value;
				this.RaisePropertyChanged("Project_Plan_Task_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public Project_RoleObjectType Project_Role_Reference
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

		[XmlElement(Order = 6)]
		public decimal Hours_to_Bill
		{
			get
			{
				return this.hours_to_BillField;
			}
			set
			{
				this.hours_to_BillField = value;
				this.RaisePropertyChanged("Hours_to_Bill");
			}
		}

		[XmlIgnore]
		public bool Hours_to_BillSpecified
		{
			get
			{
				return this.hours_to_BillFieldSpecified;
			}
			set
			{
				this.hours_to_BillFieldSpecified = value;
				this.RaisePropertyChanged("Hours_to_BillSpecified");
			}
		}

		[XmlElement(Order = 7)]
		public decimal Rate_to_Bill
		{
			get
			{
				return this.rate_to_BillField;
			}
			set
			{
				this.rate_to_BillField = value;
				this.RaisePropertyChanged("Rate_to_Bill");
			}
		}

		[XmlIgnore]
		public bool Rate_to_BillSpecified
		{
			get
			{
				return this.rate_to_BillFieldSpecified;
			}
			set
			{
				this.rate_to_BillFieldSpecified = value;
				this.RaisePropertyChanged("Rate_to_BillSpecified");
			}
		}

		[XmlElement(Order = 8)]
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

		[XmlElement("Worktags_Reference", Order = 9)]
		public Accounting_WorktagObjectType[] Worktags_Reference
		{
			get
			{
				return this.worktags_ReferenceField;
			}
			set
			{
				this.worktags_ReferenceField = value;
				this.RaisePropertyChanged("Worktags_Reference");
			}
		}

		[XmlElement(Order = 10)]
		public string Memo
		{
			get
			{
				return this.memoField;
			}
			set
			{
				this.memoField = value;
				this.RaisePropertyChanged("Memo");
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
