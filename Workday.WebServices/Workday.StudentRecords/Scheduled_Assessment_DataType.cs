using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.StudentRecords
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Scheduled_Assessment_DataType : INotifyPropertyChanged
	{
		private string idField;

		private Course_Section_DefinitionObjectType course_Section_ReferenceField;

		private Course_Assessment_TypeObjectType course_Assessment_Type_ReferenceField;

		private Delivery_ModeObjectType course_Delivery_Mode_ReferenceField;

		private DateTime dateField;

		private DateTime start_TimeField;

		private DateTime end_TimeField;

		private LocationObjectType[] location_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string ID
		{
			get
			{
				return this.idField;
			}
			set
			{
				this.idField = value;
				this.RaisePropertyChanged("ID");
			}
		}

		[XmlElement(Order = 1)]
		public Course_Section_DefinitionObjectType Course_Section_Reference
		{
			get
			{
				return this.course_Section_ReferenceField;
			}
			set
			{
				this.course_Section_ReferenceField = value;
				this.RaisePropertyChanged("Course_Section_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public Course_Assessment_TypeObjectType Course_Assessment_Type_Reference
		{
			get
			{
				return this.course_Assessment_Type_ReferenceField;
			}
			set
			{
				this.course_Assessment_Type_ReferenceField = value;
				this.RaisePropertyChanged("Course_Assessment_Type_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public Delivery_ModeObjectType Course_Delivery_Mode_Reference
		{
			get
			{
				return this.course_Delivery_Mode_ReferenceField;
			}
			set
			{
				this.course_Delivery_Mode_ReferenceField = value;
				this.RaisePropertyChanged("Course_Delivery_Mode_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 4)]
		public DateTime Date
		{
			get
			{
				return this.dateField;
			}
			set
			{
				this.dateField = value;
				this.RaisePropertyChanged("Date");
			}
		}

		[XmlElement(DataType = "time", Order = 5)]
		public DateTime Start_Time
		{
			get
			{
				return this.start_TimeField;
			}
			set
			{
				this.start_TimeField = value;
				this.RaisePropertyChanged("Start_Time");
			}
		}

		[XmlElement(DataType = "time", Order = 6)]
		public DateTime End_Time
		{
			get
			{
				return this.end_TimeField;
			}
			set
			{
				this.end_TimeField = value;
				this.RaisePropertyChanged("End_Time");
			}
		}

		[XmlElement("Location_Reference", Order = 7)]
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
