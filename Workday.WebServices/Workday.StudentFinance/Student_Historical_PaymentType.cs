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
	public class Student_Historical_PaymentType : INotifyPropertyChanged
	{
		private Student_Historical_PaymentObjectType student_Historical_Payment_ReferenceField;

		private Student_Historical_Payment_DataType[] student_Historical_Payment_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Student_Historical_PaymentObjectType Student_Historical_Payment_Reference
		{
			get
			{
				return this.student_Historical_Payment_ReferenceField;
			}
			set
			{
				this.student_Historical_Payment_ReferenceField = value;
				this.RaisePropertyChanged("Student_Historical_Payment_Reference");
			}
		}

		[XmlElement("Student_Historical_Payment_Data", Order = 1)]
		public Student_Historical_Payment_DataType[] Student_Historical_Payment_Data
		{
			get
			{
				return this.student_Historical_Payment_DataField;
			}
			set
			{
				this.student_Historical_Payment_DataField = value;
				this.RaisePropertyChanged("Student_Historical_Payment_Data");
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
