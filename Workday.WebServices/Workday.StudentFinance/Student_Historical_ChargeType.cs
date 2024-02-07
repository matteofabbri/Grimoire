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
	public class Student_Historical_ChargeType : INotifyPropertyChanged
	{
		private Student_Historical_ChargeObjectType student_Historical_Charge_ReferenceField;

		private Student_Historical_Charge_DataType[] student_Historical_Charge_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Student_Historical_ChargeObjectType Student_Historical_Charge_Reference
		{
			get
			{
				return this.student_Historical_Charge_ReferenceField;
			}
			set
			{
				this.student_Historical_Charge_ReferenceField = value;
				this.RaisePropertyChanged("Student_Historical_Charge_Reference");
			}
		}

		[XmlElement("Student_Historical_Charge_Data", Order = 1)]
		public Student_Historical_Charge_DataType[] Student_Historical_Charge_Data
		{
			get
			{
				return this.student_Historical_Charge_DataField;
			}
			set
			{
				this.student_Historical_Charge_DataField = value;
				this.RaisePropertyChanged("Student_Historical_Charge_Data");
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
