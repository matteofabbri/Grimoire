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
	public class Course_Equivalency_Group_DataType : INotifyPropertyChanged
	{
		private string idField;

		private DateTime start_DateField;

		private DateTime end_DateField;

		private bool end_DateFieldSpecified;

		private decimal maximum_UnitsField;

		private bool maximum_UnitsFieldSpecified;

		private Course_DefinitionObjectType[] student_Course_ReferenceField;

		private Course_Equivalency_UsageObjectType[] equivalency_Usage_ReferenceField;

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

		[XmlElement(DataType = "date", Order = 1)]
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

		[XmlElement(DataType = "date", Order = 2)]
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

		[XmlElement(Order = 3)]
		public decimal Maximum_Units
		{
			get
			{
				return this.maximum_UnitsField;
			}
			set
			{
				this.maximum_UnitsField = value;
				this.RaisePropertyChanged("Maximum_Units");
			}
		}

		[XmlIgnore]
		public bool Maximum_UnitsSpecified
		{
			get
			{
				return this.maximum_UnitsFieldSpecified;
			}
			set
			{
				this.maximum_UnitsFieldSpecified = value;
				this.RaisePropertyChanged("Maximum_UnitsSpecified");
			}
		}

		[XmlElement("Student_Course_Reference", Order = 4)]
		public Course_DefinitionObjectType[] Student_Course_Reference
		{
			get
			{
				return this.student_Course_ReferenceField;
			}
			set
			{
				this.student_Course_ReferenceField = value;
				this.RaisePropertyChanged("Student_Course_Reference");
			}
		}

		[XmlElement("Equivalency_Usage_Reference", Order = 5)]
		public Course_Equivalency_UsageObjectType[] Equivalency_Usage_Reference
		{
			get
			{
				return this.equivalency_Usage_ReferenceField;
			}
			set
			{
				this.equivalency_Usage_ReferenceField = value;
				this.RaisePropertyChanged("Equivalency_Usage_Reference");
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
