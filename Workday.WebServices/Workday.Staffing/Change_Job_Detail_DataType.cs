using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Staffing
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Change_Job_Detail_DataType : INotifyPropertyChanged
	{
		private Change_Job_SubcategoryObjectType reason_ReferenceField;

		private Supervisory_OrganizationObjectType supervisory_Organization_ReferenceField;

		private Headcount_OptionsObjectType headcount_Option_ReferenceField;

		private bool job_Overlap_AllowedField;

		private bool job_Overlap_AllowedFieldSpecified;

		private object itemField;

		private object item1Field;

		private Position_Details_Sub_DataType job_Details_DataField;

		private International_Assignment_TypeObjectType international_Assignment_Type_ReferenceField;

		private DateTime expected_Assignment_End_DateField;

		private bool expected_Assignment_End_DateFieldSpecified;

		private DateTime end_Employment_DateField;

		private bool end_Employment_DateFieldSpecified;

		private DateTime contract_End_DateField;

		private bool contract_End_DateFieldSpecified;

		private DateTime first_Day_of_WorkField;

		private bool first_Day_of_WorkFieldSpecified;

		private DateTime notify_Worker_ByField;

		private bool notify_Worker_ByFieldSpecified;

		private string new_Position_IDField;

		private Contract_Details_Sub_DataType contract_Details_DataField;

		private Worker_Document_for_Staffing_Event_DataType[] worker_Document_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Change_Job_SubcategoryObjectType Reason_Reference
		{
			get
			{
				return this.reason_ReferenceField;
			}
			set
			{
				this.reason_ReferenceField = value;
				this.RaisePropertyChanged("Reason_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Supervisory_OrganizationObjectType Supervisory_Organization_Reference
		{
			get
			{
				return this.supervisory_Organization_ReferenceField;
			}
			set
			{
				this.supervisory_Organization_ReferenceField = value;
				this.RaisePropertyChanged("Supervisory_Organization_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public Headcount_OptionsObjectType Headcount_Option_Reference
		{
			get
			{
				return this.headcount_Option_ReferenceField;
			}
			set
			{
				this.headcount_Option_ReferenceField = value;
				this.RaisePropertyChanged("Headcount_Option_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public bool Job_Overlap_Allowed
		{
			get
			{
				return this.job_Overlap_AllowedField;
			}
			set
			{
				this.job_Overlap_AllowedField = value;
				this.RaisePropertyChanged("Job_Overlap_Allowed");
			}
		}

		[XmlIgnore]
		public bool Job_Overlap_AllowedSpecified
		{
			get
			{
				return this.job_Overlap_AllowedFieldSpecified;
			}
			set
			{
				this.job_Overlap_AllowedFieldSpecified = value;
				this.RaisePropertyChanged("Job_Overlap_AllowedSpecified");
			}
		}

		[XmlElement("Create_Position", typeof(bool), Order = 4), XmlElement("Proposed_Job_Requisition_Reference", typeof(Job_RequisitionObjectType), Order = 4), XmlElement("Proposed_Position_Reference", typeof(Position_RestrictionsObjectType), Order = 4)]
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

		[XmlElement("Contingent_Worker_Type_Reference", typeof(Contingent_Worker_TypeObjectType), Order = 5), XmlElement("Employee_Type_Reference", typeof(Employee_TypeObjectType), Order = 5)]
		public object Item1
		{
			get
			{
				return this.item1Field;
			}
			set
			{
				this.item1Field = value;
				this.RaisePropertyChanged("Item1");
			}
		}

		[XmlElement(Order = 6)]
		public Position_Details_Sub_DataType Job_Details_Data
		{
			get
			{
				return this.job_Details_DataField;
			}
			set
			{
				this.job_Details_DataField = value;
				this.RaisePropertyChanged("Job_Details_Data");
			}
		}

		[XmlElement(Order = 7)]
		public International_Assignment_TypeObjectType International_Assignment_Type_Reference
		{
			get
			{
				return this.international_Assignment_Type_ReferenceField;
			}
			set
			{
				this.international_Assignment_Type_ReferenceField = value;
				this.RaisePropertyChanged("International_Assignment_Type_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 8)]
		public DateTime Expected_Assignment_End_Date
		{
			get
			{
				return this.expected_Assignment_End_DateField;
			}
			set
			{
				this.expected_Assignment_End_DateField = value;
				this.RaisePropertyChanged("Expected_Assignment_End_Date");
			}
		}

		[XmlIgnore]
		public bool Expected_Assignment_End_DateSpecified
		{
			get
			{
				return this.expected_Assignment_End_DateFieldSpecified;
			}
			set
			{
				this.expected_Assignment_End_DateFieldSpecified = value;
				this.RaisePropertyChanged("Expected_Assignment_End_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 9)]
		public DateTime End_Employment_Date
		{
			get
			{
				return this.end_Employment_DateField;
			}
			set
			{
				this.end_Employment_DateField = value;
				this.RaisePropertyChanged("End_Employment_Date");
			}
		}

		[XmlIgnore]
		public bool End_Employment_DateSpecified
		{
			get
			{
				return this.end_Employment_DateFieldSpecified;
			}
			set
			{
				this.end_Employment_DateFieldSpecified = value;
				this.RaisePropertyChanged("End_Employment_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 10)]
		public DateTime Contract_End_Date
		{
			get
			{
				return this.contract_End_DateField;
			}
			set
			{
				this.contract_End_DateField = value;
				this.RaisePropertyChanged("Contract_End_Date");
			}
		}

		[XmlIgnore]
		public bool Contract_End_DateSpecified
		{
			get
			{
				return this.contract_End_DateFieldSpecified;
			}
			set
			{
				this.contract_End_DateFieldSpecified = value;
				this.RaisePropertyChanged("Contract_End_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 11)]
		public DateTime First_Day_of_Work
		{
			get
			{
				return this.first_Day_of_WorkField;
			}
			set
			{
				this.first_Day_of_WorkField = value;
				this.RaisePropertyChanged("First_Day_of_Work");
			}
		}

		[XmlIgnore]
		public bool First_Day_of_WorkSpecified
		{
			get
			{
				return this.first_Day_of_WorkFieldSpecified;
			}
			set
			{
				this.first_Day_of_WorkFieldSpecified = value;
				this.RaisePropertyChanged("First_Day_of_WorkSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 12)]
		public DateTime Notify_Worker_By
		{
			get
			{
				return this.notify_Worker_ByField;
			}
			set
			{
				this.notify_Worker_ByField = value;
				this.RaisePropertyChanged("Notify_Worker_By");
			}
		}

		[XmlIgnore]
		public bool Notify_Worker_BySpecified
		{
			get
			{
				return this.notify_Worker_ByFieldSpecified;
			}
			set
			{
				this.notify_Worker_ByFieldSpecified = value;
				this.RaisePropertyChanged("Notify_Worker_BySpecified");
			}
		}

		[XmlElement(Order = 13)]
		public string New_Position_ID
		{
			get
			{
				return this.new_Position_IDField;
			}
			set
			{
				this.new_Position_IDField = value;
				this.RaisePropertyChanged("New_Position_ID");
			}
		}

		[XmlElement(Order = 14)]
		public Contract_Details_Sub_DataType Contract_Details_Data
		{
			get
			{
				return this.contract_Details_DataField;
			}
			set
			{
				this.contract_Details_DataField = value;
				this.RaisePropertyChanged("Contract_Details_Data");
			}
		}

		[XmlElement("Worker_Document_Data", Order = 15)]
		public Worker_Document_for_Staffing_Event_DataType[] Worker_Document_Data
		{
			get
			{
				return this.worker_Document_DataField;
			}
			set
			{
				this.worker_Document_DataField = value;
				this.RaisePropertyChanged("Worker_Document_Data");
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
