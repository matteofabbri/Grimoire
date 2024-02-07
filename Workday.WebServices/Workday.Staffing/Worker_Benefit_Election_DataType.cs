using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.Staffing
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Worker_Benefit_Election_DataType : INotifyPropertyChanged
	{
		private DateTime coverage_Begin_DateField;

		private bool coverage_Begin_DateFieldSpecified;

		private DateTime coverage_End_DateField;

		private bool coverage_End_DateFieldSpecified;

		private DateTime election_Coverage_Begin_DateField;

		private bool election_Coverage_Begin_DateFieldSpecified;

		private DateTime original_Coverage_Begin_DateField;

		private bool original_Coverage_Begin_DateFieldSpecified;

		private DateTime original_Coverage_Begin_Date_for_Benefit_Coverage_TypeField;

		private bool original_Coverage_Begin_Date_for_Benefit_Coverage_TypeFieldSpecified;

		private DateTime deduction_Begin_DateField;

		private bool deduction_Begin_DateFieldSpecified;

		private DateTime deduction_End_DateField;

		private bool deduction_End_DateFieldSpecified;

		private string election_StatusField;

		private DateTime enrollment_Signature_DateField;

		private bool enrollment_Signature_DateFieldSpecified;

		private bool passive_EnrollmentField;

		private bool passive_EnrollmentFieldSpecified;

		private Benefit_Plan_Summary_DataType benefit_Plan_Summary_DataField;

		private DateTime original_Plan_Enrollment_DateField;

		private bool original_Plan_Enrollment_DateFieldSpecified;

		private DateTime original_Benefit_Provider_Enrollment_DateField;

		private bool original_Benefit_Provider_Enrollment_DateFieldSpecified;

		private bool is_Corrected_or_RescindedField;

		private bool is_Corrected_or_RescindedFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(DataType = "date", Order = 0)]
		public DateTime Coverage_Begin_Date
		{
			get
			{
				return this.coverage_Begin_DateField;
			}
			set
			{
				this.coverage_Begin_DateField = value;
				this.RaisePropertyChanged("Coverage_Begin_Date");
			}
		}

		[XmlIgnore]
		public bool Coverage_Begin_DateSpecified
		{
			get
			{
				return this.coverage_Begin_DateFieldSpecified;
			}
			set
			{
				this.coverage_Begin_DateFieldSpecified = value;
				this.RaisePropertyChanged("Coverage_Begin_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 1)]
		public DateTime Coverage_End_Date
		{
			get
			{
				return this.coverage_End_DateField;
			}
			set
			{
				this.coverage_End_DateField = value;
				this.RaisePropertyChanged("Coverage_End_Date");
			}
		}

		[XmlIgnore]
		public bool Coverage_End_DateSpecified
		{
			get
			{
				return this.coverage_End_DateFieldSpecified;
			}
			set
			{
				this.coverage_End_DateFieldSpecified = value;
				this.RaisePropertyChanged("Coverage_End_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 2)]
		public DateTime Election_Coverage_Begin_Date
		{
			get
			{
				return this.election_Coverage_Begin_DateField;
			}
			set
			{
				this.election_Coverage_Begin_DateField = value;
				this.RaisePropertyChanged("Election_Coverage_Begin_Date");
			}
		}

		[XmlIgnore]
		public bool Election_Coverage_Begin_DateSpecified
		{
			get
			{
				return this.election_Coverage_Begin_DateFieldSpecified;
			}
			set
			{
				this.election_Coverage_Begin_DateFieldSpecified = value;
				this.RaisePropertyChanged("Election_Coverage_Begin_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 3)]
		public DateTime Original_Coverage_Begin_Date
		{
			get
			{
				return this.original_Coverage_Begin_DateField;
			}
			set
			{
				this.original_Coverage_Begin_DateField = value;
				this.RaisePropertyChanged("Original_Coverage_Begin_Date");
			}
		}

		[XmlIgnore]
		public bool Original_Coverage_Begin_DateSpecified
		{
			get
			{
				return this.original_Coverage_Begin_DateFieldSpecified;
			}
			set
			{
				this.original_Coverage_Begin_DateFieldSpecified = value;
				this.RaisePropertyChanged("Original_Coverage_Begin_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 4)]
		public DateTime Original_Coverage_Begin_Date_for_Benefit_Coverage_Type
		{
			get
			{
				return this.original_Coverage_Begin_Date_for_Benefit_Coverage_TypeField;
			}
			set
			{
				this.original_Coverage_Begin_Date_for_Benefit_Coverage_TypeField = value;
				this.RaisePropertyChanged("Original_Coverage_Begin_Date_for_Benefit_Coverage_Type");
			}
		}

		[XmlIgnore]
		public bool Original_Coverage_Begin_Date_for_Benefit_Coverage_TypeSpecified
		{
			get
			{
				return this.original_Coverage_Begin_Date_for_Benefit_Coverage_TypeFieldSpecified;
			}
			set
			{
				this.original_Coverage_Begin_Date_for_Benefit_Coverage_TypeFieldSpecified = value;
				this.RaisePropertyChanged("Original_Coverage_Begin_Date_for_Benefit_Coverage_TypeSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 5)]
		public DateTime Deduction_Begin_Date
		{
			get
			{
				return this.deduction_Begin_DateField;
			}
			set
			{
				this.deduction_Begin_DateField = value;
				this.RaisePropertyChanged("Deduction_Begin_Date");
			}
		}

		[XmlIgnore]
		public bool Deduction_Begin_DateSpecified
		{
			get
			{
				return this.deduction_Begin_DateFieldSpecified;
			}
			set
			{
				this.deduction_Begin_DateFieldSpecified = value;
				this.RaisePropertyChanged("Deduction_Begin_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 6)]
		public DateTime Deduction_End_Date
		{
			get
			{
				return this.deduction_End_DateField;
			}
			set
			{
				this.deduction_End_DateField = value;
				this.RaisePropertyChanged("Deduction_End_Date");
			}
		}

		[XmlIgnore]
		public bool Deduction_End_DateSpecified
		{
			get
			{
				return this.deduction_End_DateFieldSpecified;
			}
			set
			{
				this.deduction_End_DateFieldSpecified = value;
				this.RaisePropertyChanged("Deduction_End_DateSpecified");
			}
		}

		[XmlElement(Order = 7)]
		public string Election_Status
		{
			get
			{
				return this.election_StatusField;
			}
			set
			{
				this.election_StatusField = value;
				this.RaisePropertyChanged("Election_Status");
			}
		}

		[XmlElement(DataType = "date", Order = 8)]
		public DateTime Enrollment_Signature_Date
		{
			get
			{
				return this.enrollment_Signature_DateField;
			}
			set
			{
				this.enrollment_Signature_DateField = value;
				this.RaisePropertyChanged("Enrollment_Signature_Date");
			}
		}

		[XmlIgnore]
		public bool Enrollment_Signature_DateSpecified
		{
			get
			{
				return this.enrollment_Signature_DateFieldSpecified;
			}
			set
			{
				this.enrollment_Signature_DateFieldSpecified = value;
				this.RaisePropertyChanged("Enrollment_Signature_DateSpecified");
			}
		}

		[XmlElement(Order = 9)]
		public bool Passive_Enrollment
		{
			get
			{
				return this.passive_EnrollmentField;
			}
			set
			{
				this.passive_EnrollmentField = value;
				this.RaisePropertyChanged("Passive_Enrollment");
			}
		}

		[XmlIgnore]
		public bool Passive_EnrollmentSpecified
		{
			get
			{
				return this.passive_EnrollmentFieldSpecified;
			}
			set
			{
				this.passive_EnrollmentFieldSpecified = value;
				this.RaisePropertyChanged("Passive_EnrollmentSpecified");
			}
		}

		[XmlElement(Order = 10)]
		public Benefit_Plan_Summary_DataType Benefit_Plan_Summary_Data
		{
			get
			{
				return this.benefit_Plan_Summary_DataField;
			}
			set
			{
				this.benefit_Plan_Summary_DataField = value;
				this.RaisePropertyChanged("Benefit_Plan_Summary_Data");
			}
		}

		[XmlElement(DataType = "date", Order = 11)]
		public DateTime Original_Plan_Enrollment_Date
		{
			get
			{
				return this.original_Plan_Enrollment_DateField;
			}
			set
			{
				this.original_Plan_Enrollment_DateField = value;
				this.RaisePropertyChanged("Original_Plan_Enrollment_Date");
			}
		}

		[XmlIgnore]
		public bool Original_Plan_Enrollment_DateSpecified
		{
			get
			{
				return this.original_Plan_Enrollment_DateFieldSpecified;
			}
			set
			{
				this.original_Plan_Enrollment_DateFieldSpecified = value;
				this.RaisePropertyChanged("Original_Plan_Enrollment_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 12)]
		public DateTime Original_Benefit_Provider_Enrollment_Date
		{
			get
			{
				return this.original_Benefit_Provider_Enrollment_DateField;
			}
			set
			{
				this.original_Benefit_Provider_Enrollment_DateField = value;
				this.RaisePropertyChanged("Original_Benefit_Provider_Enrollment_Date");
			}
		}

		[XmlIgnore]
		public bool Original_Benefit_Provider_Enrollment_DateSpecified
		{
			get
			{
				return this.original_Benefit_Provider_Enrollment_DateFieldSpecified;
			}
			set
			{
				this.original_Benefit_Provider_Enrollment_DateFieldSpecified = value;
				this.RaisePropertyChanged("Original_Benefit_Provider_Enrollment_DateSpecified");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public bool Is_Corrected_or_Rescinded
		{
			get
			{
				return this.is_Corrected_or_RescindedField;
			}
			set
			{
				this.is_Corrected_or_RescindedField = value;
				this.RaisePropertyChanged("Is_Corrected_or_Rescinded");
			}
		}

		[XmlIgnore]
		public bool Is_Corrected_or_RescindedSpecified
		{
			get
			{
				return this.is_Corrected_or_RescindedFieldSpecified;
			}
			set
			{
				this.is_Corrected_or_RescindedFieldSpecified = value;
				this.RaisePropertyChanged("Is_Corrected_or_RescindedSpecified");
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
