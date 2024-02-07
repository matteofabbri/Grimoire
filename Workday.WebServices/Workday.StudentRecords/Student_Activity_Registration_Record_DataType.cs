using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.StudentRecords
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Student_Activity_Registration_Record_DataType : INotifyPropertyChanged
	{
		private string idField;

		private Activity_OfferingObjectType activity_Offering_ReferenceField;

		private Student_RecordObjectType student_Record_ReferenceField;

		private decimal unitsField;

		private bool unitsFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string ID
		{
			get
			{
				return this.idField;
			}
			set
			{
				this.idField = value;
				this.RaisePropertyChanged("ID");
			}
		}

		[XmlElement(Order = 1)]
		public Activity_OfferingObjectType Activity_Offering_Reference
		{
			get
			{
				return this.activity_Offering_ReferenceField;
			}
			set
			{
				this.activity_Offering_ReferenceField = value;
				this.RaisePropertyChanged("Activity_Offering_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public Student_RecordObjectType Student_Record_Reference
		{
			get
			{
				return this.student_Record_ReferenceField;
			}
			set
			{
				this.student_Record_ReferenceField = value;
				this.RaisePropertyChanged("Student_Record_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public decimal Units
		{
			get
			{
				return this.unitsField;
			}
			set
			{
				this.unitsField = value;
				this.RaisePropertyChanged("Units");
			}
		}

		[XmlIgnore]
		public bool UnitsSpecified
		{
			get
			{
				return this.unitsFieldSpecified;
			}
			set
			{
				this.unitsFieldSpecified = value;
				this.RaisePropertyChanged("UnitsSpecified");
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
