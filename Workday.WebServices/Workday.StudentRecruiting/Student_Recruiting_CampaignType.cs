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
	public class Student_Recruiting_CampaignType : INotifyPropertyChanged
	{
		private Student_Recruiting_CampaignObjectType student_Recruiting_Campaign_ReferenceField;

		private Student_Recruiting_Campaign_DataType student_Recruiting_Campaign_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Student_Recruiting_CampaignObjectType Student_Recruiting_Campaign_Reference
		{
			get
			{
				return this.student_Recruiting_Campaign_ReferenceField;
			}
			set
			{
				this.student_Recruiting_Campaign_ReferenceField = value;
				this.RaisePropertyChanged("Student_Recruiting_Campaign_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Student_Recruiting_Campaign_DataType Student_Recruiting_Campaign_Data
		{
			get
			{
				return this.student_Recruiting_Campaign_DataField;
			}
			set
			{
				this.student_Recruiting_Campaign_DataField = value;
				this.RaisePropertyChanged("Student_Recruiting_Campaign_Data");
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
