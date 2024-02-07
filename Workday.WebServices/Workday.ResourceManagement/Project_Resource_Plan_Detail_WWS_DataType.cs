using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Project_Resource_Plan_Detail_WWS_DataType : INotifyPropertyChanged
	{
		private string project_Resource_Plan_Detail_IDField;

		private Project_RoleObjectType project_Role_ReferenceField;

		private DateTime start_DateField;

		private bool start_DateFieldSpecified;

		private DateTime end_DateField;

		private bool end_DateFieldSpecified;

		private bool isAssociationField;

		private bool isAssociationFieldSpecified;

		private WorkerObjectType[] workers_ReferenceField;

		private decimal add_Additional_Unnamed_ResourcesField;

		private bool add_Additional_Unnamed_ResourcesFieldSpecified;

		private Unnamed_ResourceObjectType[] unnamed_Resource_ReferenceField;

		private bool isToBeHiredField;

		private bool isToBeHiredFieldSpecified;

		private Job_RequisitionObjectType job_Requisition_ReferenceField;

		private decimal percent_AllocationField;

		private bool percent_AllocationFieldSpecified;

		private Project_Booking_StatusObjectType project_Booking_Status_ReferenceField;

		private Project_Member_ResourceObjectType worker_Group_ReferenceField;

		private WorkerObjectType[] excluded_Workers_ReferenceField;

		private decimal standard_Cost_RateField;

		private bool standard_Cost_RateFieldSpecified;

		private CurrencyObjectType standard_Cost_Currency_ReferenceField;

		private decimal contract_Billing_RateField;

		private bool contract_Billing_RateFieldSpecified;

		private CurrencyObjectType contract_Billing_Rate_Currency_ReferenceField;

		private bool deleteField;

		private bool deleteFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Project_Resource_Plan_Detail_ID
		{
			get
			{
				return this.project_Resource_Plan_Detail_IDField;
			}
			set
			{
				this.project_Resource_Plan_Detail_IDField = value;
				this.RaisePropertyChanged("Project_Resource_Plan_Detail_ID");
			}
		}

		[XmlElement(Order = 1)]
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

		[XmlElement(DataType = "date", Order = 2)]
		public DateTime Start_Date
		{
			get
			{
				return this.start_DateField;
			}
			set
			{
				this.start_DateField = value;
				this.RaisePropertyChanged("Start_Date");
			}
		}

		[XmlIgnore]
		public bool Start_DateSpecified
		{
			get
			{
				return this.start_DateFieldSpecified;
			}
			set
			{
				this.start_DateFieldSpecified = value;
				this.RaisePropertyChanged("Start_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 3)]
		public DateTime End_Date
		{
			get
			{
				return this.end_DateField;
			}
			set
			{
				this.end_DateField = value;
				this.RaisePropertyChanged("End_Date");
			}
		}

		[XmlIgnore]
		public bool End_DateSpecified
		{
			get
			{
				return this.end_DateFieldSpecified;
			}
			set
			{
				this.end_DateFieldSpecified = value;
				this.RaisePropertyChanged("End_DateSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public bool isAssociation
		{
			get
			{
				return this.isAssociationField;
			}
			set
			{
				this.isAssociationField = value;
				this.RaisePropertyChanged("isAssociation");
			}
		}

		[XmlIgnore]
		public bool isAssociationSpecified
		{
			get
			{
				return this.isAssociationFieldSpecified;
			}
			set
			{
				this.isAssociationFieldSpecified = value;
				this.RaisePropertyChanged("isAssociationSpecified");
			}
		}

		[XmlElement("Workers_Reference", Order = 5)]
		public WorkerObjectType[] Workers_Reference
		{
			get
			{
				return this.workers_ReferenceField;
			}
			set
			{
				this.workers_ReferenceField = value;
				this.RaisePropertyChanged("Workers_Reference");
			}
		}

		[XmlElement(Order = 6)]
		public decimal Add_Additional_Unnamed_Resources
		{
			get
			{
				return this.add_Additional_Unnamed_ResourcesField;
			}
			set
			{
				this.add_Additional_Unnamed_ResourcesField = value;
				this.RaisePropertyChanged("Add_Additional_Unnamed_Resources");
			}
		}

		[XmlIgnore]
		public bool Add_Additional_Unnamed_ResourcesSpecified
		{
			get
			{
				return this.add_Additional_Unnamed_ResourcesFieldSpecified;
			}
			set
			{
				this.add_Additional_Unnamed_ResourcesFieldSpecified = value;
				this.RaisePropertyChanged("Add_Additional_Unnamed_ResourcesSpecified");
			}
		}

		[XmlElement("Unnamed_Resource_Reference", Order = 7)]
		public Unnamed_ResourceObjectType[] Unnamed_Resource_Reference
		{
			get
			{
				return this.unnamed_Resource_ReferenceField;
			}
			set
			{
				this.unnamed_Resource_ReferenceField = value;
				this.RaisePropertyChanged("Unnamed_Resource_Reference");
			}
		}

		[XmlElement(Order = 8)]
		public bool isToBeHired
		{
			get
			{
				return this.isToBeHiredField;
			}
			set
			{
				this.isToBeHiredField = value;
				this.RaisePropertyChanged("isToBeHired");
			}
		}

		[XmlIgnore]
		public bool isToBeHiredSpecified
		{
			get
			{
				return this.isToBeHiredFieldSpecified;
			}
			set
			{
				this.isToBeHiredFieldSpecified = value;
				this.RaisePropertyChanged("isToBeHiredSpecified");
			}
		}

		[XmlElement(Order = 9)]
		public Job_RequisitionObjectType Job_Requisition_Reference
		{
			get
			{
				return this.job_Requisition_ReferenceField;
			}
			set
			{
				this.job_Requisition_ReferenceField = value;
				this.RaisePropertyChanged("Job_Requisition_Reference");
			}
		}

		[XmlElement(Order = 10)]
		public decimal Percent_Allocation
		{
			get
			{
				return this.percent_AllocationField;
			}
			set
			{
				this.percent_AllocationField = value;
				this.RaisePropertyChanged("Percent_Allocation");
			}
		}

		[XmlIgnore]
		public bool Percent_AllocationSpecified
		{
			get
			{
				return this.percent_AllocationFieldSpecified;
			}
			set
			{
				this.percent_AllocationFieldSpecified = value;
				this.RaisePropertyChanged("Percent_AllocationSpecified");
			}
		}

		[XmlElement(Order = 11)]
		public Project_Booking_StatusObjectType Project_Booking_Status_Reference
		{
			get
			{
				return this.project_Booking_Status_ReferenceField;
			}
			set
			{
				this.project_Booking_Status_ReferenceField = value;
				this.RaisePropertyChanged("Project_Booking_Status_Reference");
			}
		}

		[XmlElement(Order = 12)]
		public Project_Member_ResourceObjectType Worker_Group_Reference
		{
			get
			{
				return this.worker_Group_ReferenceField;
			}
			set
			{
				this.worker_Group_ReferenceField = value;
				this.RaisePropertyChanged("Worker_Group_Reference");
			}
		}

		[XmlElement("Excluded_Workers_Reference", Order = 13)]
		public WorkerObjectType[] Excluded_Workers_Reference
		{
			get
			{
				return this.excluded_Workers_ReferenceField;
			}
			set
			{
				this.excluded_Workers_ReferenceField = value;
				this.RaisePropertyChanged("Excluded_Workers_Reference");
			}
		}

		[XmlElement(Order = 14)]
		public decimal Standard_Cost_Rate
		{
			get
			{
				return this.standard_Cost_RateField;
			}
			set
			{
				this.standard_Cost_RateField = value;
				this.RaisePropertyChanged("Standard_Cost_Rate");
			}
		}

		[XmlIgnore]
		public bool Standard_Cost_RateSpecified
		{
			get
			{
				return this.standard_Cost_RateFieldSpecified;
			}
			set
			{
				this.standard_Cost_RateFieldSpecified = value;
				this.RaisePropertyChanged("Standard_Cost_RateSpecified");
			}
		}

		[XmlElement(Order = 15)]
		public CurrencyObjectType Standard_Cost_Currency_Reference
		{
			get
			{
				return this.standard_Cost_Currency_ReferenceField;
			}
			set
			{
				this.standard_Cost_Currency_ReferenceField = value;
				this.RaisePropertyChanged("Standard_Cost_Currency_Reference");
			}
		}

		[XmlElement(Order = 16)]
		public decimal Contract_Billing_Rate
		{
			get
			{
				return this.contract_Billing_RateField;
			}
			set
			{
				this.contract_Billing_RateField = value;
				this.RaisePropertyChanged("Contract_Billing_Rate");
			}
		}

		[XmlIgnore]
		public bool Contract_Billing_RateSpecified
		{
			get
			{
				return this.contract_Billing_RateFieldSpecified;
			}
			set
			{
				this.contract_Billing_RateFieldSpecified = value;
				this.RaisePropertyChanged("Contract_Billing_RateSpecified");
			}
		}

		[XmlElement(Order = 17)]
		public CurrencyObjectType Contract_Billing_Rate_Currency_Reference
		{
			get
			{
				return this.contract_Billing_Rate_Currency_ReferenceField;
			}
			set
			{
				this.contract_Billing_Rate_Currency_ReferenceField = value;
				this.RaisePropertyChanged("Contract_Billing_Rate_Currency_Reference");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public bool Delete
		{
			get
			{
				return this.deleteField;
			}
			set
			{
				this.deleteField = value;
				this.RaisePropertyChanged("Delete");
			}
		}

		[XmlIgnore]
		public bool DeleteSpecified
		{
			get
			{
				return this.deleteFieldSpecified;
			}
			set
			{
				this.deleteFieldSpecified = value;
				this.RaisePropertyChanged("DeleteSpecified");
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
