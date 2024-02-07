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
	public class Academic_Appointment_Snapshot_DataType : INotifyPropertyChanged
	{
		private Academic_Appointment_TrackObjectType academic_Appointment_Track_ReferenceField;

		private string appointment_Track_IDField;

		private Academic_Track_TypeObjectType track_Type_ReferenceField;

		private Academic_Appointment_IdentifierObjectType appointment_Identifier_ReferenceField;

		private Position_ElementObjectType position_ReferenceField;

		private Academic_UnitObjectType academic_Unit_ReferenceField;

		private decimal roster_PercentField;

		private bool roster_PercentFieldSpecified;

		private DateTime appointment_Start_DateField;

		private DateTime appointment_End_DateField;

		private bool appointment_End_DateFieldSpecified;

		private DateTime track_Start_Date_OverrideField;

		private bool track_Start_Date_OverrideFieldSpecified;

		private Academic_RankObjectType rank_ReferenceField;

		private Named_ProfessorshipObjectType named_Professorship_ReferenceField;

		private Appointment_SpecialtyObjectType appointment_Specialty_ReferenceField;

		private string constructed_TitleField;

		private string appointment_TitleField;

		private DateTime adjusted_Title_Start_DateField;

		private bool adjusted_Title_Start_DateFieldSpecified;

		private DateTime academic_Review_DateField;

		private bool academic_Review_DateFieldSpecified;

		private Academic_UnitObjectType related_Academic_Unit_ReferenceField;

		private Academic_UnitObjectType tenure_Home_ReferenceField;

		private Academic_Tenure_StatusObjectType tenure_Status_ReferenceField;

		private DateTime probationary_End_DateField;

		private bool probationary_End_DateFieldSpecified;

		private DateTime tenure_Award_DateField;

		private bool tenure_Award_DateFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Academic_Appointment_TrackObjectType Academic_Appointment_Track_Reference
		{
			get
			{
				return this.academic_Appointment_Track_ReferenceField;
			}
			set
			{
				this.academic_Appointment_Track_ReferenceField = value;
				this.RaisePropertyChanged("Academic_Appointment_Track_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public string Appointment_Track_ID
		{
			get
			{
				return this.appointment_Track_IDField;
			}
			set
			{
				this.appointment_Track_IDField = value;
				this.RaisePropertyChanged("Appointment_Track_ID");
			}
		}

		[XmlElement(Order = 2)]
		public Academic_Track_TypeObjectType Track_Type_Reference
		{
			get
			{
				return this.track_Type_ReferenceField;
			}
			set
			{
				this.track_Type_ReferenceField = value;
				this.RaisePropertyChanged("Track_Type_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public Academic_Appointment_IdentifierObjectType Appointment_Identifier_Reference
		{
			get
			{
				return this.appointment_Identifier_ReferenceField;
			}
			set
			{
				this.appointment_Identifier_ReferenceField = value;
				this.RaisePropertyChanged("Appointment_Identifier_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public Position_ElementObjectType Position_Reference
		{
			get
			{
				return this.position_ReferenceField;
			}
			set
			{
				this.position_ReferenceField = value;
				this.RaisePropertyChanged("Position_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public Academic_UnitObjectType Academic_Unit_Reference
		{
			get
			{
				return this.academic_Unit_ReferenceField;
			}
			set
			{
				this.academic_Unit_ReferenceField = value;
				this.RaisePropertyChanged("Academic_Unit_Reference");
			}
		}

		[XmlElement(Order = 6)]
		public decimal Roster_Percent
		{
			get
			{
				return this.roster_PercentField;
			}
			set
			{
				this.roster_PercentField = value;
				this.RaisePropertyChanged("Roster_Percent");
			}
		}

		[XmlIgnore]
		public bool Roster_PercentSpecified
		{
			get
			{
				return this.roster_PercentFieldSpecified;
			}
			set
			{
				this.roster_PercentFieldSpecified = value;
				this.RaisePropertyChanged("Roster_PercentSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 7)]
		public DateTime Appointment_Start_Date
		{
			get
			{
				return this.appointment_Start_DateField;
			}
			set
			{
				this.appointment_Start_DateField = value;
				this.RaisePropertyChanged("Appointment_Start_Date");
			}
		}

		[XmlElement(DataType = "date", Order = 8)]
		public DateTime Appointment_End_Date
		{
			get
			{
				return this.appointment_End_DateField;
			}
			set
			{
				this.appointment_End_DateField = value;
				this.RaisePropertyChanged("Appointment_End_Date");
			}
		}

		[XmlIgnore]
		public bool Appointment_End_DateSpecified
		{
			get
			{
				return this.appointment_End_DateFieldSpecified;
			}
			set
			{
				this.appointment_End_DateFieldSpecified = value;
				this.RaisePropertyChanged("Appointment_End_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 9)]
		public DateTime Track_Start_Date_Override
		{
			get
			{
				return this.track_Start_Date_OverrideField;
			}
			set
			{
				this.track_Start_Date_OverrideField = value;
				this.RaisePropertyChanged("Track_Start_Date_Override");
			}
		}

		[XmlIgnore]
		public bool Track_Start_Date_OverrideSpecified
		{
			get
			{
				return this.track_Start_Date_OverrideFieldSpecified;
			}
			set
			{
				this.track_Start_Date_OverrideFieldSpecified = value;
				this.RaisePropertyChanged("Track_Start_Date_OverrideSpecified");
			}
		}

		[XmlElement(Order = 10)]
		public Academic_RankObjectType Rank_Reference
		{
			get
			{
				return this.rank_ReferenceField;
			}
			set
			{
				this.rank_ReferenceField = value;
				this.RaisePropertyChanged("Rank_Reference");
			}
		}

		[XmlElement(Order = 11)]
		public Named_ProfessorshipObjectType Named_Professorship_Reference
		{
			get
			{
				return this.named_Professorship_ReferenceField;
			}
			set
			{
				this.named_Professorship_ReferenceField = value;
				this.RaisePropertyChanged("Named_Professorship_Reference");
			}
		}

		[XmlElement(Order = 12)]
		public Appointment_SpecialtyObjectType Appointment_Specialty_Reference
		{
			get
			{
				return this.appointment_Specialty_ReferenceField;
			}
			set
			{
				this.appointment_Specialty_ReferenceField = value;
				this.RaisePropertyChanged("Appointment_Specialty_Reference");
			}
		}

		[XmlElement(Order = 13)]
		public string Constructed_Title
		{
			get
			{
				return this.constructed_TitleField;
			}
			set
			{
				this.constructed_TitleField = value;
				this.RaisePropertyChanged("Constructed_Title");
			}
		}

		[XmlElement(Order = 14)]
		public string Appointment_Title
		{
			get
			{
				return this.appointment_TitleField;
			}
			set
			{
				this.appointment_TitleField = value;
				this.RaisePropertyChanged("Appointment_Title");
			}
		}

		[XmlElement(DataType = "date", Order = 15)]
		public DateTime Adjusted_Title_Start_Date
		{
			get
			{
				return this.adjusted_Title_Start_DateField;
			}
			set
			{
				this.adjusted_Title_Start_DateField = value;
				this.RaisePropertyChanged("Adjusted_Title_Start_Date");
			}
		}

		[XmlIgnore]
		public bool Adjusted_Title_Start_DateSpecified
		{
			get
			{
				return this.adjusted_Title_Start_DateFieldSpecified;
			}
			set
			{
				this.adjusted_Title_Start_DateFieldSpecified = value;
				this.RaisePropertyChanged("Adjusted_Title_Start_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 16)]
		public DateTime Academic_Review_Date
		{
			get
			{
				return this.academic_Review_DateField;
			}
			set
			{
				this.academic_Review_DateField = value;
				this.RaisePropertyChanged("Academic_Review_Date");
			}
		}

		[XmlIgnore]
		public bool Academic_Review_DateSpecified
		{
			get
			{
				return this.academic_Review_DateFieldSpecified;
			}
			set
			{
				this.academic_Review_DateFieldSpecified = value;
				this.RaisePropertyChanged("Academic_Review_DateSpecified");
			}
		}

		[XmlElement(Order = 17)]
		public Academic_UnitObjectType Related_Academic_Unit_Reference
		{
			get
			{
				return this.related_Academic_Unit_ReferenceField;
			}
			set
			{
				this.related_Academic_Unit_ReferenceField = value;
				this.RaisePropertyChanged("Related_Academic_Unit_Reference");
			}
		}

		[XmlElement(Order = 18)]
		public Academic_UnitObjectType Tenure_Home_Reference
		{
			get
			{
				return this.tenure_Home_ReferenceField;
			}
			set
			{
				this.tenure_Home_ReferenceField = value;
				this.RaisePropertyChanged("Tenure_Home_Reference");
			}
		}

		[XmlElement(Order = 19)]
		public Academic_Tenure_StatusObjectType Tenure_Status_Reference
		{
			get
			{
				return this.tenure_Status_ReferenceField;
			}
			set
			{
				this.tenure_Status_ReferenceField = value;
				this.RaisePropertyChanged("Tenure_Status_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 20)]
		public DateTime Probationary_End_Date
		{
			get
			{
				return this.probationary_End_DateField;
			}
			set
			{
				this.probationary_End_DateField = value;
				this.RaisePropertyChanged("Probationary_End_Date");
			}
		}

		[XmlIgnore]
		public bool Probationary_End_DateSpecified
		{
			get
			{
				return this.probationary_End_DateFieldSpecified;
			}
			set
			{
				this.probationary_End_DateFieldSpecified = value;
				this.RaisePropertyChanged("Probationary_End_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 21)]
		public DateTime Tenure_Award_Date
		{
			get
			{
				return this.tenure_Award_DateField;
			}
			set
			{
				this.tenure_Award_DateField = value;
				this.RaisePropertyChanged("Tenure_Award_Date");
			}
		}

		[XmlIgnore]
		public bool Tenure_Award_DateSpecified
		{
			get
			{
				return this.tenure_Award_DateFieldSpecified;
			}
			set
			{
				this.tenure_Award_DateFieldSpecified = value;
				this.RaisePropertyChanged("Tenure_Award_DateSpecified");
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
