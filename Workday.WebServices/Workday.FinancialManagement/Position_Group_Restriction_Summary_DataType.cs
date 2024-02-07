using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Position_Group_Restriction_Summary_DataType : INotifyPropertyChanged
	{
		private DateTime availability_DateField;

		private bool availability_DateFieldSpecified;

		private DateTime earliest_Hire_DateField;

		private bool earliest_Hire_DateFieldSpecified;

		private Job_Family_BaseObjectType[] job_Family_ReferenceField;

		private Job_Profile_Summary_DataType[] job_Profile_Restriction_Summary_DataField;

		private LocationObjectType[] location_ReferenceField;

		private Worker_TypeObjectType worker_Type_ReferenceField;

		private Position_Time_TypeObjectType time_Type_ReferenceField;

		private Position_Worker_TypeObjectType[] position_Worker_Type_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(DataType = "date", Order = 0)]
		public DateTime Availability_Date
		{
			get
			{
				return this.availability_DateField;
			}
			set
			{
				this.availability_DateField = value;
				this.RaisePropertyChanged("Availability_Date");
			}
		}

		[XmlIgnore]
		public bool Availability_DateSpecified
		{
			get
			{
				return this.availability_DateFieldSpecified;
			}
			set
			{
				this.availability_DateFieldSpecified = value;
				this.RaisePropertyChanged("Availability_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 1)]
		public DateTime Earliest_Hire_Date
		{
			get
			{
				return this.earliest_Hire_DateField;
			}
			set
			{
				this.earliest_Hire_DateField = value;
				this.RaisePropertyChanged("Earliest_Hire_Date");
			}
		}

		[XmlIgnore]
		public bool Earliest_Hire_DateSpecified
		{
			get
			{
				return this.earliest_Hire_DateFieldSpecified;
			}
			set
			{
				this.earliest_Hire_DateFieldSpecified = value;
				this.RaisePropertyChanged("Earliest_Hire_DateSpecified");
			}
		}

		[XmlElement("Job_Family_Reference", Order = 2)]
		public Job_Family_BaseObjectType[] Job_Family_Reference
		{
			get
			{
				return this.job_Family_ReferenceField;
			}
			set
			{
				this.job_Family_ReferenceField = value;
				this.RaisePropertyChanged("Job_Family_Reference");
			}
		}

		[XmlElement("Job_Profile_Restriction_Summary_Data", Order = 3)]
		public Job_Profile_Summary_DataType[] Job_Profile_Restriction_Summary_Data
		{
			get
			{
				return this.job_Profile_Restriction_Summary_DataField;
			}
			set
			{
				this.job_Profile_Restriction_Summary_DataField = value;
				this.RaisePropertyChanged("Job_Profile_Restriction_Summary_Data");
			}
		}

		[XmlElement("Location_Reference", Order = 4)]
		public LocationObjectType[] Location_Reference
		{
			get
			{
				return this.location_ReferenceField;
			}
			set
			{
				this.location_ReferenceField = value;
				this.RaisePropertyChanged("Location_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public Worker_TypeObjectType Worker_Type_Reference
		{
			get
			{
				return this.worker_Type_ReferenceField;
			}
			set
			{
				this.worker_Type_ReferenceField = value;
				this.RaisePropertyChanged("Worker_Type_Reference");
			}
		}

		[XmlElement(Order = 6)]
		public Position_Time_TypeObjectType Time_Type_Reference
		{
			get
			{
				return this.time_Type_ReferenceField;
			}
			set
			{
				this.time_Type_ReferenceField = value;
				this.RaisePropertyChanged("Time_Type_Reference");
			}
		}

		[XmlElement("Position_Worker_Type_Reference", Order = 7)]
		public Position_Worker_TypeObjectType[] Position_Worker_Type_Reference
		{
			get
			{
				return this.position_Worker_Type_ReferenceField;
			}
			set
			{
				this.position_Worker_Type_ReferenceField = value;
				this.RaisePropertyChanged("Position_Worker_Type_Reference");
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
