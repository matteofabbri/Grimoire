using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Gift_DataType : INotifyPropertyChanged
	{
		private string idField;

		private bool inactiveField;

		private bool inactiveFieldSpecified;

		private bool submitField;

		private bool submitFieldSpecified;

		private string gift_NameField;

		private DateTime date_Gift_EstablishedField;

		private bool date_Gift_EstablishedFieldSpecified;

		private bool include_Gift_ID_in_NameField;

		private bool include_Gift_ID_in_NameFieldSpecified;

		private string alternate_NameField;

		private Gift_ClassificationObjectType gift_Classification_ReferenceField;

		private Investment_PoolObjectType investment_Pool_ReferenceField;

		private CompanyObjectType company_ReferenceField;

		private Gift_TypeObjectType gift_Type_ReferenceField;

		private Gift_PurposeObjectType[] gift_Purpose_ReferenceField;

		private Approval_LevelObjectType approval_Level_ReferenceField;

		private OriginationObjectType origination_ReferenceField;

		private bool administrative_Fee_AppliesField;

		private bool administrative_Fee_AppliesFieldSpecified;

		private string restriction_DescriptionField;

		private Related_Worktags_by_Worktag_Type_DataType[] related_Worktags_DataField;

		private Accounting_WorktagObjectType[] purchase_Worktag_ReferenceField;

		private Accounting_WorktagObjectType[] reinvestment_Worktag_ReferenceField;

		private bool mandatory_ReinvestmentField;

		private bool mandatory_ReinvestmentFieldSpecified;

		private bool pay_Flat_Amount___Reinvest_BalanceField;

		private bool pay_Flat_Amount___Reinvest_BalanceFieldSpecified;

		private decimal reinvestment_AmountField;

		private bool reinvestment_AmountFieldSpecified;

		private decimal reinvestment_PercentField;

		private bool reinvestment_PercentFieldSpecified;

		private decimal until_Principal_AmountField;

		private bool until_Principal_AmountFieldSpecified;

		private DateTime until_Reinvestment_DateField;

		private bool until_Reinvestment_DateFieldSpecified;

		private Income_Distribution_Rule_DataType income_Distribution_Rule_DataField;

		private Gift_Restriction_DataType[] gift_Restriction_DataField;

		private Financials_Attachment_DataType[] attachment_DataField;

		private Attachment_Data_WWSType[] secured_AttachmentField;

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

		[XmlElement(Order = 2)]
		public bool Submit
		{
			get
			{
				return this.submitField;
			}
			set
			{
				this.submitField = value;
				this.RaisePropertyChanged("Submit");
			}
		}

		[XmlIgnore]
		public bool SubmitSpecified
		{
			get
			{
				return this.submitFieldSpecified;
			}
			set
			{
				this.submitFieldSpecified = value;
				this.RaisePropertyChanged("SubmitSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public string Gift_Name
		{
			get
			{
				return this.gift_NameField;
			}
			set
			{
				this.gift_NameField = value;
				this.RaisePropertyChanged("Gift_Name");
			}
		}

		[XmlElement(DataType = "date", Order = 4)]
		public DateTime Date_Gift_Established
		{
			get
			{
				return this.date_Gift_EstablishedField;
			}
			set
			{
				this.date_Gift_EstablishedField = value;
				this.RaisePropertyChanged("Date_Gift_Established");
			}
		}

		[XmlIgnore]
		public bool Date_Gift_EstablishedSpecified
		{
			get
			{
				return this.date_Gift_EstablishedFieldSpecified;
			}
			set
			{
				this.date_Gift_EstablishedFieldSpecified = value;
				this.RaisePropertyChanged("Date_Gift_EstablishedSpecified");
			}
		}

		[XmlElement(Order = 5)]
		public bool Include_Gift_ID_in_Name
		{
			get
			{
				return this.include_Gift_ID_in_NameField;
			}
			set
			{
				this.include_Gift_ID_in_NameField = value;
				this.RaisePropertyChanged("Include_Gift_ID_in_Name");
			}
		}

		[XmlIgnore]
		public bool Include_Gift_ID_in_NameSpecified
		{
			get
			{
				return this.include_Gift_ID_in_NameFieldSpecified;
			}
			set
			{
				this.include_Gift_ID_in_NameFieldSpecified = value;
				this.RaisePropertyChanged("Include_Gift_ID_in_NameSpecified");
			}
		}

		[XmlElement(Order = 6)]
		public string Alternate_Name
		{
			get
			{
				return this.alternate_NameField;
			}
			set
			{
				this.alternate_NameField = value;
				this.RaisePropertyChanged("Alternate_Name");
			}
		}

		[XmlElement(Order = 7)]
		public Gift_ClassificationObjectType Gift_Classification_Reference
		{
			get
			{
				return this.gift_Classification_ReferenceField;
			}
			set
			{
				this.gift_Classification_ReferenceField = value;
				this.RaisePropertyChanged("Gift_Classification_Reference");
			}
		}

		[XmlElement(Order = 8)]
		public Investment_PoolObjectType Investment_Pool_Reference
		{
			get
			{
				return this.investment_Pool_ReferenceField;
			}
			set
			{
				this.investment_Pool_ReferenceField = value;
				this.RaisePropertyChanged("Investment_Pool_Reference");
			}
		}

		[XmlElement(Order = 9)]
		public CompanyObjectType Company_Reference
		{
			get
			{
				return this.company_ReferenceField;
			}
			set
			{
				this.company_ReferenceField = value;
				this.RaisePropertyChanged("Company_Reference");
			}
		}

		[XmlElement(Order = 10)]
		public Gift_TypeObjectType Gift_Type_Reference
		{
			get
			{
				return this.gift_Type_ReferenceField;
			}
			set
			{
				this.gift_Type_ReferenceField = value;
				this.RaisePropertyChanged("Gift_Type_Reference");
			}
		}

		[XmlElement("Gift_Purpose_Reference", Order = 11)]
		public Gift_PurposeObjectType[] Gift_Purpose_Reference
		{
			get
			{
				return this.gift_Purpose_ReferenceField;
			}
			set
			{
				this.gift_Purpose_ReferenceField = value;
				this.RaisePropertyChanged("Gift_Purpose_Reference");
			}
		}

		[XmlElement(Order = 12)]
		public Approval_LevelObjectType Approval_Level_Reference
		{
			get
			{
				return this.approval_Level_ReferenceField;
			}
			set
			{
				this.approval_Level_ReferenceField = value;
				this.RaisePropertyChanged("Approval_Level_Reference");
			}
		}

		[XmlElement(Order = 13)]
		public OriginationObjectType Origination_Reference
		{
			get
			{
				return this.origination_ReferenceField;
			}
			set
			{
				this.origination_ReferenceField = value;
				this.RaisePropertyChanged("Origination_Reference");
			}
		}

		[XmlElement(Order = 14)]
		public bool Administrative_Fee_Applies
		{
			get
			{
				return this.administrative_Fee_AppliesField;
			}
			set
			{
				this.administrative_Fee_AppliesField = value;
				this.RaisePropertyChanged("Administrative_Fee_Applies");
			}
		}

		[XmlIgnore]
		public bool Administrative_Fee_AppliesSpecified
		{
			get
			{
				return this.administrative_Fee_AppliesFieldSpecified;
			}
			set
			{
				this.administrative_Fee_AppliesFieldSpecified = value;
				this.RaisePropertyChanged("Administrative_Fee_AppliesSpecified");
			}
		}

		[XmlElement(Order = 15)]
		public string Restriction_Description
		{
			get
			{
				return this.restriction_DescriptionField;
			}
			set
			{
				this.restriction_DescriptionField = value;
				this.RaisePropertyChanged("Restriction_Description");
			}
		}

		[XmlArray(Order = 16), XmlArrayItem("Related_Worktags_by_Type_Data", IsNullable = false)]
		public Related_Worktags_by_Worktag_Type_DataType[] Related_Worktags_Data
		{
			get
			{
				return this.related_Worktags_DataField;
			}
			set
			{
				this.related_Worktags_DataField = value;
				this.RaisePropertyChanged("Related_Worktags_Data");
			}
		}

		[XmlElement("Purchase_Worktag_Reference", Order = 17)]
		public Accounting_WorktagObjectType[] Purchase_Worktag_Reference
		{
			get
			{
				return this.purchase_Worktag_ReferenceField;
			}
			set
			{
				this.purchase_Worktag_ReferenceField = value;
				this.RaisePropertyChanged("Purchase_Worktag_Reference");
			}
		}

		[XmlElement("Reinvestment_Worktag_Reference", Order = 18)]
		public Accounting_WorktagObjectType[] Reinvestment_Worktag_Reference
		{
			get
			{
				return this.reinvestment_Worktag_ReferenceField;
			}
			set
			{
				this.reinvestment_Worktag_ReferenceField = value;
				this.RaisePropertyChanged("Reinvestment_Worktag_Reference");
			}
		}

		[XmlElement(Order = 19)]
		public bool Mandatory_Reinvestment
		{
			get
			{
				return this.mandatory_ReinvestmentField;
			}
			set
			{
				this.mandatory_ReinvestmentField = value;
				this.RaisePropertyChanged("Mandatory_Reinvestment");
			}
		}

		[XmlIgnore]
		public bool Mandatory_ReinvestmentSpecified
		{
			get
			{
				return this.mandatory_ReinvestmentFieldSpecified;
			}
			set
			{
				this.mandatory_ReinvestmentFieldSpecified = value;
				this.RaisePropertyChanged("Mandatory_ReinvestmentSpecified");
			}
		}

		[XmlElement(Order = 20)]
		public bool Pay_Flat_Amount___Reinvest_Balance
		{
			get
			{
				return this.pay_Flat_Amount___Reinvest_BalanceField;
			}
			set
			{
				this.pay_Flat_Amount___Reinvest_BalanceField = value;
				this.RaisePropertyChanged("Pay_Flat_Amount___Reinvest_Balance");
			}
		}

		[XmlIgnore]
		public bool Pay_Flat_Amount___Reinvest_BalanceSpecified
		{
			get
			{
				return this.pay_Flat_Amount___Reinvest_BalanceFieldSpecified;
			}
			set
			{
				this.pay_Flat_Amount___Reinvest_BalanceFieldSpecified = value;
				this.RaisePropertyChanged("Pay_Flat_Amount___Reinvest_BalanceSpecified");
			}
		}

		[XmlElement(Order = 21)]
		public decimal Reinvestment_Amount
		{
			get
			{
				return this.reinvestment_AmountField;
			}
			set
			{
				this.reinvestment_AmountField = value;
				this.RaisePropertyChanged("Reinvestment_Amount");
			}
		}

		[XmlIgnore]
		public bool Reinvestment_AmountSpecified
		{
			get
			{
				return this.reinvestment_AmountFieldSpecified;
			}
			set
			{
				this.reinvestment_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Reinvestment_AmountSpecified");
			}
		}

		[XmlElement(Order = 22)]
		public decimal Reinvestment_Percent
		{
			get
			{
				return this.reinvestment_PercentField;
			}
			set
			{
				this.reinvestment_PercentField = value;
				this.RaisePropertyChanged("Reinvestment_Percent");
			}
		}

		[XmlIgnore]
		public bool Reinvestment_PercentSpecified
		{
			get
			{
				return this.reinvestment_PercentFieldSpecified;
			}
			set
			{
				this.reinvestment_PercentFieldSpecified = value;
				this.RaisePropertyChanged("Reinvestment_PercentSpecified");
			}
		}

		[XmlElement(Order = 23)]
		public decimal Until_Principal_Amount
		{
			get
			{
				return this.until_Principal_AmountField;
			}
			set
			{
				this.until_Principal_AmountField = value;
				this.RaisePropertyChanged("Until_Principal_Amount");
			}
		}

		[XmlIgnore]
		public bool Until_Principal_AmountSpecified
		{
			get
			{
				return this.until_Principal_AmountFieldSpecified;
			}
			set
			{
				this.until_Principal_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Until_Principal_AmountSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 24)]
		public DateTime Until_Reinvestment_Date
		{
			get
			{
				return this.until_Reinvestment_DateField;
			}
			set
			{
				this.until_Reinvestment_DateField = value;
				this.RaisePropertyChanged("Until_Reinvestment_Date");
			}
		}

		[XmlIgnore]
		public bool Until_Reinvestment_DateSpecified
		{
			get
			{
				return this.until_Reinvestment_DateFieldSpecified;
			}
			set
			{
				this.until_Reinvestment_DateFieldSpecified = value;
				this.RaisePropertyChanged("Until_Reinvestment_DateSpecified");
			}
		}

		[XmlElement(Order = 25)]
		public Income_Distribution_Rule_DataType Income_Distribution_Rule_Data
		{
			get
			{
				return this.income_Distribution_Rule_DataField;
			}
			set
			{
				this.income_Distribution_Rule_DataField = value;
				this.RaisePropertyChanged("Income_Distribution_Rule_Data");
			}
		}

		[XmlElement("Gift_Restriction_Data", Order = 26)]
		public Gift_Restriction_DataType[] Gift_Restriction_Data
		{
			get
			{
				return this.gift_Restriction_DataField;
			}
			set
			{
				this.gift_Restriction_DataField = value;
				this.RaisePropertyChanged("Gift_Restriction_Data");
			}
		}

		[XmlElement("Attachment_Data", Order = 27)]
		public Financials_Attachment_DataType[] Attachment_Data
		{
			get
			{
				return this.attachment_DataField;
			}
			set
			{
				this.attachment_DataField = value;
				this.RaisePropertyChanged("Attachment_Data");
			}
		}

		[XmlElement("Secured_Attachment", Order = 28)]
		public Attachment_Data_WWSType[] Secured_Attachment
		{
			get
			{
				return this.secured_AttachmentField;
			}
			set
			{
				this.secured_AttachmentField = value;
				this.RaisePropertyChanged("Secured_Attachment");
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
