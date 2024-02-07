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
	public class Start_International_Assignment_Event_DataType : INotifyPropertyChanged
	{
		private string position_IDField;

		private International_Assignment_TypeObjectType international_Assignment_Type_ReferenceField;

		private DateTime expected_Assignment_End_DateField;

		private bool expected_Assignment_End_DateFieldSpecified;

		private Event_Classification_SubcategoryObjectType start_International_Assignment_Reason_ReferenceField;

		private Position_Worker_TypeObjectType employee_Type_ReferenceField;

		private DateTime first_Day_of_WorkField;

		private bool first_Day_of_WorkFieldSpecified;

		private DateTime end_Employment_DateField;

		private bool end_Employment_DateFieldSpecified;

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

		[XmlElement(DataType = "date", Order = 2)]
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

		[XmlElement(Order = 3)]
		public Event_Classification_SubcategoryObjectType Start_International_Assignment_Reason_Reference
		{
			get
			{
				return this.start_International_Assignment_Reason_ReferenceField;
			}
			set
			{
				this.start_International_Assignment_Reason_ReferenceField = value;
				this.RaisePropertyChanged("Start_International_Assignment_Reason_Reference");
			}
		}

		[XmlElement(Order = 4)]
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

		[XmlElement(DataType = "date", Order = 5)]
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

		[XmlElement(Order = 7)]
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
