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
	public class Leave_Request_Additional_FieldsType : INotifyPropertyChanged
	{
		private DateTime last_Date_for_Which_PaidField;

		private bool last_Date_for_Which_PaidFieldSpecified;

		private DateTime expected_Due_DateField;

		private bool expected_Due_DateFieldSpecified;

		private DateTime child_s_Birth_DateField;

		private bool child_s_Birth_DateFieldSpecified;

		private bool stillbirth_Baby_DeceasedField;

		private bool stillbirth_Baby_DeceasedFieldSpecified;

		private DateTime date_Baby_Arrived_Home_From_HospitalField;

		private bool date_Baby_Arrived_Home_From_HospitalFieldSpecified;

		private DateTime adoption_Placement_DateField;

		private bool adoption_Placement_DateFieldSpecified;

		private DateTime adoption_Notification_DateField;

		private bool adoption_Notification_DateFieldSpecified;

		private DateTime date_Child_Entered_CountryField;

		private bool date_Child_Entered_CountryFieldSpecified;

		private bool multiple_Child_IndicatorField;

		private bool multiple_Child_IndicatorFieldSpecified;

		private decimal number_of_Babies_Adopted_ChildrenField;

		private bool number_of_Babies_Adopted_ChildrenFieldSpecified;

		private decimal number_of_Previous_BirthsField;

		private bool number_of_Previous_BirthsFieldSpecified;

		private decimal number_of_Previous_Maternity_LeavesField;

		private bool number_of_Previous_Maternity_LeavesFieldSpecified;

		private decimal number_of_Child_DependentsField;

		private bool number_of_Child_DependentsFieldSpecified;

		private bool single_Parent_IndicatorField;

		private bool single_Parent_IndicatorFieldSpecified;

		private decimal age_of_DependentField;

		private bool age_of_DependentFieldSpecified;

		private bool work_RelatedField;

		private bool work_RelatedFieldSpecified;

		private DateTime stop_Payment_DateField;

		private bool stop_Payment_DateFieldSpecified;

		private string social_Security_Disability_CodeField;

		private string location_During_LeaveField;

		private bool caesarean_Section_BirthField;

		private bool caesarean_Section_BirthFieldSpecified;

		private decimal leave_PercentageField;

		private bool leave_PercentageFieldSpecified;

		private DateTime week_of_ConfinementField;

		private bool week_of_ConfinementFieldSpecified;

		private decimal leave_Entitlement_OverrideField;

		private bool leave_Entitlement_OverrideFieldSpecified;

		private DateTime date_of_RecallField;

		private bool date_of_RecallFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(DataType = "date", Order = 0)]
		public DateTime Last_Date_for_Which_Paid
		{
			get
			{
				return this.last_Date_for_Which_PaidField;
			}
			set
			{
				this.last_Date_for_Which_PaidField = value;
				this.RaisePropertyChanged("Last_Date_for_Which_Paid");
			}
		}

		[XmlIgnore]
		public bool Last_Date_for_Which_PaidSpecified
		{
			get
			{
				return this.last_Date_for_Which_PaidFieldSpecified;
			}
			set
			{
				this.last_Date_for_Which_PaidFieldSpecified = value;
				this.RaisePropertyChanged("Last_Date_for_Which_PaidSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 1)]
		public DateTime Expected_Due_Date
		{
			get
			{
				return this.expected_Due_DateField;
			}
			set
			{
				this.expected_Due_DateField = value;
				this.RaisePropertyChanged("Expected_Due_Date");
			}
		}

		[XmlIgnore]
		public bool Expected_Due_DateSpecified
		{
			get
			{
				return this.expected_Due_DateFieldSpecified;
			}
			set
			{
				this.expected_Due_DateFieldSpecified = value;
				this.RaisePropertyChanged("Expected_Due_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 2)]
		public DateTime Child_s_Birth_Date
		{
			get
			{
				return this.child_s_Birth_DateField;
			}
			set
			{
				this.child_s_Birth_DateField = value;
				this.RaisePropertyChanged("Child_s_Birth_Date");
			}
		}

		[XmlIgnore]
		public bool Child_s_Birth_DateSpecified
		{
			get
			{
				return this.child_s_Birth_DateFieldSpecified;
			}
			set
			{
				this.child_s_Birth_DateFieldSpecified = value;
				this.RaisePropertyChanged("Child_s_Birth_DateSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public bool Stillbirth_Baby_Deceased
		{
			get
			{
				return this.stillbirth_Baby_DeceasedField;
			}
			set
			{
				this.stillbirth_Baby_DeceasedField = value;
				this.RaisePropertyChanged("Stillbirth_Baby_Deceased");
			}
		}

		[XmlIgnore]
		public bool Stillbirth_Baby_DeceasedSpecified
		{
			get
			{
				return this.stillbirth_Baby_DeceasedFieldSpecified;
			}
			set
			{
				this.stillbirth_Baby_DeceasedFieldSpecified = value;
				this.RaisePropertyChanged("Stillbirth_Baby_DeceasedSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 4)]
		public DateTime Date_Baby_Arrived_Home_From_Hospital
		{
			get
			{
				return this.date_Baby_Arrived_Home_From_HospitalField;
			}
			set
			{
				this.date_Baby_Arrived_Home_From_HospitalField = value;
				this.RaisePropertyChanged("Date_Baby_Arrived_Home_From_Hospital");
			}
		}

		[XmlIgnore]
		public bool Date_Baby_Arrived_Home_From_HospitalSpecified
		{
			get
			{
				return this.date_Baby_Arrived_Home_From_HospitalFieldSpecified;
			}
			set
			{
				this.date_Baby_Arrived_Home_From_HospitalFieldSpecified = value;
				this.RaisePropertyChanged("Date_Baby_Arrived_Home_From_HospitalSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 5)]
		public DateTime Adoption_Placement_Date
		{
			get
			{
				return this.adoption_Placement_DateField;
			}
			set
			{
				this.adoption_Placement_DateField = value;
				this.RaisePropertyChanged("Adoption_Placement_Date");
			}
		}

		[XmlIgnore]
		public bool Adoption_Placement_DateSpecified
		{
			get
			{
				return this.adoption_Placement_DateFieldSpecified;
			}
			set
			{
				this.adoption_Placement_DateFieldSpecified = value;
				this.RaisePropertyChanged("Adoption_Placement_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 6)]
		public DateTime Adoption_Notification_Date
		{
			get
			{
				return this.adoption_Notification_DateField;
			}
			set
			{
				this.adoption_Notification_DateField = value;
				this.RaisePropertyChanged("Adoption_Notification_Date");
			}
		}

		[XmlIgnore]
		public bool Adoption_Notification_DateSpecified
		{
			get
			{
				return this.adoption_Notification_DateFieldSpecified;
			}
			set
			{
				this.adoption_Notification_DateFieldSpecified = value;
				this.RaisePropertyChanged("Adoption_Notification_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 7)]
		public DateTime Date_Child_Entered_Country
		{
			get
			{
				return this.date_Child_Entered_CountryField;
			}
			set
			{
				this.date_Child_Entered_CountryField = value;
				this.RaisePropertyChanged("Date_Child_Entered_Country");
			}
		}

		[XmlIgnore]
		public bool Date_Child_Entered_CountrySpecified
		{
			get
			{
				return this.date_Child_Entered_CountryFieldSpecified;
			}
			set
			{
				this.date_Child_Entered_CountryFieldSpecified = value;
				this.RaisePropertyChanged("Date_Child_Entered_CountrySpecified");
			}
		}

		[XmlElement(Order = 8)]
		public bool Multiple_Child_Indicator
		{
			get
			{
				return this.multiple_Child_IndicatorField;
			}
			set
			{
				this.multiple_Child_IndicatorField = value;
				this.RaisePropertyChanged("Multiple_Child_Indicator");
			}
		}

		[XmlIgnore]
		public bool Multiple_Child_IndicatorSpecified
		{
			get
			{
				return this.multiple_Child_IndicatorFieldSpecified;
			}
			set
			{
				this.multiple_Child_IndicatorFieldSpecified = value;
				this.RaisePropertyChanged("Multiple_Child_IndicatorSpecified");
			}
		}

		[XmlElement(Order = 9)]
		public decimal Number_of_Babies_Adopted_Children
		{
			get
			{
				return this.number_of_Babies_Adopted_ChildrenField;
			}
			set
			{
				this.number_of_Babies_Adopted_ChildrenField = value;
				this.RaisePropertyChanged("Number_of_Babies_Adopted_Children");
			}
		}

		[XmlIgnore]
		public bool Number_of_Babies_Adopted_ChildrenSpecified
		{
			get
			{
				return this.number_of_Babies_Adopted_ChildrenFieldSpecified;
			}
			set
			{
				this.number_of_Babies_Adopted_ChildrenFieldSpecified = value;
				this.RaisePropertyChanged("Number_of_Babies_Adopted_ChildrenSpecified");
			}
		}

		[XmlElement(Order = 10)]
		public decimal Number_of_Previous_Births
		{
			get
			{
				return this.number_of_Previous_BirthsField;
			}
			set
			{
				this.number_of_Previous_BirthsField = value;
				this.RaisePropertyChanged("Number_of_Previous_Births");
			}
		}

		[XmlIgnore]
		public bool Number_of_Previous_BirthsSpecified
		{
			get
			{
				return this.number_of_Previous_BirthsFieldSpecified;
			}
			set
			{
				this.number_of_Previous_BirthsFieldSpecified = value;
				this.RaisePropertyChanged("Number_of_Previous_BirthsSpecified");
			}
		}

		[XmlElement(Order = 11)]
		public decimal Number_of_Previous_Maternity_Leaves
		{
			get
			{
				return this.number_of_Previous_Maternity_LeavesField;
			}
			set
			{
				this.number_of_Previous_Maternity_LeavesField = value;
				this.RaisePropertyChanged("Number_of_Previous_Maternity_Leaves");
			}
		}

		[XmlIgnore]
		public bool Number_of_Previous_Maternity_LeavesSpecified
		{
			get
			{
				return this.number_of_Previous_Maternity_LeavesFieldSpecified;
			}
			set
			{
				this.number_of_Previous_Maternity_LeavesFieldSpecified = value;
				this.RaisePropertyChanged("Number_of_Previous_Maternity_LeavesSpecified");
			}
		}

		[XmlElement(Order = 12)]
		public decimal Number_of_Child_Dependents
		{
			get
			{
				return this.number_of_Child_DependentsField;
			}
			set
			{
				this.number_of_Child_DependentsField = value;
				this.RaisePropertyChanged("Number_of_Child_Dependents");
			}
		}

		[XmlIgnore]
		public bool Number_of_Child_DependentsSpecified
		{
			get
			{
				return this.number_of_Child_DependentsFieldSpecified;
			}
			set
			{
				this.number_of_Child_DependentsFieldSpecified = value;
				this.RaisePropertyChanged("Number_of_Child_DependentsSpecified");
			}
		}

		[XmlElement(Order = 13)]
		public bool Single_Parent_Indicator
		{
			get
			{
				return this.single_Parent_IndicatorField;
			}
			set
			{
				this.single_Parent_IndicatorField = value;
				this.RaisePropertyChanged("Single_Parent_Indicator");
			}
		}

		[XmlIgnore]
		public bool Single_Parent_IndicatorSpecified
		{
			get
			{
				return this.single_Parent_IndicatorFieldSpecified;
			}
			set
			{
				this.single_Parent_IndicatorFieldSpecified = value;
				this.RaisePropertyChanged("Single_Parent_IndicatorSpecified");
			}
		}

		[XmlElement(Order = 14)]
		public decimal Age_of_Dependent
		{
			get
			{
				return this.age_of_DependentField;
			}
			set
			{
				this.age_of_DependentField = value;
				this.RaisePropertyChanged("Age_of_Dependent");
			}
		}

		[XmlIgnore]
		public bool Age_of_DependentSpecified
		{
			get
			{
				return this.age_of_DependentFieldSpecified;
			}
			set
			{
				this.age_of_DependentFieldSpecified = value;
				this.RaisePropertyChanged("Age_of_DependentSpecified");
			}
		}

		[XmlElement(Order = 15)]
		public bool Work_Related
		{
			get
			{
				return this.work_RelatedField;
			}
			set
			{
				this.work_RelatedField = value;
				this.RaisePropertyChanged("Work_Related");
			}
		}

		[XmlIgnore]
		public bool Work_RelatedSpecified
		{
			get
			{
				return this.work_RelatedFieldSpecified;
			}
			set
			{
				this.work_RelatedFieldSpecified = value;
				this.RaisePropertyChanged("Work_RelatedSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 16)]
		public DateTime Stop_Payment_Date
		{
			get
			{
				return this.stop_Payment_DateField;
			}
			set
			{
				this.stop_Payment_DateField = value;
				this.RaisePropertyChanged("Stop_Payment_Date");
			}
		}

		[XmlIgnore]
		public bool Stop_Payment_DateSpecified
		{
			get
			{
				return this.stop_Payment_DateFieldSpecified;
			}
			set
			{
				this.stop_Payment_DateFieldSpecified = value;
				this.RaisePropertyChanged("Stop_Payment_DateSpecified");
			}
		}

		[XmlElement(Order = 17)]
		public string Social_Security_Disability_Code
		{
			get
			{
				return this.social_Security_Disability_CodeField;
			}
			set
			{
				this.social_Security_Disability_CodeField = value;
				this.RaisePropertyChanged("Social_Security_Disability_Code");
			}
		}

		[XmlElement(Order = 18)]
		public string Location_During_Leave
		{
			get
			{
				return this.location_During_LeaveField;
			}
			set
			{
				this.location_During_LeaveField = value;
				this.RaisePropertyChanged("Location_During_Leave");
			}
		}

		[XmlElement(Order = 19)]
		public bool Caesarean_Section_Birth
		{
			get
			{
				return this.caesarean_Section_BirthField;
			}
			set
			{
				this.caesarean_Section_BirthField = value;
				this.RaisePropertyChanged("Caesarean_Section_Birth");
			}
		}

		[XmlIgnore]
		public bool Caesarean_Section_BirthSpecified
		{
			get
			{
				return this.caesarean_Section_BirthFieldSpecified;
			}
			set
			{
				this.caesarean_Section_BirthFieldSpecified = value;
				this.RaisePropertyChanged("Caesarean_Section_BirthSpecified");
			}
		}

		[XmlElement(Order = 20)]
		public decimal Leave_Percentage
		{
			get
			{
				return this.leave_PercentageField;
			}
			set
			{
				this.leave_PercentageField = value;
				this.RaisePropertyChanged("Leave_Percentage");
			}
		}

		[XmlIgnore]
		public bool Leave_PercentageSpecified
		{
			get
			{
				return this.leave_PercentageFieldSpecified;
			}
			set
			{
				this.leave_PercentageFieldSpecified = value;
				this.RaisePropertyChanged("Leave_PercentageSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 21)]
		public DateTime Week_of_Confinement
		{
			get
			{
				return this.week_of_ConfinementField;
			}
			set
			{
				this.week_of_ConfinementField = value;
				this.RaisePropertyChanged("Week_of_Confinement");
			}
		}

		[XmlIgnore]
		public bool Week_of_ConfinementSpecified
		{
			get
			{
				return this.week_of_ConfinementFieldSpecified;
			}
			set
			{
				this.week_of_ConfinementFieldSpecified = value;
				this.RaisePropertyChanged("Week_of_ConfinementSpecified");
			}
		}

		[XmlElement(Order = 22)]
		public decimal Leave_Entitlement_Override
		{
			get
			{
				return this.leave_Entitlement_OverrideField;
			}
			set
			{
				this.leave_Entitlement_OverrideField = value;
				this.RaisePropertyChanged("Leave_Entitlement_Override");
			}
		}

		[XmlIgnore]
		public bool Leave_Entitlement_OverrideSpecified
		{
			get
			{
				return this.leave_Entitlement_OverrideFieldSpecified;
			}
			set
			{
				this.leave_Entitlement_OverrideFieldSpecified = value;
				this.RaisePropertyChanged("Leave_Entitlement_OverrideSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 23)]
		public DateTime Date_of_Recall
		{
			get
			{
				return this.date_of_RecallField;
			}
			set
			{
				this.date_of_RecallField = value;
				this.RaisePropertyChanged("Date_of_Recall");
			}
		}

		[XmlIgnore]
		public bool Date_of_RecallSpecified
		{
			get
			{
				return this.date_of_RecallFieldSpecified;
			}
			set
			{
				this.date_of_RecallFieldSpecified = value;
				this.RaisePropertyChanged("Date_of_RecallSpecified");
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
