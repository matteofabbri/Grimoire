using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.StudentRecruiting
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Student_Recruiting_Event_Registration_Record_DataType : INotifyPropertyChanged
	{
		private string idField;

		private StudentObjectType student_Prospect_Person_ReferenceField;

		private Student_Recruiting_EventObjectType student_Recruiting_Event_ReferenceField;

		private decimal number_of_GuestsField;

		private bool number_of_GuestsFieldSpecified;

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
		public StudentObjectType Student_Prospect_Person_Reference
		{
			get
			{
				return this.student_Prospect_Person_ReferenceField;
			}
			set
			{
				this.student_Prospect_Person_ReferenceField = value;
				this.RaisePropertyChanged("Student_Prospect_Person_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public Student_Recruiting_EventObjectType Student_Recruiting_Event_Reference
		{
			get
			{
				return this.student_Recruiting_Event_ReferenceField;
			}
			set
			{
				this.student_Recruiting_Event_ReferenceField = value;
				this.RaisePropertyChanged("Student_Recruiting_Event_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public decimal Number_of_Guests
		{
			get
			{
				return this.number_of_GuestsField;
			}
			set
			{
				this.number_of_GuestsField = value;
				this.RaisePropertyChanged("Number_of_Guests");
			}
		}

		[XmlIgnore]
		public bool Number_of_GuestsSpecified
		{
			get
			{
				return this.number_of_GuestsFieldSpecified;
			}
			set
			{
				this.number_of_GuestsFieldSpecified = value;
				this.RaisePropertyChanged("Number_of_GuestsSpecified");
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
