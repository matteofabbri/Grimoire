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
	public class Section_Listing_DataType : INotifyPropertyChanged
	{
		private string idField;

		private Course_ListingObjectType course_Listing_ReferenceField;

		private string section_NumberField;

		private string course_Listing_NumberField;

		private Course_SubjectObjectType course_Listing_Subject_ReferenceField;

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
		public Course_ListingObjectType Course_Listing_Reference
		{
			get
			{
				return this.course_Listing_ReferenceField;
			}
			set
			{
				this.course_Listing_ReferenceField = value;
				this.RaisePropertyChanged("Course_Listing_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public string Section_Number
		{
			get
			{
				return this.section_NumberField;
			}
			set
			{
				this.section_NumberField = value;
				this.RaisePropertyChanged("Section_Number");
			}
		}

		[XmlElement(Order = 3)]
		public string Course_Listing_Number
		{
			get
			{
				return this.course_Listing_NumberField;
			}
			set
			{
				this.course_Listing_NumberField = value;
				this.RaisePropertyChanged("Course_Listing_Number");
			}
		}

		[XmlElement(Order = 4)]
		public Course_SubjectObjectType Course_Listing_Subject_Reference
		{
			get
			{
				return this.course_Listing_Subject_ReferenceField;
			}
			set
			{
				this.course_Listing_Subject_ReferenceField = value;
				this.RaisePropertyChanged("Course_Listing_Subject_Reference");
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
