using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Staffing
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Student_Employment_Eligibility_Event_DataType : INotifyPropertyChanged
	{
		private bool eligibleField;

		private bool eligibleFieldSpecified;

		private Student_Employment_Eligibility_Reason_DataType[] student_Employment_Eligibility_Reason_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public bool Eligible
		{
			get
			{
				return this.eligibleField;
			}
			set
			{
				this.eligibleField = value;
				this.RaisePropertyChanged("Eligible");
			}
		}

		[XmlIgnore]
		public bool EligibleSpecified
		{
			get
			{
				return this.eligibleFieldSpecified;
			}
			set
			{
				this.eligibleFieldSpecified = value;
				this.RaisePropertyChanged("EligibleSpecified");
			}
		}

		[XmlElement("Student_Employment_Eligibility_Reason_Data", Order = 1)]
		public Student_Employment_Eligibility_Reason_DataType[] Student_Employment_Eligibility_Reason_Data
		{
			get
			{
				return this.student_Employment_Eligibility_Reason_DataField;
			}
			set
			{
				this.student_Employment_Eligibility_Reason_DataField = value;
				this.RaisePropertyChanged("Student_Employment_Eligibility_Reason_Data");
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
