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
	public class End_Additional_Job_Event_DataType : INotifyPropertyChanged
	{
		private DateTime last_Day_of_WorkField;

		private Event_Classification_SubcategoryObjectType reason_ReferenceField;

		private DateTime pay_Through_DateField;

		private bool pay_Through_DateFieldSpecified;

		private DateTime notify_Employee_By_DateField;

		private bool notify_Employee_By_DateFieldSpecified;

		private bool close_PositionField;

		private bool close_PositionFieldSpecified;

		private bool job_Overlap_AllowedField;

		private bool job_Overlap_AllowedFieldSpecified;

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

		[XmlElement(Order = 1)]
		public Event_Classification_SubcategoryObjectType Reason_Reference
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

		[XmlElement(DataType = "date", Order = 2)]
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

		[XmlElement(DataType = "date", Order = 3)]
		public DateTime Notify_Employee_By_Date
		{
			get
			{
				return this.notify_Employee_By_DateField;
			}
			set
			{
				this.notify_Employee_By_DateField = value;
				this.RaisePropertyChanged("Notify_Employee_By_Date");
			}
		}

		[XmlIgnore]
		public bool Notify_Employee_By_DateSpecified
		{
			get
			{
				return this.notify_Employee_By_DateFieldSpecified;
			}
			set
			{
				this.notify_Employee_By_DateFieldSpecified = value;
				this.RaisePropertyChanged("Notify_Employee_By_DateSpecified");
			}
		}

		[XmlElement(Order = 4)]
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

		[XmlElement(Order = 5)]
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

		[XmlElement("Worker_Document_Data", Order = 6)]
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
