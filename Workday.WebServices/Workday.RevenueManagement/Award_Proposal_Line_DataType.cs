using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Award_Proposal_Line_DataType : INotifyPropertyChanged
	{
		private Award_Proposal_LineObjectType award_Proposal_Line_ReferenceField;

		private string award_Proposal_Line_IDField;

		private string award_Proposal_Line_NotesField;

		private Contract_Line_TypeObjectType contract_Line_Type_ReferenceField;

		private decimal award_Proposal_Line_NumberField;

		private bool award_Proposal_Line_NumberFieldSpecified;

		private bool award_Proposal_Line_Primary_LineField;

		private bool award_Proposal_Line_Primary_LineFieldSpecified;

		private Proposal_GrantObjectType award_Proposal_Grant_ReferenceField;

		private decimal extended_AmountField;

		private bool extended_AmountFieldSpecified;

		private Accounting_CategoryObjectType revenue_Category_ReferenceField;

		private string line_Item_DescriptionField;

		private Facilities_and_Admin_Rate_AgreementObjectType facilities_and_Administration_Rate_Agreement_ReferenceField;

		private Facilities_and_Admin_Cost_Rate_TypeObjectType facilities_and_Administration_Cost_Rate_Type_ReferenceField;

		private Facilities_and_Admin_ExceptionObjectType facilities_and_Admin_Exception_ReferenceField;

		private DateTime award_Proposal_Line_Start_DateField;

		private bool award_Proposal_Line_Start_DateFieldSpecified;

		private DateTime award_Proposal_Line_End_DateField;

		private bool award_Proposal_Line_End_DateFieldSpecified;

		private string award_Proposal_Line_MemoField;

		private Audited_Accounting_WorktagObjectType[] award_Proposal_Line_Worktag_ReferenceField;

		private SupplierObjectType subrecipient_ReferenceField;

		private Award_Proposal_Personnel_DataType[] award_Proposal_Personnel_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Award_Proposal_LineObjectType Award_Proposal_Line_Reference
		{
			get
			{
				return this.award_Proposal_Line_ReferenceField;
			}
			set
			{
				this.award_Proposal_Line_ReferenceField = value;
				this.RaisePropertyChanged("Award_Proposal_Line_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public string Award_Proposal_Line_ID
		{
			get
			{
				return this.award_Proposal_Line_IDField;
			}
			set
			{
				this.award_Proposal_Line_IDField = value;
				this.RaisePropertyChanged("Award_Proposal_Line_ID");
			}
		}

		[XmlElement(Order = 2)]
		public string Award_Proposal_Line_Notes
		{
			get
			{
				return this.award_Proposal_Line_NotesField;
			}
			set
			{
				this.award_Proposal_Line_NotesField = value;
				this.RaisePropertyChanged("Award_Proposal_Line_Notes");
			}
		}

		[XmlElement(Order = 3)]
		public Contract_Line_TypeObjectType Contract_Line_Type_Reference
		{
			get
			{
				return this.contract_Line_Type_ReferenceField;
			}
			set
			{
				this.contract_Line_Type_ReferenceField = value;
				this.RaisePropertyChanged("Contract_Line_Type_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public decimal Award_Proposal_Line_Number
		{
			get
			{
				return this.award_Proposal_Line_NumberField;
			}
			set
			{
				this.award_Proposal_Line_NumberField = value;
				this.RaisePropertyChanged("Award_Proposal_Line_Number");
			}
		}

		[XmlIgnore]
		public bool Award_Proposal_Line_NumberSpecified
		{
			get
			{
				return this.award_Proposal_Line_NumberFieldSpecified;
			}
			set
			{
				this.award_Proposal_Line_NumberFieldSpecified = value;
				this.RaisePropertyChanged("Award_Proposal_Line_NumberSpecified");
			}
		}

		[XmlElement(Order = 5)]
		public bool Award_Proposal_Line_Primary_Line
		{
			get
			{
				return this.award_Proposal_Line_Primary_LineField;
			}
			set
			{
				this.award_Proposal_Line_Primary_LineField = value;
				this.RaisePropertyChanged("Award_Proposal_Line_Primary_Line");
			}
		}

		[XmlIgnore]
		public bool Award_Proposal_Line_Primary_LineSpecified
		{
			get
			{
				return this.award_Proposal_Line_Primary_LineFieldSpecified;
			}
			set
			{
				this.award_Proposal_Line_Primary_LineFieldSpecified = value;
				this.RaisePropertyChanged("Award_Proposal_Line_Primary_LineSpecified");
			}
		}

		[XmlElement(Order = 6)]
		public Proposal_GrantObjectType Award_Proposal_Grant_Reference
		{
			get
			{
				return this.award_Proposal_Grant_ReferenceField;
			}
			set
			{
				this.award_Proposal_Grant_ReferenceField = value;
				this.RaisePropertyChanged("Award_Proposal_Grant_Reference");
			}
		}

		[XmlElement(Order = 7)]
		public decimal Extended_Amount
		{
			get
			{
				return this.extended_AmountField;
			}
			set
			{
				this.extended_AmountField = value;
				this.RaisePropertyChanged("Extended_Amount");
			}
		}

		[XmlIgnore]
		public bool Extended_AmountSpecified
		{
			get
			{
				return this.extended_AmountFieldSpecified;
			}
			set
			{
				this.extended_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Extended_AmountSpecified");
			}
		}

		[XmlElement(Order = 8)]
		public Accounting_CategoryObjectType Revenue_Category_Reference
		{
			get
			{
				return this.revenue_Category_ReferenceField;
			}
			set
			{
				this.revenue_Category_ReferenceField = value;
				this.RaisePropertyChanged("Revenue_Category_Reference");
			}
		}

		[XmlElement(Order = 9)]
		public string Line_Item_Description
		{
			get
			{
				return this.line_Item_DescriptionField;
			}
			set
			{
				this.line_Item_DescriptionField = value;
				this.RaisePropertyChanged("Line_Item_Description");
			}
		}

		[XmlElement(Order = 10)]
		public Facilities_and_Admin_Rate_AgreementObjectType Facilities_and_Administration_Rate_Agreement_Reference
		{
			get
			{
				return this.facilities_and_Administration_Rate_Agreement_ReferenceField;
			}
			set
			{
				this.facilities_and_Administration_Rate_Agreement_ReferenceField = value;
				this.RaisePropertyChanged("Facilities_and_Administration_Rate_Agreement_Reference");
			}
		}

		[XmlElement(Order = 11)]
		public Facilities_and_Admin_Cost_Rate_TypeObjectType Facilities_and_Administration_Cost_Rate_Type_Reference
		{
			get
			{
				return this.facilities_and_Administration_Cost_Rate_Type_ReferenceField;
			}
			set
			{
				this.facilities_and_Administration_Cost_Rate_Type_ReferenceField = value;
				this.RaisePropertyChanged("Facilities_and_Administration_Cost_Rate_Type_Reference");
			}
		}

		[XmlElement(Order = 12)]
		public Facilities_and_Admin_ExceptionObjectType Facilities_and_Admin_Exception_Reference
		{
			get
			{
				return this.facilities_and_Admin_Exception_ReferenceField;
			}
			set
			{
				this.facilities_and_Admin_Exception_ReferenceField = value;
				this.RaisePropertyChanged("Facilities_and_Admin_Exception_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 13)]
		public DateTime Award_Proposal_Line_Start_Date
		{
			get
			{
				return this.award_Proposal_Line_Start_DateField;
			}
			set
			{
				this.award_Proposal_Line_Start_DateField = value;
				this.RaisePropertyChanged("Award_Proposal_Line_Start_Date");
			}
		}

		[XmlIgnore]
		public bool Award_Proposal_Line_Start_DateSpecified
		{
			get
			{
				return this.award_Proposal_Line_Start_DateFieldSpecified;
			}
			set
			{
				this.award_Proposal_Line_Start_DateFieldSpecified = value;
				this.RaisePropertyChanged("Award_Proposal_Line_Start_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 14)]
		public DateTime Award_Proposal_Line_End_Date
		{
			get
			{
				return this.award_Proposal_Line_End_DateField;
			}
			set
			{
				this.award_Proposal_Line_End_DateField = value;
				this.RaisePropertyChanged("Award_Proposal_Line_End_Date");
			}
		}

		[XmlIgnore]
		public bool Award_Proposal_Line_End_DateSpecified
		{
			get
			{
				return this.award_Proposal_Line_End_DateFieldSpecified;
			}
			set
			{
				this.award_Proposal_Line_End_DateFieldSpecified = value;
				this.RaisePropertyChanged("Award_Proposal_Line_End_DateSpecified");
			}
		}

		[XmlElement(Order = 15)]
		public string Award_Proposal_Line_Memo
		{
			get
			{
				return this.award_Proposal_Line_MemoField;
			}
			set
			{
				this.award_Proposal_Line_MemoField = value;
				this.RaisePropertyChanged("Award_Proposal_Line_Memo");
			}
		}

		[XmlElement("Award_Proposal_Line_Worktag_Reference", Order = 16)]
		public Audited_Accounting_WorktagObjectType[] Award_Proposal_Line_Worktag_Reference
		{
			get
			{
				return this.award_Proposal_Line_Worktag_ReferenceField;
			}
			set
			{
				this.award_Proposal_Line_Worktag_ReferenceField = value;
				this.RaisePropertyChanged("Award_Proposal_Line_Worktag_Reference");
			}
		}

		[XmlElement(Order = 17)]
		public SupplierObjectType Subrecipient_Reference
		{
			get
			{
				return this.subrecipient_ReferenceField;
			}
			set
			{
				this.subrecipient_ReferenceField = value;
				this.RaisePropertyChanged("Subrecipient_Reference");
			}
		}

		[XmlElement("Award_Proposal_Personnel_Data", Order = 18)]
		public Award_Proposal_Personnel_DataType[] Award_Proposal_Personnel_Data
		{
			get
			{
				return this.award_Proposal_Personnel_DataField;
			}
			set
			{
				this.award_Proposal_Personnel_DataField = value;
				this.RaisePropertyChanged("Award_Proposal_Personnel_Data");
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
