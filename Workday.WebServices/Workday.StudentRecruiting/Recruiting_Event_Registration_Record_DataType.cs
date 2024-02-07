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
	public class Recruiting_Event_Registration_Record_DataType : INotifyPropertyChanged
	{
		private string idField;

		private RegisterableObjectType registerable_ReferenceField;

		private RegistrantObjectType registrant_ReferenceField;

		private bool student_Recruiting_Event_Registration_Record_InvitedField;

		private bool student_Recruiting_Event_Registration_Record_InvitedFieldSpecified;

		private Registration_Record_StatusObjectType registration_Record_Status_ReferenceField;

		private DateTime registered_DateField;

		private bool registered_DateFieldSpecified;

		private decimal number_of_GuestsField;

		private bool number_of_GuestsFieldSpecified;

		private Attendance_StatusObjectType attendance_Status_ReferenceField;

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
		public RegisterableObjectType Registerable_Reference
		{
			get
			{
				return this.registerable_ReferenceField;
			}
			set
			{
				this.registerable_ReferenceField = value;
				this.RaisePropertyChanged("Registerable_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public RegistrantObjectType Registrant_Reference
		{
			get
			{
				return this.registrant_ReferenceField;
			}
			set
			{
				this.registrant_ReferenceField = value;
				this.RaisePropertyChanged("Registrant_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public bool Student_Recruiting_Event_Registration_Record_Invited
		{
			get
			{
				return this.student_Recruiting_Event_Registration_Record_InvitedField;
			}
			set
			{
				this.student_Recruiting_Event_Registration_Record_InvitedField = value;
				this.RaisePropertyChanged("Student_Recruiting_Event_Registration_Record_Invited");
			}
		}

		[XmlIgnore]
		public bool Student_Recruiting_Event_Registration_Record_InvitedSpecified
		{
			get
			{
				return this.student_Recruiting_Event_Registration_Record_InvitedFieldSpecified;
			}
			set
			{
				this.student_Recruiting_Event_Registration_Record_InvitedFieldSpecified = value;
				this.RaisePropertyChanged("Student_Recruiting_Event_Registration_Record_InvitedSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public Registration_Record_StatusObjectType Registration_Record_Status_Reference
		{
			get
			{
				return this.registration_Record_Status_ReferenceField;
			}
			set
			{
				this.registration_Record_Status_ReferenceField = value;
				this.RaisePropertyChanged("Registration_Record_Status_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public DateTime Registered_Date
		{
			get
			{
				return this.registered_DateField;
			}
			set
			{
				this.registered_DateField = value;
				this.RaisePropertyChanged("Registered_Date");
			}
		}

		[XmlIgnore]
		public bool Registered_DateSpecified
		{
			get
			{
				return this.registered_DateFieldSpecified;
			}
			set
			{
				this.registered_DateFieldSpecified = value;
				this.RaisePropertyChanged("Registered_DateSpecified");
			}
		}

		[XmlElement(Order = 6)]
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

		[XmlElement(Order = 7)]
		public Attendance_StatusObjectType Attendance_Status_Reference
		{
			get
			{
				return this.attendance_Status_ReferenceField;
			}
			set
			{
				this.attendance_Status_ReferenceField = value;
				this.RaisePropertyChanged("Attendance_Status_Reference");
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
