using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.StudentFinance
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Student_Historical_Payment_Request_CriteriaType : INotifyPropertyChanged
	{
		private Student_Historical_Payment_Data_LoadObjectType student_Historical_Payment_Data_Load_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Student_Historical_Payment_Data_LoadObjectType Student_Historical_Payment_Data_Load_Reference
		{
			get
			{
				return this.student_Historical_Payment_Data_Load_ReferenceField;
			}
			set
			{
				this.student_Historical_Payment_Data_Load_ReferenceField = value;
				this.RaisePropertyChanged("Student_Historical_Payment_Data_Load_Reference");
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
