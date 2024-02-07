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
	public class End_Contingent_Worker_Contract_Event_DataType : INotifyPropertyChanged
	{
		private DateTime last_Day_of_WorkField;

		private bool last_Day_of_WorkFieldSpecified;

		private Event_Classification_SubcategoryObjectType primary_Reason_ReferenceField;

		private Termination_SubcategoryObjectType[] secondary_Reason_ReferenceField;

		private Local_Termination_ReasonObjectType local_Termination_Reason_ReferenceField;

		private DateTime notify_Worker_By_DateField;

		private bool notify_Worker_By_DateFieldSpecified;

		private bool regrettableField;

		private bool regrettableFieldSpecified;

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
		public DateTime Notify_Worker_By_Date
		{
			get
			{
				return this.notify_Worker_By_DateField;
			}
			set
			{
				this.notify_Worker_By_DateField = value;
				this.RaisePropertyChanged("Notify_Worker_By_Date");
			}
		}

		[XmlIgnore]
		public bool Notify_Worker_By_DateSpecified
		{
			get
			{
				return this.notify_Worker_By_DateFieldSpecified;
			}
			set
			{
				this.notify_Worker_By_DateFieldSpecified = value;
				this.RaisePropertyChanged("Notify_Worker_By_DateSpecified");
			}
		}

		[XmlElement(Order = 5)]
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

		[XmlElement(Order = 6)]
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

		[XmlElement(Order = 7)]
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

		[XmlElement("Worker_Document_Data", Order = 8)]
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
