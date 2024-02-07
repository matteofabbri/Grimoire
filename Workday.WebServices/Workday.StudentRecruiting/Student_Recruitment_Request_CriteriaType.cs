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
	public class Student_Recruitment_Request_CriteriaType : INotifyPropertyChanged
	{
		private Unique_IdentifierObjectType external_Engagement_Item_Send_Event_ReferenceField;

		private StudentObjectType student_Prospect_ReferenceField;

		private Student_Recruitment_Data_LoadObjectType student_Recruitment_Data_Load_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Unique_IdentifierObjectType External_Engagement_Item_Send_Event_Reference
		{
			get
			{
				return this.external_Engagement_Item_Send_Event_ReferenceField;
			}
			set
			{
				this.external_Engagement_Item_Send_Event_ReferenceField = value;
				this.RaisePropertyChanged("External_Engagement_Item_Send_Event_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public StudentObjectType Student_Prospect_Reference
		{
			get
			{
				return this.student_Prospect_ReferenceField;
			}
			set
			{
				this.student_Prospect_ReferenceField = value;
				this.RaisePropertyChanged("Student_Prospect_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public Student_Recruitment_Data_LoadObjectType Student_Recruitment_Data_Load_Reference
		{
			get
			{
				return this.student_Recruitment_Data_Load_ReferenceField;
			}
			set
			{
				this.student_Recruitment_Data_Load_ReferenceField = value;
				this.RaisePropertyChanged("Student_Recruitment_Data_Load_Reference");
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
