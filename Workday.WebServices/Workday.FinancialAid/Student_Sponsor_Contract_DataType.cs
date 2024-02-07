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
	public class Student_Sponsor_Contract_DataType : INotifyPropertyChanged
	{
		private string idField;

		private Has_Academic_Curricular_Division_DataType[] academic_Unit_DataField;

		private string contract_NameField;

		private Financial_Aid_Award_YearObjectType financial_Aid_Award_Year_ReferenceField;

		private string contract_DescriptionField;

		private DateTime document_DateField;

		private DateTime contract_Signed_DateField;

		private bool contract_Signed_DateFieldSpecified;

		private Payment_TermsObjectType payment_Terms_ReferenceField;

		private SponsorObjectType sponsor_Reflected_ReferenceField;

		private SponsorObjectType award_Contract_Bill_To_Sponsor_ReferenceField;

		private Payment_TypeObjectType payment_Type_ReferenceField;

		private bool no_FA_Need_ImpactField;

		private bool no_FA_Need_ImpactFieldSpecified;

		private CurrencyObjectType currency_ReferenceField;

		private Student_Precedence_GroupObjectType student_Precedence_Group_for_Academic_Unit_ReferenceField;

		private decimal student_MinimumField;

		private bool student_MinimumFieldSpecified;

		private decimal student_MaximumField;

		private bool student_MaximumFieldSpecified;

		private Student_Disbursement_ScheduleObjectType disbursement_Schedule_ReferenceField;

		private CalculationObjectType calculation_ReferenceField;

		private bool refundableField;

		private bool refundableFieldSpecified;

		private decimal total_Contract_AmountField;

		private Student_Sponsor_Contract_Line_DataType[] student_Sponsor_Contract_Line_DataField;

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

		[XmlElement("Academic_Unit_Data", Order = 1)]
		public Has_Academic_Curricular_Division_DataType[] Academic_Unit_Data
		{
			get
			{
				return this.academic_Unit_DataField;
			}
			set
			{
				this.academic_Unit_DataField = value;
				this.RaisePropertyChanged("Academic_Unit_Data");
			}
		}

		[XmlElement(Order = 2)]
		public string Contract_Name
		{
			get
			{
				return this.contract_NameField;
			}
			set
			{
				this.contract_NameField = value;
				this.RaisePropertyChanged("Contract_Name");
			}
		}

		[XmlElement(Order = 3)]
		public Financial_Aid_Award_YearObjectType Financial_Aid_Award_Year_Reference
		{
			get
			{
				return this.financial_Aid_Award_Year_ReferenceField;
			}
			set
			{
				this.financial_Aid_Award_Year_ReferenceField = value;
				this.RaisePropertyChanged("Financial_Aid_Award_Year_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public string Contract_Description
		{
			get
			{
				return this.contract_DescriptionField;
			}
			set
			{
				this.contract_DescriptionField = value;
				this.RaisePropertyChanged("Contract_Description");
			}
		}

		[XmlElement(DataType = "date", Order = 5)]
		public DateTime Document_Date
		{
			get
			{
				return this.document_DateField;
			}
			set
			{
				this.document_DateField = value;
				this.RaisePropertyChanged("Document_Date");
			}
		}

		[XmlElement(DataType = "date", Order = 6)]
		public DateTime Contract_Signed_Date
		{
			get
			{
				return this.contract_Signed_DateField;
			}
			set
			{
				this.contract_Signed_DateField = value;
				this.RaisePropertyChanged("Contract_Signed_Date");
			}
		}

		[XmlIgnore]
		public bool Contract_Signed_DateSpecified
		{
			get
			{
				return this.contract_Signed_DateFieldSpecified;
			}
			set
			{
				this.contract_Signed_DateFieldSpecified = value;
				this.RaisePropertyChanged("Contract_Signed_DateSpecified");
			}
		}

		[XmlElement(Order = 7)]
		public Payment_TermsObjectType Payment_Terms_Reference
		{
			get
			{
				return this.payment_Terms_ReferenceField;
			}
			set
			{
				this.payment_Terms_ReferenceField = value;
				this.RaisePropertyChanged("Payment_Terms_Reference");
			}
		}

		[XmlElement(Order = 8)]
		public SponsorObjectType Sponsor_Reflected_Reference
		{
			get
			{
				return this.sponsor_Reflected_ReferenceField;
			}
			set
			{
				this.sponsor_Reflected_ReferenceField = value;
				this.RaisePropertyChanged("Sponsor_Reflected_Reference");
			}
		}

		[XmlElement(Order = 9)]
		public SponsorObjectType Award_Contract_Bill_To_Sponsor_Reference
		{
			get
			{
				return this.award_Contract_Bill_To_Sponsor_ReferenceField;
			}
			set
			{
				this.award_Contract_Bill_To_Sponsor_ReferenceField = value;
				this.RaisePropertyChanged("Award_Contract_Bill_To_Sponsor_Reference");
			}
		}

		[XmlElement(Order = 10)]
		public Payment_TypeObjectType Payment_Type_Reference
		{
			get
			{
				return this.payment_Type_ReferenceField;
			}
			set
			{
				this.payment_Type_ReferenceField = value;
				this.RaisePropertyChanged("Payment_Type_Reference");
			}
		}

		[XmlElement(Order = 11)]
		public bool No_FA_Need_Impact
		{
			get
			{
				return this.no_FA_Need_ImpactField;
			}
			set
			{
				this.no_FA_Need_ImpactField = value;
				this.RaisePropertyChanged("No_FA_Need_Impact");
			}
		}

		[XmlIgnore]
		public bool No_FA_Need_ImpactSpecified
		{
			get
			{
				return this.no_FA_Need_ImpactFieldSpecified;
			}
			set
			{
				this.no_FA_Need_ImpactFieldSpecified = value;
				this.RaisePropertyChanged("No_FA_Need_ImpactSpecified");
			}
		}

		[XmlElement(Order = 12)]
		public CurrencyObjectType Currency_Reference
		{
			get
			{
				return this.currency_ReferenceField;
			}
			set
			{
				this.currency_ReferenceField = value;
				this.RaisePropertyChanged("Currency_Reference");
			}
		}

		[XmlElement(Order = 13)]
		public Student_Precedence_GroupObjectType Student_Precedence_Group_for_Academic_Unit_Reference
		{
			get
			{
				return this.student_Precedence_Group_for_Academic_Unit_ReferenceField;
			}
			set
			{
				this.student_Precedence_Group_for_Academic_Unit_ReferenceField = value;
				this.RaisePropertyChanged("Student_Precedence_Group_for_Academic_Unit_Reference");
			}
		}

		[XmlElement(Order = 14)]
		public decimal Student_Minimum
		{
			get
			{
				return this.student_MinimumField;
			}
			set
			{
				this.student_MinimumField = value;
				this.RaisePropertyChanged("Student_Minimum");
			}
		}

		[XmlIgnore]
		public bool Student_MinimumSpecified
		{
			get
			{
				return this.student_MinimumFieldSpecified;
			}
			set
			{
				this.student_MinimumFieldSpecified = value;
				this.RaisePropertyChanged("Student_MinimumSpecified");
			}
		}

		[XmlElement(Order = 15)]
		public decimal Student_Maximum
		{
			get
			{
				return this.student_MaximumField;
			}
			set
			{
				this.student_MaximumField = value;
				this.RaisePropertyChanged("Student_Maximum");
			}
		}

		[XmlIgnore]
		public bool Student_MaximumSpecified
		{
			get
			{
				return this.student_MaximumFieldSpecified;
			}
			set
			{
				this.student_MaximumFieldSpecified = value;
				this.RaisePropertyChanged("Student_MaximumSpecified");
			}
		}

		[XmlElement(Order = 16)]
		public Student_Disbursement_ScheduleObjectType Disbursement_Schedule_Reference
		{
			get
			{
				return this.disbursement_Schedule_ReferenceField;
			}
			set
			{
				this.disbursement_Schedule_ReferenceField = value;
				this.RaisePropertyChanged("Disbursement_Schedule_Reference");
			}
		}

		[XmlElement(Order = 17)]
		public CalculationObjectType Calculation_Reference
		{
			get
			{
				return this.calculation_ReferenceField;
			}
			set
			{
				this.calculation_ReferenceField = value;
				this.RaisePropertyChanged("Calculation_Reference");
			}
		}

		[XmlElement(Order = 18)]
		public bool Refundable
		{
			get
			{
				return this.refundableField;
			}
			set
			{
				this.refundableField = value;
				this.RaisePropertyChanged("Refundable");
			}
		}

		[XmlIgnore]
		public bool RefundableSpecified
		{
			get
			{
				return this.refundableFieldSpecified;
			}
			set
			{
				this.refundableFieldSpecified = value;
				this.RaisePropertyChanged("RefundableSpecified");
			}
		}

		[XmlElement(Order = 19)]
		public decimal Total_Contract_Amount
		{
			get
			{
				return this.total_Contract_AmountField;
			}
			set
			{
				this.total_Contract_AmountField = value;
				this.RaisePropertyChanged("Total_Contract_Amount");
			}
		}

		[XmlElement("Student_Sponsor_Contract_Line_Data", Order = 20)]
		public Student_Sponsor_Contract_Line_DataType[] Student_Sponsor_Contract_Line_Data
		{
			get
			{
				return this.student_Sponsor_Contract_Line_DataField;
			}
			set
			{
				this.student_Sponsor_Contract_Line_DataField = value;
				this.RaisePropertyChanged("Student_Sponsor_Contract_Line_Data");
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
