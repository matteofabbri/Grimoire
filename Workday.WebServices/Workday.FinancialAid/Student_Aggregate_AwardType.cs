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
	public class Student_Aggregate_AwardType : INotifyPropertyChanged
	{
		private Student_Aggregate_AwardObjectType student_Aggregate_Award_ReferenceField;

		private Student_Aggregate_Award_DataType[] student_Aggregate_Award_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Student_Aggregate_AwardObjectType Student_Aggregate_Award_Reference
		{
			get
			{
				return this.student_Aggregate_Award_ReferenceField;
			}
			set
			{
				this.student_Aggregate_Award_ReferenceField = value;
				this.RaisePropertyChanged("Student_Aggregate_Award_Reference");
			}
		}

		[XmlElement("Student_Aggregate_Award_Data", Order = 1)]
		public Student_Aggregate_Award_DataType[] Student_Aggregate_Award_Data
		{
			get
			{
				return this.student_Aggregate_Award_DataField;
			}
			set
			{
				this.student_Aggregate_Award_DataField = value;
				this.RaisePropertyChanged("Student_Aggregate_Award_Data");
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
