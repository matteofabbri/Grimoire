using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.FinancialAid
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Student_Preliminary_Award_Request_ReferencesType : INotifyPropertyChanged
	{
		private Student_Preliminary_AwardObjectType[] student_Preliminary_Award_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Student_Preliminary_Award_Reference", Order = 0)]
		public Student_Preliminary_AwardObjectType[] Student_Preliminary_Award_Reference
		{
			get
			{
				return this.student_Preliminary_Award_ReferenceField;
			}
			set
			{
				this.student_Preliminary_Award_ReferenceField = value;
				this.RaisePropertyChanged("Student_Preliminary_Award_Reference");
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
