using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Payroll.Interface
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Dependent_DataType : INotifyPropertyChanged
	{
		private string dependent_IDField;

		private bool fulltime_StudentField;

		private bool fulltime_StudentFieldSpecified;

		private DateTime student_Status_Start_DateField;

		private bool student_Status_Start_DateFieldSpecified;

		private DateTime student_Status_End_DateField;

		private bool student_Status_End_DateFieldSpecified;

		private bool disabledField;

		private bool disabledFieldSpecified;

		private DateTime inactive_DateField;

		private bool inactive_DateFieldSpecified;

		private bool dependent_for_Payroll_PurposesField;

		private bool dependent_for_Payroll_PurposesFieldSpecified;

		private Citizenship_StatusObjectType[] citizenship_Status_ReferenceField;

		private CountryObjectType country_of_Nationality_ReferenceField;

		private CountryObjectType country_of_Birth_ReferenceField;

		private Country_RegionObjectType region_of_Birth_ReferenceField;

		private string city_of_BirthField;

		private Qualified_Domestic_Relations_Order_Replacement_DataType[] court_OrderField;

		private Lives_With_Worker_DataType[] lives_With_Worker_DataField;

		private Has_Health_Insurance_DataType[] has_Health_Insurance_DataField;

		private Allowed_for_Tax_Deduction_DataType[] allowed_for_Tax_Deduction_DataField;

		private Annual_Income_DataType[] annual_Income_DataField;

		private Occupation_DataType[] occupation_DataField;

		private Disability_Information_Data_for_Related_PersonType[] disability_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Dependent_ID
		{
			get
			{
				return this.dependent_IDField;
			}
			set
			{
				this.dependent_IDField = value;
				this.RaisePropertyChanged("Dependent_ID");
			}
		}

		[XmlElement("Full-time_Student", Order = 1)]
		public bool Fulltime_Student
		{
			get
			{
				return this.fulltime_StudentField;
			}
			set
			{
				this.fulltime_StudentField = value;
				this.RaisePropertyChanged("Fulltime_Student");
			}
		}

		[XmlIgnore]
		public bool Fulltime_StudentSpecified
		{
			get
			{
				return this.fulltime_StudentFieldSpecified;
			}
			set
			{
				this.fulltime_StudentFieldSpecified = value;
				this.RaisePropertyChanged("Fulltime_StudentSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 2)]
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

		[XmlElement(DataType = "date", Order = 3)]
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

		[XmlElement(Order = 4)]
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

		[XmlElement(DataType = "date", Order = 5)]
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

		[XmlElement(Order = 6)]
		public bool Dependent_for_Payroll_Purposes
		{
			get
			{
				return this.dependent_for_Payroll_PurposesField;
			}
			set
			{
				this.dependent_for_Payroll_PurposesField = value;
				this.RaisePropertyChanged("Dependent_for_Payroll_Purposes");
			}
		}

		[XmlIgnore]
		public bool Dependent_for_Payroll_PurposesSpecified
		{
			get
			{
				return this.dependent_for_Payroll_PurposesFieldSpecified;
			}
			set
			{
				this.dependent_for_Payroll_PurposesFieldSpecified = value;
				this.RaisePropertyChanged("Dependent_for_Payroll_PurposesSpecified");
			}
		}

		[XmlElement("Citizenship_Status_Reference", Order = 7)]
		public Citizenship_StatusObjectType[] Citizenship_Status_Reference
		{
			get
			{
				return this.citizenship_Status_ReferenceField;
			}
			set
			{
				this.citizenship_Status_ReferenceField = value;
				this.RaisePropertyChanged("Citizenship_Status_Reference");
			}
		}

		[XmlElement(Order = 8)]
		public CountryObjectType Country_of_Nationality_Reference
		{
			get
			{
				return this.country_of_Nationality_ReferenceField;
			}
			set
			{
				this.country_of_Nationality_ReferenceField = value;
				this.RaisePropertyChanged("Country_of_Nationality_Reference");
			}
		}

		[XmlElement(Order = 9)]
		public CountryObjectType Country_of_Birth_Reference
		{
			get
			{
				return this.country_of_Birth_ReferenceField;
			}
			set
			{
				this.country_of_Birth_ReferenceField = value;
				this.RaisePropertyChanged("Country_of_Birth_Reference");
			}
		}

		[XmlElement(Order = 10)]
		public Country_RegionObjectType Region_of_Birth_Reference
		{
			get
			{
				return this.region_of_Birth_ReferenceField;
			}
			set
			{
				this.region_of_Birth_ReferenceField = value;
				this.RaisePropertyChanged("Region_of_Birth_Reference");
			}
		}

		[XmlElement(Order = 11)]
		public string City_of_Birth
		{
			get
			{
				return this.city_of_BirthField;
			}
			set
			{
				this.city_of_BirthField = value;
				this.RaisePropertyChanged("City_of_Birth");
			}
		}

		[XmlElement("Court_Order", Order = 12)]
		public Qualified_Domestic_Relations_Order_Replacement_DataType[] Court_Order
		{
			get
			{
				return this.court_OrderField;
			}
			set
			{
				this.court_OrderField = value;
				this.RaisePropertyChanged("Court_Order");
			}
		}

		[XmlElement("Lives_With_Worker_Data", Order = 13)]
		public Lives_With_Worker_DataType[] Lives_With_Worker_Data
		{
			get
			{
				return this.lives_With_Worker_DataField;
			}
			set
			{
				this.lives_With_Worker_DataField = value;
				this.RaisePropertyChanged("Lives_With_Worker_Data");
			}
		}

		[XmlElement("Has_Health_Insurance_Data", Order = 14)]
		public Has_Health_Insurance_DataType[] Has_Health_Insurance_Data
		{
			get
			{
				return this.has_Health_Insurance_DataField;
			}
			set
			{
				this.has_Health_Insurance_DataField = value;
				this.RaisePropertyChanged("Has_Health_Insurance_Data");
			}
		}

		[XmlElement("Allowed_for_Tax_Deduction_Data", Order = 15)]
		public Allowed_for_Tax_Deduction_DataType[] Allowed_for_Tax_Deduction_Data
		{
			get
			{
				return this.allowed_for_Tax_Deduction_DataField;
			}
			set
			{
				this.allowed_for_Tax_Deduction_DataField = value;
				this.RaisePropertyChanged("Allowed_for_Tax_Deduction_Data");
			}
		}

		[XmlElement("Annual_Income_Data", Order = 16)]
		public Annual_Income_DataType[] Annual_Income_Data
		{
			get
			{
				return this.annual_Income_DataField;
			}
			set
			{
				this.annual_Income_DataField = value;
				this.RaisePropertyChanged("Annual_Income_Data");
			}
		}

		[XmlElement("Occupation_Data", Order = 17)]
		public Occupation_DataType[] Occupation_Data
		{
			get
			{
				return this.occupation_DataField;
			}
			set
			{
				this.occupation_DataField = value;
				this.RaisePropertyChanged("Occupation_Data");
			}
		}

		[XmlElement("Disability_Data", Order = 18)]
		public Disability_Information_Data_for_Related_PersonType[] Disability_Data
		{
			get
			{
				return this.disability_DataField;
			}
			set
			{
				this.disability_DataField = value;
				this.RaisePropertyChanged("Disability_Data");
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
