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
	public class Student_Course_Section_Data_for_Course_Section_for_Course_Offering_Set_DataType : INotifyPropertyChanged
	{
		private Unique_IdentifierObjectType student_Course_Section_Data_ReferenceField;

		private Instructional_FormatObjectType instructional_Format_ReferenceField;

		private Delivery_ModeObjectType delivery_Mode_ReferenceField;

		private Section_Listing_for_Course_Section_for_Course_Offering_Set_DataType[] section_Listing_for_Course_Section_for_Course_Offering_Set_DataField;

		private Student_Course_Section_Component_for_Course_Section_for_Course_Offering_Set_DataType[] course_Section_Component_for_Course_Section_for_Course_Offering_Set_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Unique_IdentifierObjectType Student_Course_Section_Data_Reference
		{
			get
			{
				return this.student_Course_Section_Data_ReferenceField;
			}
			set
			{
				this.student_Course_Section_Data_ReferenceField = value;
				this.RaisePropertyChanged("Student_Course_Section_Data_Reference");
			}
		}

		[XmlElement(Order = 1)]
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

		[XmlElement(Order = 2)]
		public Delivery_ModeObjectType Delivery_Mode_Reference
		{
			get
			{
				return this.delivery_Mode_ReferenceField;
			}
			set
			{
				this.delivery_Mode_ReferenceField = value;
				this.RaisePropertyChanged("Delivery_Mode_Reference");
			}
		}

		[XmlElement("Section_Listing_for_Course_Section_for_Course_Offering_Set_Data", Order = 3)]
		public Section_Listing_for_Course_Section_for_Course_Offering_Set_DataType[] Section_Listing_for_Course_Section_for_Course_Offering_Set_Data
		{
			get
			{
				return this.section_Listing_for_Course_Section_for_Course_Offering_Set_DataField;
			}
			set
			{
				this.section_Listing_for_Course_Section_for_Course_Offering_Set_DataField = value;
				this.RaisePropertyChanged("Section_Listing_for_Course_Section_for_Course_Offering_Set_Data");
			}
		}

		[XmlElement("Course_Section_Component_for_Course_Section_for_Course_Offering_Set_Data", Order = 4)]
		public Student_Course_Section_Component_for_Course_Section_for_Course_Offering_Set_DataType[] Course_Section_Component_for_Course_Section_for_Course_Offering_Set_Data
		{
			get
			{
				return this.course_Section_Component_for_Course_Section_for_Course_Offering_Set_DataField;
			}
			set
			{
				this.course_Section_Component_for_Course_Section_for_Course_Offering_Set_DataField = value;
				this.RaisePropertyChanged("Course_Section_Component_for_Course_Section_for_Course_Offering_Set_Data");
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
