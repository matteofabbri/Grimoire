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
	public class Hire_Employee_Event_DataType : INotifyPropertyChanged
	{
		private string employee_IDField;

		private string position_IDField;

		private Event_Classification_SubcategoryObjectType hire_Reason_ReferenceField;

		private Position_Worker_TypeObjectType employee_Type_ReferenceField;

		private DateTime first_Day_of_WorkField;

		private bool first_Day_of_WorkFieldSpecified;

		private DateTime time_of_HireField;

		private bool time_of_HireFieldSpecified;

		private DateTime continuous_Service_DateField;

		private bool continuous_Service_DateFieldSpecified;

		private DateTime probation_Start_DateField;

		private bool probation_Start_DateFieldSpecified;

		private DateTime probation_End_DateField;

		private bool probation_End_DateFieldSpecified;

		private DateTime employment_End_DateField;

		private bool employment_End_DateFieldSpecified;

		private DateTime benefits_Service_DateField;

		private bool benefits_Service_DateFieldSpecified;

		private DateTime company_Service_DateField;

		private bool company_Service_DateFieldSpecified;

		private DateTime conversion_Position_Start_DateField;

		private bool conversion_Position_Start_DateFieldSpecified;

		private Position_Details_Sub_DataType position_DetailsField;

		private Worker_Document_for_Staffing_Event_DataType[] worker_Document_DataField;

		private External_IDType[] employee_External_ID_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Employee_ID
		{
			get
			{
				return this.employee_IDField;
			}
			set
			{
				this.employee_IDField = value;
				this.RaisePropertyChanged("Employee_ID");
			}
		}

		[XmlElement(Order = 1)]
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

		[XmlElement(Order = 2)]
		public Event_Classification_SubcategoryObjectType Hire_Reason_Reference
		{
			get
			{
				return this.hire_Reason_ReferenceField;
			}
			set
			{
				this.hire_Reason_ReferenceField = value;
				this.RaisePropertyChanged("Hire_Reason_Reference");
			}
		}

		[XmlElement(Order = 3)]
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

		[XmlElement(DataType = "date", Order = 4)]
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

		[XmlElement(DataType = "time", Order = 5)]
		public DateTime Time_of_Hire
		{
			get
			{
				return this.time_of_HireField;
			}
			set
			{
				this.time_of_HireField = value;
				this.RaisePropertyChanged("Time_of_Hire");
			}
		}

		[XmlIgnore]
		public bool Time_of_HireSpecified
		{
			get
			{
				return this.time_of_HireFieldSpecified;
			}
			set
			{
				this.time_of_HireFieldSpecified = value;
				this.RaisePropertyChanged("Time_of_HireSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 6)]
		public DateTime Continuous_Service_Date
		{
			get
			{
				return this.continuous_Service_DateField;
			}
			set
			{
				this.continuous_Service_DateField = value;
				this.RaisePropertyChanged("Continuous_Service_Date");
			}
		}

		[XmlIgnore]
		public bool Continuous_Service_DateSpecified
		{
			get
			{
				return this.continuous_Service_DateFieldSpecified;
			}
			set
			{
				this.continuous_Service_DateFieldSpecified = value;
				this.RaisePropertyChanged("Continuous_Service_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 7)]
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

		[XmlElement(DataType = "date", Order = 8)]
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

		[XmlElement(DataType = "date", Order = 9)]
		public DateTime Employment_End_Date
		{
			get
			{
				return this.employment_End_DateField;
			}
			set
			{
				this.employment_End_DateField = value;
				this.RaisePropertyChanged("Employment_End_Date");
			}
		}

		[XmlIgnore]
		public bool Employment_End_DateSpecified
		{
			get
			{
				return this.employment_End_DateFieldSpecified;
			}
			set
			{
				this.employment_End_DateFieldSpecified = value;
				this.RaisePropertyChanged("Employment_End_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 10)]
		public DateTime Benefits_Service_Date
		{
			get
			{
				return this.benefits_Service_DateField;
			}
			set
			{
				this.benefits_Service_DateField = value;
				this.RaisePropertyChanged("Benefits_Service_Date");
			}
		}

		[XmlIgnore]
		public bool Benefits_Service_DateSpecified
		{
			get
			{
				return this.benefits_Service_DateFieldSpecified;
			}
			set
			{
				this.benefits_Service_DateFieldSpecified = value;
				this.RaisePropertyChanged("Benefits_Service_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 11)]
		public DateTime Company_Service_Date
		{
			get
			{
				return this.company_Service_DateField;
			}
			set
			{
				this.company_Service_DateField = value;
				this.RaisePropertyChanged("Company_Service_Date");
			}
		}

		[XmlIgnore]
		public bool Company_Service_DateSpecified
		{
			get
			{
				return this.company_Service_DateFieldSpecified;
			}
			set
			{
				this.company_Service_DateFieldSpecified = value;
				this.RaisePropertyChanged("Company_Service_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 12)]
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

		[XmlElement(Order = 13)]
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

		[XmlElement("Worker_Document_Data", Order = 14)]
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

		[XmlArray(Order = 15), XmlArrayItem("External_ID", IsNullable = false)]
		public External_IDType[] Employee_External_ID_Data
		{
			get
			{
				return this.employee_External_ID_DataField;
			}
			set
			{
				this.employee_External_ID_DataField = value;
				this.RaisePropertyChanged("Employee_External_ID_Data");
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
