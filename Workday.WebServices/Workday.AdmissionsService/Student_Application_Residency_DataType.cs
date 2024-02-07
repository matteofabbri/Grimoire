using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Admissions
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Student_Application_Residency_DataType : INotifyPropertyChanged
	{
		private Student_ApplicationObjectType student_Application_ReferenceField;

		private Student_Residency_StatusObjectType student_Application_Residency_Status_ReferenceField;

		private Resident_DetailObjectType resident_Detail_ReferenceField;

		private DateTime residency_Declaration_DateField;

		private bool residency_Declaration_DateFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Student_ApplicationObjectType Student_Application_Reference
		{
			get
			{
				return this.student_Application_ReferenceField;
			}
			set
			{
				this.student_Application_ReferenceField = value;
				this.RaisePropertyChanged("Student_Application_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Student_Residency_StatusObjectType Student_Application_Residency_Status_Reference
		{
			get
			{
				return this.student_Application_Residency_Status_ReferenceField;
			}
			set
			{
				this.student_Application_Residency_Status_ReferenceField = value;
				this.RaisePropertyChanged("Student_Application_Residency_Status_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public Resident_DetailObjectType Resident_Detail_Reference
		{
			get
			{
				return this.resident_Detail_ReferenceField;
			}
			set
			{
				this.resident_Detail_ReferenceField = value;
				this.RaisePropertyChanged("Resident_Detail_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 3)]
		public DateTime Residency_Declaration_Date
		{
			get
			{
				return this.residency_Declaration_DateField;
			}
			set
			{
				this.residency_Declaration_DateField = value;
				this.RaisePropertyChanged("Residency_Declaration_Date");
			}
		}

		[XmlIgnore]
		public bool Residency_Declaration_DateSpecified
		{
			get
			{
				return this.residency_Declaration_DateFieldSpecified;
			}
			set
			{
				this.residency_Declaration_DateFieldSpecified = value;
				this.RaisePropertyChanged("Residency_Declaration_DateSpecified");
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
