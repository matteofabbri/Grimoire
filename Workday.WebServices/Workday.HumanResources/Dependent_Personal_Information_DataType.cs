using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.HumanResources
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Dependent_Personal_Information_DataType : INotifyPropertyChanged
	{
		private Person_Name_DataType person_Name_DataField;

		private Contact_Information_DataType contact_Information_DataField;

		private Person_Identification_DataType person_Identification_DataField;

		private DateTime date_of_BirthField;

		private bool date_of_BirthFieldSpecified;

		private DateTime date_of_DeathField;

		private bool date_of_DeathFieldSpecified;

		private GenderObjectType gender_ReferenceField;

		private bool uses_TobaccoField;

		private bool uses_TobaccoFieldSpecified;

		private bool fullTime_StudentField;

		private bool fullTime_StudentFieldSpecified;

		private DateTime student_Status_Start_DateField;

		private bool student_Status_Start_DateFieldSpecified;

		private DateTime student_Status_End_DateField;

		private bool student_Status_End_DateFieldSpecified;

		private bool disabledField;

		private bool disabledFieldSpecified;

		private DateTime inactive_DateField;

		private bool inactive_DateFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Person_Name_DataType Person_Name_Data
		{
			get
			{
				return this.person_Name_DataField;
			}
			set
			{
				this.person_Name_DataField = value;
				this.RaisePropertyChanged("Person_Name_Data");
			}
		}

		[XmlElement(Order = 1)]
		public Contact_Information_DataType Contact_Information_Data
		{
			get
			{
				return this.contact_Information_DataField;
			}
			set
			{
				this.contact_Information_DataField = value;
				this.RaisePropertyChanged("Contact_Information_Data");
			}
		}

		[XmlElement(Order = 2)]
		public Person_Identification_DataType Person_Identification_Data
		{
			get
			{
				return this.person_Identification_DataField;
			}
			set
			{
				this.person_Identification_DataField = value;
				this.RaisePropertyChanged("Person_Identification_Data");
			}
		}

		[XmlElement(DataType = "date", Order = 3)]
		public DateTime Date_of_Birth
		{
			get
			{
				return this.date_of_BirthField;
			}
			set
			{
				this.date_of_BirthField = value;
				this.RaisePropertyChanged("Date_of_Birth");
			}
		}

		[XmlIgnore]
		public bool Date_of_BirthSpecified
		{
			get
			{
				return this.date_of_BirthFieldSpecified;
			}
			set
			{
				this.date_of_BirthFieldSpecified = value;
				this.RaisePropertyChanged("Date_of_BirthSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 4)]
		public DateTime Date_of_Death
		{
			get
			{
				return this.date_of_DeathField;
			}
			set
			{
				this.date_of_DeathField = value;
				this.RaisePropertyChanged("Date_of_Death");
			}
		}

		[XmlIgnore]
		public bool Date_of_DeathSpecified
		{
			get
			{
				return this.date_of_DeathFieldSpecified;
			}
			set
			{
				this.date_of_DeathFieldSpecified = value;
				this.RaisePropertyChanged("Date_of_DeathSpecified");
			}
		}

		[XmlElement(Order = 5)]
		public GenderObjectType Gender_Reference
		{
			get
			{
				return this.gender_ReferenceField;
			}
			set
			{
				this.gender_ReferenceField = value;
				this.RaisePropertyChanged("Gender_Reference");
			}
		}

		[XmlElement(Order = 6)]
		public bool Uses_Tobacco
		{
			get
			{
				return this.uses_TobaccoField;
			}
			set
			{
				this.uses_TobaccoField = value;
				this.RaisePropertyChanged("Uses_Tobacco");
			}
		}

		[XmlIgnore]
		public bool Uses_TobaccoSpecified
		{
			get
			{
				return this.uses_TobaccoFieldSpecified;
			}
			set
			{
				this.uses_TobaccoFieldSpecified = value;
				this.RaisePropertyChanged("Uses_TobaccoSpecified");
			}
		}

		[XmlElement("Full-Time_Student", Order = 7)]
		public bool FullTime_Student
		{
			get
			{
				return this.fullTime_StudentField;
			}
			set
			{
				this.fullTime_StudentField = value;
				this.RaisePropertyChanged("FullTime_Student");
			}
		}

		[XmlIgnore]
		public bool FullTime_StudentSpecified
		{
			get
			{
				return this.fullTime_StudentFieldSpecified;
			}
			set
			{
				this.fullTime_StudentFieldSpecified = value;
				this.RaisePropertyChanged("FullTime_StudentSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 8)]
		public DateTime Student_Status_Start_Date
		{
			get
			{
				return this.student_Status_Start_DateField;
			}
			set
			{
				this.student_Status_Start_DateField = value;
				this.RaisePropertyChanged("Student_Status_Start_Date");
			}
		}

		[XmlIgnore]
		public bool Student_Status_Start_DateSpecified
		{
			get
			{
				return this.student_Status_Start_DateFieldSpecified;
			}
			set
			{
				this.student_Status_Start_DateFieldSpecified = value;
				this.RaisePropertyChanged("Student_Status_Start_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 9)]
		public DateTime Student_Status_End_Date
		{
			get
			{
				return this.student_Status_End_DateField;
			}
			set
			{
				this.student_Status_End_DateField = value;
				this.RaisePropertyChanged("Student_Status_End_Date");
			}
		}

		[XmlIgnore]
		public bool Student_Status_End_DateSpecified
		{
			get
			{
				return this.student_Status_End_DateFieldSpecified;
			}
			set
			{
				this.student_Status_End_DateFieldSpecified = value;
				this.RaisePropertyChanged("Student_Status_End_DateSpecified");
			}
		}

		[XmlElement(Order = 10)]
		public bool Disabled
		{
			get
			{
				return this.disabledField;
			}
			set
			{
				this.disabledField = value;
				this.RaisePropertyChanged("Disabled");
			}
		}

		[XmlIgnore]
		public bool DisabledSpecified
		{
			get
			{
				return this.disabledFieldSpecified;
			}
			set
			{
				this.disabledFieldSpecified = value;
				this.RaisePropertyChanged("DisabledSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 11)]
		public DateTime Inactive_Date
		{
			get
			{
				return this.inactive_DateField;
			}
			set
			{
				this.inactive_DateField = value;
				this.RaisePropertyChanged("Inactive_Date");
			}
		}

		[XmlIgnore]
		public bool Inactive_DateSpecified
		{
			get
			{
				return this.inactive_DateFieldSpecified;
			}
			set
			{
				this.inactive_DateFieldSpecified = value;
				this.RaisePropertyChanged("Inactive_DateSpecified");
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
