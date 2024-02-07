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
	public class Student_Preliminary_Award_Request_CriteriaType : INotifyPropertyChanged
	{
		private StudentObjectType[] student_ReferenceField;

		private Academic_Period_AbstractObjectType[] academic_Period_ReferenceField;

		private Student_Award_ItemObjectType[] student_Award_Item_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Student_Reference", Order = 0)]
		public StudentObjectType[] Student_Reference
		{
			get
			{
				return this.student_ReferenceField;
			}
			set
			{
				this.student_ReferenceField = value;
				this.RaisePropertyChanged("Student_Reference");
			}
		}

		[XmlElement("Academic_Period_Reference", Order = 1)]
		public Academic_Period_AbstractObjectType[] Academic_Period_Reference
		{
			get
			{
				return this.academic_Period_ReferenceField;
			}
			set
			{
				this.academic_Period_ReferenceField = value;
				this.RaisePropertyChanged("Academic_Period_Reference");
			}
		}

		[XmlElement("Student_Award_Item_Reference", Order = 2)]
		public Student_Award_ItemObjectType[] Student_Award_Item_Reference
		{
			get
			{
				return this.student_Award_Item_ReferenceField;
			}
			set
			{
				this.student_Award_Item_ReferenceField = value;
				this.RaisePropertyChanged("Student_Award_Item_Reference");
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
