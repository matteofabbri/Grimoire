using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.AcademicFoundation
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Student_ProxyType : INotifyPropertyChanged
	{
		private Student_ProxyObjectType student_Proxy_ReferenceField;

		private Student_Proxy_DataType[] student_Proxy_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Student_ProxyObjectType Student_Proxy_Reference
		{
			get
			{
				return this.student_Proxy_ReferenceField;
			}
			set
			{
				this.student_Proxy_ReferenceField = value;
				this.RaisePropertyChanged("Student_Proxy_Reference");
			}
		}

		[XmlElement("Student_Proxy_Data", Order = 1)]
		public Student_Proxy_DataType[] Student_Proxy_Data
		{
			get
			{
				return this.student_Proxy_DataField;
			}
			set
			{
				this.student_Proxy_DataField = value;
				this.RaisePropertyChanged("Student_Proxy_Data");
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
