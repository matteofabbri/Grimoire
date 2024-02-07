using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.HumanResources
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Instructor_Eligibility_Line_DataType : INotifyPropertyChanged
	{
		private Academic_UnitObjectType academic_Unit_ReferenceField;

		private Academic_LevelObjectType[] academic_Level_ReferenceField;

		private Course_SubjectObjectType[] course_Subject_ReferenceField;

		private Course_DefinitionObjectType[] course_ReferenceField;

		private Delivery_ModeObjectType[] delivery_Mode_ReferenceField;

		private Student_Course_TagObjectType[] course_Tag_ReferenceField;

		private LocationObjectType[] location_ReferenceField;

		private Educational_Taxonomy_CodeObjectType[] educational_Taxonomy_Code_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Academic_UnitObjectType Academic_Unit_Reference
		{
			get
			{
				return this.academic_Unit_ReferenceField;
			}
			set
			{
				this.academic_Unit_ReferenceField = value;
				this.RaisePropertyChanged("Academic_Unit_Reference");
			}
		}

		[XmlElement("Academic_Level_Reference", Order = 1)]
		public Academic_LevelObjectType[] Academic_Level_Reference
		{
			get
			{
				return this.academic_Level_ReferenceField;
			}
			set
			{
				this.academic_Level_ReferenceField = value;
				this.RaisePropertyChanged("Academic_Level_Reference");
			}
		}

		[XmlElement("Course_Subject_Reference", Order = 2)]
		public Course_SubjectObjectType[] Course_Subject_Reference
		{
			get
			{
				return this.course_Subject_ReferenceField;
			}
			set
			{
				this.course_Subject_ReferenceField = value;
				this.RaisePropertyChanged("Course_Subject_Reference");
			}
		}

		[XmlElement("Course_Reference", Order = 3)]
		public Course_DefinitionObjectType[] Course_Reference
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

		[XmlElement("Delivery_Mode_Reference", Order = 4)]
		public Delivery_ModeObjectType[] Delivery_Mode_Reference
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

		[XmlElement("Course_Tag_Reference", Order = 5)]
		public Student_Course_TagObjectType[] Course_Tag_Reference
		{
			get
			{
				return this.course_Tag_ReferenceField;
			}
			set
			{
				this.course_Tag_ReferenceField = value;
				this.RaisePropertyChanged("Course_Tag_Reference");
			}
		}

		[XmlElement("Location_Reference", Order = 6)]
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

		[XmlElement("Educational_Taxonomy_Code_Reference", Order = 7)]
		public Educational_Taxonomy_CodeObjectType[] Educational_Taxonomy_Code_Reference
		{
			get
			{
				return this.educational_Taxonomy_Code_ReferenceField;
			}
			set
			{
				this.educational_Taxonomy_Code_ReferenceField = value;
				this.RaisePropertyChanged("Educational_Taxonomy_Code_Reference");
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
