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
	public class Terminate_Event_DataType : INotifyPropertyChanged
	{
		private DateTime last_Day_of_WorkField;

		private bool last_Day_of_WorkFieldSpecified;

		private Event_Classification_SubcategoryObjectType primary_Reason_ReferenceField;

		private Termination_SubcategoryObjectType[] secondary_Reason_ReferenceField;

		private Local_Termination_ReasonObjectType local_Termination_Reason_ReferenceField;

		private DateTime pay_Through_DateField;

		private bool pay_Through_DateFieldSpecified;

		private DateTime resignation_DateField;

		private bool resignation_DateFieldSpecified;

		private DateTime notification_DateField;

		private bool notification_DateFieldSpecified;

		private bool regrettableField;

		private bool regrettableFieldSpecified;

		private bool not_Eligible_for_RehireField;

		private bool not_Eligible_for_RehireFieldSpecified;

		private bool close_PositionField;

		private bool close_PositionFieldSpecified;

		private bool job_Overlap_AllowedField;

		private bool job_Overlap_AllowedFieldSpecified;

		private DateTime last_Date_for_Which_PaidField;

		private bool last_Date_for_Which_PaidFieldSpecified;

		private DateTime expected_Date_of_ReturnField;

		private bool expected_Date_of_ReturnFieldSpecified;

		private bool not_ReturningField;

		private bool not_ReturningFieldSpecified;

		private bool return_UnknownField;

		private bool return_UnknownFieldSpecified;

		private Worker_Document_for_Staffing_Event_DataType[] worker_Document_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(DataType = "date", Order = 0)]
		public DateTime Last_Day_of_Work
		{
			get
			{
				return this.last_Day_of_WorkField;
			}
			set
			{
				this.last_Day_of_WorkField = value;
				this.RaisePropertyChanged("Last_Day_of_Work");
			}
		}

		[XmlIgnore]
		public bool Last_Day_of_WorkSpecified
		{
			get
			{
				return this.last_Day_of_WorkFieldSpecified;
			}
			set
			{
				this.last_Day_of_WorkFieldSpecified = value;
				this.RaisePropertyChanged("Last_Day_of_WorkSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public Event_Classification_SubcategoryObjectType Primary_Reason_Reference
		{
			get
			{
				return this.primary_Reason_ReferenceField;
			}
			set
			{
				this.primary_Reason_ReferenceField = value;
				this.RaisePropertyChanged("Primary_Reason_Reference");
			}
		}

		[XmlElement("Secondary_Reason_Reference", Order = 2)]
		public Termination_SubcategoryObjectType[] Secondary_Reason_Reference
		{
			get
			{
				return this.secondary_Reason_ReferenceField;
			}
			set
			{
				this.secondary_Reason_ReferenceField = value;
				this.RaisePropertyChanged("Secondary_Reason_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public Local_Termination_ReasonObjectType Local_Termination_Reason_Reference
		{
			get
			{
				return this.local_Termination_Reason_ReferenceField;
			}
			set
			{
				this.local_Termination_Reason_ReferenceField = value;
				this.RaisePropertyChanged("Local_Termination_Reason_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 4)]
		public DateTime Pay_Through_Date
		{
			get
			{
				return this.pay_Through_DateField;
			}
			set
			{
				this.pay_Through_DateField = value;
				this.RaisePropertyChanged("Pay_Through_Date");
			}
		}

		[XmlIgnore]
		public bool Pay_Through_DateSpecified
		{
			get
			{
				return this.pay_Through_DateFieldSpecified;
			}
			set
			{
				this.pay_Through_DateFieldSpecified = value;
				this.RaisePropertyChanged("Pay_Through_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 5)]
		public DateTime Resignation_Date
		{
			get
			{
				return this.resignation_DateField;
			}
			set
			{
				this.resignation_DateField = value;
				this.RaisePropertyChanged("Resignation_Date");
			}
		}

		[XmlIgnore]
		public bool Resignation_DateSpecified
		{
			get
			{
				return this.resignation_DateFieldSpecified;
			}
			set
			{
				this.resignation_DateFieldSpecified = value;
				this.RaisePropertyChanged("Resignation_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 6)]
		public DateTime Notification_Date
		{
			get
			{
				return this.notification_DateField;
			}
			set
			{
				this.notification_DateField = value;
				this.RaisePropertyChanged("Notification_Date");
			}
		}

		[XmlIgnore]
		public bool Notification_DateSpecified
		{
			get
			{
				return this.notification_DateFieldSpecified;
			}
			set
			{
				this.notification_DateFieldSpecified = value;
				this.RaisePropertyChanged("Notification_DateSpecified");
			}
		}

		[XmlElement(Order = 7)]
		public bool Regrettable
		{
			get
			{
				return this.regrettableField;
			}
			set
			{
				this.regrettableField = value;
				this.RaisePropertyChanged("Regrettable");
			}
		}

		[XmlIgnore]
		public bool RegrettableSpecified
		{
			get
			{
				return this.regrettableFieldSpecified;
			}
			set
			{
				this.regrettableFieldSpecified = value;
				this.RaisePropertyChanged("RegrettableSpecified");
			}
		}

		[XmlElement(Order = 8)]
		public bool Not_Eligible_for_Rehire
		{
			get
			{
				return this.not_Eligible_for_RehireField;
			}
			set
			{
				this.not_Eligible_for_RehireField = value;
				this.RaisePropertyChanged("Not_Eligible_for_Rehire");
			}
		}

		[XmlIgnore]
		public bool Not_Eligible_for_RehireSpecified
		{
			get
			{
				return this.not_Eligible_for_RehireFieldSpecified;
			}
			set
			{
				this.not_Eligible_for_RehireFieldSpecified = value;
				this.RaisePropertyChanged("Not_Eligible_for_RehireSpecified");
			}
		}

		[XmlElement(Order = 9)]
		public bool Close_Position
		{
			get
			{
				return this.close_PositionField;
			}
			set
			{
				this.close_PositionField = value;
				this.RaisePropertyChanged("Close_Position");
			}
		}

		[XmlIgnore]
		public bool Close_PositionSpecified
		{
			get
			{
				return this.close_PositionFieldSpecified;
			}
			set
			{
				this.close_PositionFieldSpecified = value;
				this.RaisePropertyChanged("Close_PositionSpecified");
			}
		}

		[XmlElement(Order = 10)]
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

		[XmlElement(DataType = "date", Order = 11)]
		public DateTime Last_Date_for_Which_Paid
		{
			get
			{
				return this.last_Date_for_Which_PaidField;
			}
			set
			{
				this.last_Date_for_Which_PaidField = value;
				this.RaisePropertyChanged("Last_Date_for_Which_Paid");
			}
		}

		[XmlIgnore]
		public bool Last_Date_for_Which_PaidSpecified
		{
			get
			{
				return this.last_Date_for_Which_PaidFieldSpecified;
			}
			set
			{
				this.last_Date_for_Which_PaidFieldSpecified = value;
				this.RaisePropertyChanged("Last_Date_for_Which_PaidSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 12)]
		public DateTime Expected_Date_of_Return
		{
			get
			{
				return this.expected_Date_of_ReturnField;
			}
			set
			{
				this.expected_Date_of_ReturnField = value;
				this.RaisePropertyChanged("Expected_Date_of_Return");
			}
		}

		[XmlIgnore]
		public bool Expected_Date_of_ReturnSpecified
		{
			get
			{
				return this.expected_Date_of_ReturnFieldSpecified;
			}
			set
			{
				this.expected_Date_of_ReturnFieldSpecified = value;
				this.RaisePropertyChanged("Expected_Date_of_ReturnSpecified");
			}
		}

		[XmlElement(Order = 13)]
		public bool Not_Returning
		{
			get
			{
				return this.not_ReturningField;
			}
			set
			{
				this.not_ReturningField = value;
				this.RaisePropertyChanged("Not_Returning");
			}
		}

		[XmlIgnore]
		public bool Not_ReturningSpecified
		{
			get
			{
				return this.not_ReturningFieldSpecified;
			}
			set
			{
				this.not_ReturningFieldSpecified = value;
				this.RaisePropertyChanged("Not_ReturningSpecified");
			}
		}

		[XmlElement(Order = 14)]
		public bool Return_Unknown
		{
			get
			{
				return this.return_UnknownField;
			}
			set
			{
				this.return_UnknownField = value;
				this.RaisePropertyChanged("Return_Unknown");
			}
		}

		[XmlIgnore]
		public bool Return_UnknownSpecified
		{
			get
			{
				return this.return_UnknownFieldSpecified;
			}
			set
			{
				this.return_UnknownFieldSpecified = value;
				this.RaisePropertyChanged("Return_UnknownSpecified");
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
