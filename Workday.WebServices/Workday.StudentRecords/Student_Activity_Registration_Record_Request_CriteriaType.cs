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
	public class Student_Activity_Registration_Record_Request_CriteriaType : INotifyPropertyChanged
	{
		private Student_RecordObjectType student_Record_ReferenceField;

		private Activity_OfferingObjectType activity_Offering_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Student_RecordObjectType Student_Record_Reference
		{
			get
			{
				return this.student_Record_ReferenceField;
			}
			set
			{
				this.student_Record_ReferenceField = value;
				this.RaisePropertyChanged("Student_Record_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Activity_OfferingObjectType Activity_Offering_Reference
		{
			get
			{
				return this.activity_Offering_ReferenceField;
			}
			set
			{
				this.activity_Offering_ReferenceField = value;
				this.RaisePropertyChanged("Activity_Offering_Reference");
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
