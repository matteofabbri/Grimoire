using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.AcademicFoundation
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Student_Course_Registration_Record_Subedit_DataType : INotifyPropertyChanged
	{
		private Course_SectionObjectType section_Listing_ReferenceField;

		private DateTime registered_DateField;

		private bool registered_DateFieldSpecified;

		private Instructional_FormatObjectType instructional_Format_ReferenceField;

		private Standard_Meeting_PatternObjectType meeting_Pattern_ReferenceField;

		private Registration_Record_StatusObjectType registration_Record_Status_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
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

		[XmlElement(Order = 1)]
		public DateTime Registered_Date
		{
			get
			{
				return this.registered_DateField;
			}
			set
			{
				this.registered_DateField = value;
				this.RaisePropertyChanged("Registered_Date");
			}
		}

		[XmlIgnore]
		public bool Registered_DateSpecified
		{
			get
			{
				return this.registered_DateFieldSpecified;
			}
			set
			{
				this.registered_DateFieldSpecified = value;
				this.RaisePropertyChanged("Registered_DateSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public Instructional_FormatObjectType Instructional_Format_Reference
		{
			get
			{
				return this.instructional_Format_ReferenceField;
			}
			set
			{
				this.instructional_Format_ReferenceField = value;
				this.RaisePropertyChanged("Instructional_Format_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public Standard_Meeting_PatternObjectType Meeting_Pattern_Reference
		{
			get
			{
				return this.meeting_Pattern_ReferenceField;
			}
			set
			{
				this.meeting_Pattern_ReferenceField = value;
				this.RaisePropertyChanged("Meeting_Pattern_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public Registration_Record_StatusObjectType Registration_Record_Status_Reference
		{
			get
			{
				return this.registration_Record_Status_ReferenceField;
			}
			set
			{
				this.registration_Record_Status_ReferenceField = value;
				this.RaisePropertyChanged("Registration_Record_Status_Reference");
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
