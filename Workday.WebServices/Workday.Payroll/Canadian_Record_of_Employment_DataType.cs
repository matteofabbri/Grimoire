using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Payroll
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Canadian_Record_of_Employment_DataType : INotifyPropertyChanged
	{
		private string printing_LanguageField;

		private string issue_TypeField;

		private Unique_IdentifierObjectType rOE_Data_ReferenceField;

		private string rOE_Serial_NumberField;

		private string employee_IDField;

		private string employer_Payroll_Reference_NumberField;

		private string organization_NumberField;

		private string folder_CDField;

		private string pay_Period_TypeField;

		private string social_Insurance_NumberField;

		private string rOE_Address_Line_1Field;

		private string rOE_Address_Line_2Field;

		private string rOE_Address_Line_3Field;

		private string postal_CodeField;

		private string legal_First_NameField;

		private string legal_Last_NameField;

		private string legal_Middle_NameField;

		private DateTime first_Day_WorkedField;

		private DateTime last_Day_For_Which_PaidField;

		private DateTime final_Pay_Period_End_DateField;

		private string employee_OccupationField;

		private string rOE_Expected_Recall_CodeField;

		private DateTime expected_Date_of_ReturnField;

		private bool expected_Date_of_ReturnFieldSpecified;

		private decimal total_Insurable_HoursField;

		private decimal total_Insurable_EarningsField;

		private Canadian_Record_of_Employment_Insurable_Earnings_By_Period_DataType[] rOE_Insurable_Earnings_By_Period_DataField;

		private string rOE_Reason_Contact_Area_Code_NumberField;

		private string rOE_Reason_Code_for_ROE_ReasonField;

		private string rOE_Reason_Phone_Extension_NumberField;

		private string rOE_Reason_Contact_First_NameField;

		private string rOE_Reason_Contact_Last_NameField;

		private string rOE_Reason_Contact_Phone_NumberField;

		private decimal vacation_Pay_AmountField;

		private bool vacation_Pay_AmountFieldSpecified;

		private ROE_Vacation_Pay_DataType[] vacation_Pay_DataField;

		private Canadian_Record_of_Employment_Statutory_Holiday_Detail_DataType[] statutory_Holiday_DataField;

		private Other_Monies_DataType[] other_Monies_DataField;

		private string commentsField;

		private Canadian_Record_of_Employment_Paid_Sick_Leave__Maternity_and_Wage_Loss_Detail_DataType[] special_Payment_DataField;

		private string preferred_User_LanguageField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Printing_Language
		{
			get
			{
				return this.printing_LanguageField;
			}
			set
			{
				this.printing_LanguageField = value;
				this.RaisePropertyChanged("Printing_Language");
			}
		}

		[XmlElement(Order = 1)]
		public string Issue_Type
		{
			get
			{
				return this.issue_TypeField;
			}
			set
			{
				this.issue_TypeField = value;
				this.RaisePropertyChanged("Issue_Type");
			}
		}

		[XmlElement(Order = 2)]
		public Unique_IdentifierObjectType ROE_Data_Reference
		{
			get
			{
				return this.rOE_Data_ReferenceField;
			}
			set
			{
				this.rOE_Data_ReferenceField = value;
				this.RaisePropertyChanged("ROE_Data_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public string ROE_Serial_Number
		{
			get
			{
				return this.rOE_Serial_NumberField;
			}
			set
			{
				this.rOE_Serial_NumberField = value;
				this.RaisePropertyChanged("ROE_Serial_Number");
			}
		}

		[XmlElement(Order = 4)]
		public string Employee_ID
		{
			get
			{
				return this.employee_IDField;
			}
			set
			{
				this.employee_IDField = value;
				this.RaisePropertyChanged("Employee_ID");
			}
		}

		[XmlElement(Order = 5)]
		public string Employer_Payroll_Reference_Number
		{
			get
			{
				return this.employer_Payroll_Reference_NumberField;
			}
			set
			{
				this.employer_Payroll_Reference_NumberField = value;
				this.RaisePropertyChanged("Employer_Payroll_Reference_Number");
			}
		}

		[XmlElement(Order = 6)]
		public string Organization_Number
		{
			get
			{
				return this.organization_NumberField;
			}
			set
			{
				this.organization_NumberField = value;
				this.RaisePropertyChanged("Organization_Number");
			}
		}

		[XmlElement(Order = 7)]
		public string Folder_CD
		{
			get
			{
				return this.folder_CDField;
			}
			set
			{
				this.folder_CDField = value;
				this.RaisePropertyChanged("Folder_CD");
			}
		}

		[XmlElement(Order = 8)]
		public string Pay_Period_Type
		{
			get
			{
				return this.pay_Period_TypeField;
			}
			set
			{
				this.pay_Period_TypeField = value;
				this.RaisePropertyChanged("Pay_Period_Type");
			}
		}

		[XmlElement(Order = 9)]
		public string Social_Insurance_Number
		{
			get
			{
				return this.social_Insurance_NumberField;
			}
			set
			{
				this.social_Insurance_NumberField = value;
				this.RaisePropertyChanged("Social_Insurance_Number");
			}
		}

		[XmlElement(Order = 10)]
		public string ROE_Address_Line_1
		{
			get
			{
				return this.rOE_Address_Line_1Field;
			}
			set
			{
				this.rOE_Address_Line_1Field = value;
				this.RaisePropertyChanged("ROE_Address_Line_1");
			}
		}

		[XmlElement(Order = 11)]
		public string ROE_Address_Line_2
		{
			get
			{
				return this.rOE_Address_Line_2Field;
			}
			set
			{
				this.rOE_Address_Line_2Field = value;
				this.RaisePropertyChanged("ROE_Address_Line_2");
			}
		}

		[XmlElement(Order = 12)]
		public string ROE_Address_Line_3
		{
			get
			{
				return this.rOE_Address_Line_3Field;
			}
			set
			{
				this.rOE_Address_Line_3Field = value;
				this.RaisePropertyChanged("ROE_Address_Line_3");
			}
		}

		[XmlElement(Order = 13)]
		public string Postal_Code
		{
			get
			{
				return this.postal_CodeField;
			}
			set
			{
				this.postal_CodeField = value;
				this.RaisePropertyChanged("Postal_Code");
			}
		}

		[XmlElement(Order = 14)]
		public string Legal_First_Name
		{
			get
			{
				return this.legal_First_NameField;
			}
			set
			{
				this.legal_First_NameField = value;
				this.RaisePropertyChanged("Legal_First_Name");
			}
		}

		[XmlElement(Order = 15)]
		public string Legal_Last_Name
		{
			get
			{
				return this.legal_Last_NameField;
			}
			set
			{
				this.legal_Last_NameField = value;
				this.RaisePropertyChanged("Legal_Last_Name");
			}
		}

		[XmlElement(Order = 16)]
		public string Legal_Middle_Name
		{
			get
			{
				return this.legal_Middle_NameField;
			}
			set
			{
				this.legal_Middle_NameField = value;
				this.RaisePropertyChanged("Legal_Middle_Name");
			}
		}

		[XmlElement(DataType = "date", Order = 17)]
		public DateTime First_Day_Worked
		{
			get
			{
				return this.first_Day_WorkedField;
			}
			set
			{
				this.first_Day_WorkedField = value;
				this.RaisePropertyChanged("First_Day_Worked");
			}
		}

		[XmlElement(DataType = "date", Order = 18)]
		public DateTime Last_Day_For_Which_Paid
		{
			get
			{
				return this.last_Day_For_Which_PaidField;
			}
			set
			{
				this.last_Day_For_Which_PaidField = value;
				this.RaisePropertyChanged("Last_Day_For_Which_Paid");
			}
		}

		[XmlElement(DataType = "date", Order = 19)]
		public DateTime Final_Pay_Period_End_Date
		{
			get
			{
				return this.final_Pay_Period_End_DateField;
			}
			set
			{
				this.final_Pay_Period_End_DateField = value;
				this.RaisePropertyChanged("Final_Pay_Period_End_Date");
			}
		}

		[XmlElement(Order = 20)]
		public string Employee_Occupation
		{
			get
			{
				return this.employee_OccupationField;
			}
			set
			{
				this.employee_OccupationField = value;
				this.RaisePropertyChanged("Employee_Occupation");
			}
		}

		[XmlElement(Order = 21)]
		public string ROE_Expected_Recall_Code
		{
			get
			{
				return this.rOE_Expected_Recall_CodeField;
			}
			set
			{
				this.rOE_Expected_Recall_CodeField = value;
				this.RaisePropertyChanged("ROE_Expected_Recall_Code");
			}
		}

		[XmlElement(DataType = "date", Order = 22)]
		public DateTime Expected_Date_of_Return
		{
			get
			{
				return this.expected_Date_of_ReturnField;
			}
			set
			{
				this.expected_Date_of_ReturnField = value;
				this.RaisePropertyChanged("Expected_Date_of_Return");
			}
		}

		[XmlIgnore]
		public bool Expected_Date_of_ReturnSpecified
		{
			get
			{
				return this.expected_Date_of_ReturnFieldSpecified;
			}
			set
			{
				this.expected_Date_of_ReturnFieldSpecified = value;
				this.RaisePropertyChanged("Expected_Date_of_ReturnSpecified");
			}
		}

		[XmlElement(Order = 23)]
		public decimal Total_Insurable_Hours
		{
			get
			{
				return this.total_Insurable_HoursField;
			}
			set
			{
				this.total_Insurable_HoursField = value;
				this.RaisePropertyChanged("Total_Insurable_Hours");
			}
		}

		[XmlElement(Order = 24)]
		public decimal Total_Insurable_Earnings
		{
			get
			{
				return this.total_Insurable_EarningsField;
			}
			set
			{
				this.total_Insurable_EarningsField = value;
				this.RaisePropertyChanged("Total_Insurable_Earnings");
			}
		}

		[XmlElement("ROE_Insurable_Earnings_By_Period_Data", Order = 25)]
		public Canadian_Record_of_Employment_Insurable_Earnings_By_Period_DataType[] ROE_Insurable_Earnings_By_Period_Data
		{
			get
			{
				return this.rOE_Insurable_Earnings_By_Period_DataField;
			}
			set
			{
				this.rOE_Insurable_Earnings_By_Period_DataField = value;
				this.RaisePropertyChanged("ROE_Insurable_Earnings_By_Period_Data");
			}
		}

		[XmlElement(Order = 26)]
		public string ROE_Reason_Contact_Area_Code_Number
		{
			get
			{
				return this.rOE_Reason_Contact_Area_Code_NumberField;
			}
			set
			{
				this.rOE_Reason_Contact_Area_Code_NumberField = value;
				this.RaisePropertyChanged("ROE_Reason_Contact_Area_Code_Number");
			}
		}

		[XmlElement(Order = 27)]
		public string ROE_Reason_Code_for_ROE_Reason
		{
			get
			{
				return this.rOE_Reason_Code_for_ROE_ReasonField;
			}
			set
			{
				this.rOE_Reason_Code_for_ROE_ReasonField = value;
				this.RaisePropertyChanged("ROE_Reason_Code_for_ROE_Reason");
			}
		}

		[XmlElement(Order = 28)]
		public string ROE_Reason_Phone_Extension_Number
		{
			get
			{
				return this.rOE_Reason_Phone_Extension_NumberField;
			}
			set
			{
				this.rOE_Reason_Phone_Extension_NumberField = value;
				this.RaisePropertyChanged("ROE_Reason_Phone_Extension_Number");
			}
		}

		[XmlElement(Order = 29)]
		public string ROE_Reason_Contact_First_Name
		{
			get
			{
				return this.rOE_Reason_Contact_First_NameField;
			}
			set
			{
				this.rOE_Reason_Contact_First_NameField = value;
				this.RaisePropertyChanged("ROE_Reason_Contact_First_Name");
			}
		}

		[XmlElement(Order = 30)]
		public string ROE_Reason_Contact_Last_Name
		{
			get
			{
				return this.rOE_Reason_Contact_Last_NameField;
			}
			set
			{
				this.rOE_Reason_Contact_Last_NameField = value;
				this.RaisePropertyChanged("ROE_Reason_Contact_Last_Name");
			}
		}

		[XmlElement(Order = 31)]
		public string ROE_Reason_Contact_Phone_Number
		{
			get
			{
				return this.rOE_Reason_Contact_Phone_NumberField;
			}
			set
			{
				this.rOE_Reason_Contact_Phone_NumberField = value;
				this.RaisePropertyChanged("ROE_Reason_Contact_Phone_Number");
			}
		}

		[XmlElement(Order = 32)]
		public decimal Vacation_Pay_Amount
		{
			get
			{
				return this.vacation_Pay_AmountField;
			}
			set
			{
				this.vacation_Pay_AmountField = value;
				this.RaisePropertyChanged("Vacation_Pay_Amount");
			}
		}

		[XmlIgnore]
		public bool Vacation_Pay_AmountSpecified
		{
			get
			{
				return this.vacation_Pay_AmountFieldSpecified;
			}
			set
			{
				this.vacation_Pay_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Vacation_Pay_AmountSpecified");
			}
		}

		[XmlElement("Vacation_Pay_Data", Order = 33)]
		public ROE_Vacation_Pay_DataType[] Vacation_Pay_Data
		{
			get
			{
				return this.vacation_Pay_DataField;
			}
			set
			{
				this.vacation_Pay_DataField = value;
				this.RaisePropertyChanged("Vacation_Pay_Data");
			}
		}

		[XmlElement("Statutory_Holiday_Data", Order = 34)]
		public Canadian_Record_of_Employment_Statutory_Holiday_Detail_DataType[] Statutory_Holiday_Data
		{
			get
			{
				return this.statutory_Holiday_DataField;
			}
			set
			{
				this.statutory_Holiday_DataField = value;
				this.RaisePropertyChanged("Statutory_Holiday_Data");
			}
		}

		[XmlElement("Other_Monies_Data", Order = 35)]
		public Other_Monies_DataType[] Other_Monies_Data
		{
			get
			{
				return this.other_Monies_DataField;
			}
			set
			{
				this.other_Monies_DataField = value;
				this.RaisePropertyChanged("Other_Monies_Data");
			}
		}

		[XmlElement(Order = 36)]
		public string Comments
		{
			get
			{
				return this.commentsField;
			}
			set
			{
				this.commentsField = value;
				this.RaisePropertyChanged("Comments");
			}
		}

		[XmlElement("Special_Payment_Data", Order = 37)]
		public Canadian_Record_of_Employment_Paid_Sick_Leave__Maternity_and_Wage_Loss_Detail_DataType[] Special_Payment_Data
		{
			get
			{
				return this.special_Payment_DataField;
			}
			set
			{
				this.special_Payment_DataField = value;
				this.RaisePropertyChanged("Special_Payment_Data");
			}
		}

		[XmlElement(Order = 38)]
		public string Preferred_User_Language
		{
			get
			{
				return this.preferred_User_LanguageField;
			}
			set
			{
				this.preferred_User_LanguageField = value;
				this.RaisePropertyChanged("Preferred_User_Language");
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
