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
	public class Student_Historical_Payment_Request_ReferencesType : INotifyPropertyChanged
	{
		private Student_Historical_PaymentObjectType[] student_Historical_Payment_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Student_Historical_Payment_Reference", Order = 0)]
		public Student_Historical_PaymentObjectType[] Student_Historical_Payment_Reference
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
