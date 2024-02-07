using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.FinancialAid
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Import_Student_Manual_Award_DataType : INotifyPropertyChanged
	{
		private string idField;

		private StudentObjectType student_ReferenceField;

		private string first_NameField;

		private string last_NameField;

		private string sSNField;

		private DateTime date_of_BirthField;

		private bool date_of_BirthFieldSpecified;

		private Academic_UnitObjectType academic_Unit_ReferenceField;

		private Student_Award_ItemObjectType student_Award_Item_ReferenceField;

		private string original_Award_NameField;

		private string notesField;

		private bool check_EligibilityField;

		private bool check_EligibilityFieldSpecified;

		private bool check_LimitsField;

		private bool check_LimitsFieldSpecified;

		private bool locked_and_Non_ReducibleField;

		private bool locked_and_Non_ReducibleFieldSpecified;

		private bool locked_and_ReducibleField;

		private bool locked_and_ReducibleFieldSpecified;

		private bool locked_but_ChangeableField;

		private bool locked_but_ChangeableFieldSpecified;

		private Academic_PeriodObjectType academic_Period_ReferenceField;

		private decimal amountField;

		private bool amountFieldSpecified;

		private bool use_Student_Award_CalculationField;

		private bool use_Student_Award_CalculationFieldSpecified;

		private bool inactiveField;

		private bool inactiveFieldSpecified;

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
		public StudentObjectType Student_Reference
		{
			get
			{
				return this.student_ReferenceField;
			}
			set
			{
				this.student_ReferenceField = value;
				this.RaisePropertyChanged("Student_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public string First_Name
		{
			get
			{
				return this.first_NameField;
			}
			set
			{
				this.first_NameField = value;
				this.RaisePropertyChanged("First_Name");
			}
		}

		[XmlElement(Order = 3)]
		public string Last_Name
		{
			get
			{
				return this.last_NameField;
			}
			set
			{
				this.last_NameField = value;
				this.RaisePropertyChanged("Last_Name");
			}
		}

		[XmlElement(Order = 4)]
		public string SSN
		{
			get
			{
				return this.sSNField;
			}
			set
			{
				this.sSNField = value;
				this.RaisePropertyChanged("SSN");
			}
		}

		[XmlElement(DataType = "date", Order = 5)]
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

		[XmlElement(Order = 6)]
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

		[XmlElement(Order = 7)]
		public Student_Award_ItemObjectType Student_Award_Item_Reference
		{
			get
			{
				return this.student_Award_Item_ReferenceField;
			}
			set
			{
				this.student_Award_Item_ReferenceField = value;
				this.RaisePropertyChanged("Student_Award_Item_Reference");
			}
		}

		[XmlElement(Order = 8)]
		public string Original_Award_Name
		{
			get
			{
				return this.original_Award_NameField;
			}
			set
			{
				this.original_Award_NameField = value;
				this.RaisePropertyChanged("Original_Award_Name");
			}
		}

		[XmlElement(Order = 9)]
		public string Notes
		{
			get
			{
				return this.notesField;
			}
			set
			{
				this.notesField = value;
				this.RaisePropertyChanged("Notes");
			}
		}

		[XmlElement(Order = 10)]
		public bool Check_Eligibility
		{
			get
			{
				return this.check_EligibilityField;
			}
			set
			{
				this.check_EligibilityField = value;
				this.RaisePropertyChanged("Check_Eligibility");
			}
		}

		[XmlIgnore]
		public bool Check_EligibilitySpecified
		{
			get
			{
				return this.check_EligibilityFieldSpecified;
			}
			set
			{
				this.check_EligibilityFieldSpecified = value;
				this.RaisePropertyChanged("Check_EligibilitySpecified");
			}
		}

		[XmlElement(Order = 11)]
		public bool Check_Limits
		{
			get
			{
				return this.check_LimitsField;
			}
			set
			{
				this.check_LimitsField = value;
				this.RaisePropertyChanged("Check_Limits");
			}
		}

		[XmlIgnore]
		public bool Check_LimitsSpecified
		{
			get
			{
				return this.check_LimitsFieldSpecified;
			}
			set
			{
				this.check_LimitsFieldSpecified = value;
				this.RaisePropertyChanged("Check_LimitsSpecified");
			}
		}

		[XmlElement(Order = 12)]
		public bool Locked_and_Non_Reducible
		{
			get
			{
				return this.locked_and_Non_ReducibleField;
			}
			set
			{
				this.locked_and_Non_ReducibleField = value;
				this.RaisePropertyChanged("Locked_and_Non_Reducible");
			}
		}

		[XmlIgnore]
		public bool Locked_and_Non_ReducibleSpecified
		{
			get
			{
				return this.locked_and_Non_ReducibleFieldSpecified;
			}
			set
			{
				this.locked_and_Non_ReducibleFieldSpecified = value;
				this.RaisePropertyChanged("Locked_and_Non_ReducibleSpecified");
			}
		}

		[XmlElement(Order = 13)]
		public bool Locked_and_Reducible
		{
			get
			{
				return this.locked_and_ReducibleField;
			}
			set
			{
				this.locked_and_ReducibleField = value;
				this.RaisePropertyChanged("Locked_and_Reducible");
			}
		}

		[XmlIgnore]
		public bool Locked_and_ReducibleSpecified
		{
			get
			{
				return this.locked_and_ReducibleFieldSpecified;
			}
			set
			{
				this.locked_and_ReducibleFieldSpecified = value;
				this.RaisePropertyChanged("Locked_and_ReducibleSpecified");
			}
		}

		[XmlElement(Order = 14)]
		public bool Locked_but_Changeable
		{
			get
			{
				return this.locked_but_ChangeableField;
			}
			set
			{
				this.locked_but_ChangeableField = value;
				this.RaisePropertyChanged("Locked_but_Changeable");
			}
		}

		[XmlIgnore]
		public bool Locked_but_ChangeableSpecified
		{
			get
			{
				return this.locked_but_ChangeableFieldSpecified;
			}
			set
			{
				this.locked_but_ChangeableFieldSpecified = value;
				this.RaisePropertyChanged("Locked_but_ChangeableSpecified");
			}
		}

		[XmlElement(Order = 15)]
		public Academic_PeriodObjectType Academic_Period_Reference
		{
			get
			{
				return this.academic_Period_ReferenceField;
			}
			set
			{
				this.academic_Period_ReferenceField = value;
				this.RaisePropertyChanged("Academic_Period_Reference");
			}
		}

		[XmlElement(Order = 16)]
		public decimal Amount
		{
			get
			{
				return this.amountField;
			}
			set
			{
				this.amountField = value;
				this.RaisePropertyChanged("Amount");
			}
		}

		[XmlIgnore]
		public bool AmountSpecified
		{
			get
			{
				return this.amountFieldSpecified;
			}
			set
			{
				this.amountFieldSpecified = value;
				this.RaisePropertyChanged("AmountSpecified");
			}
		}

		[XmlElement(Order = 17)]
		public bool Use_Student_Award_Calculation
		{
			get
			{
				return this.use_Student_Award_CalculationField;
			}
			set
			{
				this.use_Student_Award_CalculationField = value;
				this.RaisePropertyChanged("Use_Student_Award_Calculation");
			}
		}

		[XmlIgnore]
		public bool Use_Student_Award_CalculationSpecified
		{
			get
			{
				return this.use_Student_Award_CalculationFieldSpecified;
			}
			set
			{
				this.use_Student_Award_CalculationFieldSpecified = value;
				this.RaisePropertyChanged("Use_Student_Award_CalculationSpecified");
			}
		}

		[XmlElement(Order = 18)]
		public bool Inactive
		{
			get
			{
				return this.inactiveField;
			}
			set
			{
				this.inactiveField = value;
				this.RaisePropertyChanged("Inactive");
			}
		}

		[XmlIgnore]
		public bool InactiveSpecified
		{
			get
			{
				return this.inactiveFieldSpecified;
			}
			set
			{
				this.inactiveFieldSpecified = value;
				this.RaisePropertyChanged("InactiveSpecified");
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
