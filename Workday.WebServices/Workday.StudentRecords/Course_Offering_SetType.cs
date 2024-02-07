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
	public class Course_Offering_SetType : INotifyPropertyChanged
	{
		private Course_Offering_SetObjectType course_Offering_Set_ReferenceField;

		private Course_Offering_Set_DataType[] course_Offering_Set_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Course_Offering_SetObjectType Course_Offering_Set_Reference
		{
			get
			{
				return this.course_Offering_Set_ReferenceField;
			}
			set
			{
				this.course_Offering_Set_ReferenceField = value;
				this.RaisePropertyChanged("Course_Offering_Set_Reference");
			}
		}

		[XmlElement("Course_Offering_Set_Data", Order = 1)]
		public Course_Offering_Set_DataType[] Course_Offering_Set_Data
		{
			get
			{
				return this.course_Offering_Set_DataField;
			}
			set
			{
				this.course_Offering_Set_DataField = value;
				this.RaisePropertyChanged("Course_Offering_Set_Data");
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
