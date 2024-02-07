using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.StudentRecruiting
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Prospect_Assignment_Criteria_DataType : INotifyPropertyChanged
	{
		private Engagement_CriteriaObjectType engagement_Criteria_ReferenceField;

		private Academic_Curricular_DivisionObjectType academic_Unit_ReferenceField;

		private Academic_LevelObjectType[] academic_Level_ReferenceField;

		private RegionObjectType[] region_ReferenceField;

		private Student_TagObjectType[] student_Tag_ReferenceField;

		private Student_Prospect_TypeObjectType[] student_Prospect_Type_ReferenceField;

		private Educational_InterestObjectType[] educational_Interest_ReferenceField;

		private LocationObjectType[] location_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Engagement_CriteriaObjectType Engagement_Criteria_Reference
		{
			get
			{
				return this.engagement_Criteria_ReferenceField;
			}
			set
			{
				this.engagement_Criteria_ReferenceField = value;
				this.RaisePropertyChanged("Engagement_Criteria_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Academic_Curricular_DivisionObjectType Academic_Unit_Reference
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

		[XmlElement("Academic_Level_Reference", Order = 2)]
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

		[XmlElement("Region_Reference", Order = 3)]
		public RegionObjectType[] Region_Reference
		{
			get
			{
				return this.region_ReferenceField;
			}
			set
			{
				this.region_ReferenceField = value;
				this.RaisePropertyChanged("Region_Reference");
			}
		}

		[XmlElement("Student_Tag_Reference", Order = 4)]
		public Student_TagObjectType[] Student_Tag_Reference
		{
			get
			{
				return this.student_Tag_ReferenceField;
			}
			set
			{
				this.student_Tag_ReferenceField = value;
				this.RaisePropertyChanged("Student_Tag_Reference");
			}
		}

		[XmlElement("Student_Prospect_Type_Reference", Order = 5)]
		public Student_Prospect_TypeObjectType[] Student_Prospect_Type_Reference
		{
			get
			{
				return this.student_Prospect_Type_ReferenceField;
			}
			set
			{
				this.student_Prospect_Type_ReferenceField = value;
				this.RaisePropertyChanged("Student_Prospect_Type_Reference");
			}
		}

		[XmlElement("Educational_Interest_Reference", Order = 6)]
		public Educational_InterestObjectType[] Educational_Interest_Reference
		{
			get
			{
				return this.educational_Interest_ReferenceField;
			}
			set
			{
				this.educational_Interest_ReferenceField = value;
				this.RaisePropertyChanged("Educational_Interest_Reference");
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
