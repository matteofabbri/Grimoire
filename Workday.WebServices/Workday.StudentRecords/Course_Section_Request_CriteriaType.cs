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
	public class Course_Section_Request_CriteriaType : INotifyPropertyChanged
	{
		private Course_DefinitionObjectType course_ReferenceField;

		private Course_SectionObjectType section_Listing_ReferenceField;

		private Activity_Offering_StatusObjectType[] section_Status_ReferenceField;

		private object[] itemsField;

		private DateTime end_DateField;

		private bool end_DateFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Course_DefinitionObjectType Course_Reference
		{
			get
			{
				return this.course_ReferenceField;
			}
			set
			{
				this.course_ReferenceField = value;
				this.RaisePropertyChanged("Course_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Course_SectionObjectType Section_Listing_Reference
		{
			get
			{
				return this.section_Listing_ReferenceField;
			}
			set
			{
				this.section_Listing_ReferenceField = value;
				this.RaisePropertyChanged("Section_Listing_Reference");
			}
		}

		[XmlElement("Section_Status_Reference", Order = 2)]
		public Activity_Offering_StatusObjectType[] Section_Status_Reference
		{
			get
			{
				return this.section_Status_ReferenceField;
			}
			set
			{
				this.section_Status_ReferenceField = value;
				this.RaisePropertyChanged("Section_Status_Reference");
			}
		}

		[XmlElement("Academic_Period_Reference", typeof(Academic_PeriodObjectType), Order = 3), XmlElement("Start_Date", typeof(DateTime), DataType = "date", Order = 3)]
		public object[] Items
		{
			get
			{
				return this.itemsField;
			}
			set
			{
				this.itemsField = value;
				this.RaisePropertyChanged("Items");
			}
		}

		[XmlElement(DataType = "date", Order = 4)]
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
