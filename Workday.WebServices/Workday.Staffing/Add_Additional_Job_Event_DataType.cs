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
	public class Add_Additional_Job_Event_DataType : INotifyPropertyChanged
	{
		private string position_IDField;

		private Event_Classification_SubcategoryObjectType additional_Job_Reason_ReferenceField;

		private Position_Worker_TypeObjectType employee_Type_ReferenceField;

		private DateTime first_Day_of_WorkField;

		private bool first_Day_of_WorkFieldSpecified;

		private DateTime probation_Start_DateField;

		private bool probation_Start_DateFieldSpecified;

		private DateTime probation_End_DateField;

		private bool probation_End_DateFieldSpecified;

		private DateTime end_Employment_DateField;

		private bool end_Employment_DateFieldSpecified;

		private DateTime conversion_Position_Start_DateField;

		private bool conversion_Position_Start_DateFieldSpecified;

		private Position_Details_Sub_DataType position_DetailsField;

		private Worker_Document_for_Staffing_Event_DataType[] worker_Document_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Position_ID
		{
			get
			{
				return this.position_IDField;
			}
			set
			{
				this.position_IDField = value;
				this.RaisePropertyChanged("Position_ID");
			}
		}

		[XmlElement(Order = 1)]
		public Event_Classification_SubcategoryObjectType Additional_Job_Reason_Reference
		{
			get
			{
				return this.additional_Job_Reason_ReferenceField;
			}
			set
			{
				this.additional_Job_Reason_ReferenceField = value;
				this.RaisePropertyChanged("Additional_Job_Reason_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public Position_Worker_TypeObjectType Employee_Type_Reference
		{
			get
			{
				return this.employee_Type_ReferenceField;
			}
			set
			{
				this.employee_Type_ReferenceField = value;
				this.RaisePropertyChanged("Employee_Type_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 3)]
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

		[XmlElement(DataType = "date", Order = 4)]
		public DateTime Probation_Start_Date
		{
			get
			{
				return this.probation_Start_DateField;
			}
			set
			{
				this.probation_Start_DateField = value;
				this.RaisePropertyChanged("Probation_Start_Date");
			}
		}

		[XmlIgnore]
		public bool Probation_Start_DateSpecified
		{
			get
			{
				return this.probation_Start_DateFieldSpecified;
			}
			set
			{
				this.probation_Start_DateFieldSpecified = value;
				this.RaisePropertyChanged("Probation_Start_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 5)]
		public DateTime Probation_End_Date
		{
			get
			{
				return this.probation_End_DateField;
			}
			set
			{
				this.probation_End_DateField = value;
				this.RaisePropertyChanged("Probation_End_Date");
			}
		}

		[XmlIgnore]
		public bool Probation_End_DateSpecified
		{
			get
			{
				return this.probation_End_DateFieldSpecified;
			}
			set
			{
				this.probation_End_DateFieldSpecified = value;
				this.RaisePropertyChanged("Probation_End_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 6)]
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

		[XmlElement(DataType = "date", Order = 7)]
		public DateTime Conversion_Position_Start_Date
		{
			get
			{
				return this.conversion_Position_Start_DateField;
			}
			set
			{
				this.conversion_Position_Start_DateField = value;
				this.RaisePropertyChanged("Conversion_Position_Start_Date");
			}
		}

		[XmlIgnore]
		public bool Conversion_Position_Start_DateSpecified
		{
			get
			{
				return this.conversion_Position_Start_DateFieldSpecified;
			}
			set
			{
				this.conversion_Position_Start_DateFieldSpecified = value;
				this.RaisePropertyChanged("Conversion_Position_Start_DateSpecified");
			}
		}

		[XmlElement(Order = 8)]
		public Position_Details_Sub_DataType Position_Details
		{
			get
			{
				return this.position_DetailsField;
			}
			set
			{
				this.position_DetailsField = value;
				this.RaisePropertyChanged("Position_Details");
			}
		}

		[XmlElement("Worker_Document_Data", Order = 9)]
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
