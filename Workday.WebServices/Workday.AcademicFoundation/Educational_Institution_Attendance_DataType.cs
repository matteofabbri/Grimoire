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
	public class Educational_Institution_Attendance_DataType : INotifyPropertyChanged
	{
		private Unique_IdentifierObjectType educational_Institution_Attendance_ReferenceField;

		private Educational_InstitutionObjectType educational_Institution_ReferenceField;

		private DateTime exit_DateField;

		private bool exit_DateFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Unique_IdentifierObjectType Educational_Institution_Attendance_Reference
		{
			get
			{
				return this.educational_Institution_Attendance_ReferenceField;
			}
			set
			{
				this.educational_Institution_Attendance_ReferenceField = value;
				this.RaisePropertyChanged("Educational_Institution_Attendance_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Educational_InstitutionObjectType Educational_Institution_Reference
		{
			get
			{
				return this.educational_Institution_ReferenceField;
			}
			set
			{
				this.educational_Institution_ReferenceField = value;
				this.RaisePropertyChanged("Educational_Institution_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 2)]
		public DateTime Exit_Date
		{
			get
			{
				return this.exit_DateField;
			}
			set
			{
				this.exit_DateField = value;
				this.RaisePropertyChanged("Exit_Date");
			}
		}

		[XmlIgnore]
		public bool Exit_DateSpecified
		{
			get
			{
				return this.exit_DateFieldSpecified;
			}
			set
			{
				this.exit_DateFieldSpecified = value;
				this.RaisePropertyChanged("Exit_DateSpecified");
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
