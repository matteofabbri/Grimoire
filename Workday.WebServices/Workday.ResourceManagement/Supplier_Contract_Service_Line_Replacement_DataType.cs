using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Supplier_Contract_Service_Line_Replacement_DataType : INotifyPropertyChanged
	{
		private string line_NumberField;

		private CompanyObjectType company_for_Invoices_ReferenceField;

		private bool line_On_HoldField;

		private bool line_On_HoldFieldSpecified;

		private Procurement_ItemObjectType item_ReferenceField;

		private string descriptionField;

		private Spend_CategoryObjectType spend_Category_ReferenceField;

		private Tax_ApplicabilityObjectType tax_Applicability_ReferenceField;

		private Tax_CodeObjectType tax_Code_ReferenceField;

		private decimal extended_AmountField;

		private bool extended_AmountFieldSpecified;

		private DateTime start_DateField;

		private bool start_DateFieldSpecified;

		private DateTime end_DateField;

		private bool end_DateFieldSpecified;

		private Supplier_Contract_Line_Renewal_DataType supplier_Contract_Line_Renewal_DataField;

		private bool retentionField;

		private bool retentionFieldSpecified;

		private Address_ReferenceObjectType ship_To_Address_ReferenceField;

		private WorkerObjectType ship_To_Contact_ReferenceField;

		private string memoField;

		private LocationObjectType location_ReferenceField;

		private Accounting_WorktagObjectType[] worktag_ReferenceField;

		private Business_Document_LineObjectType[] related_Document_Lines_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Line_Number
		{
			get
			{
				return this.line_NumberField;
			}
			set
			{
				this.line_NumberField = value;
				this.RaisePropertyChanged("Line_Number");
			}
		}

		[XmlElement(Order = 1)]
		public CompanyObjectType Company_for_Invoices_Reference
		{
			get
			{
				return this.company_for_Invoices_ReferenceField;
			}
			set
			{
				this.company_for_Invoices_ReferenceField = value;
				this.RaisePropertyChanged("Company_for_Invoices_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public bool Line_On_Hold
		{
			get
			{
				return this.line_On_HoldField;
			}
			set
			{
				this.line_On_HoldField = value;
				this.RaisePropertyChanged("Line_On_Hold");
			}
		}

		[XmlIgnore]
		public bool Line_On_HoldSpecified
		{
			get
			{
				return this.line_On_HoldFieldSpecified;
			}
			set
			{
				this.line_On_HoldFieldSpecified = value;
				this.RaisePropertyChanged("Line_On_HoldSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public Procurement_ItemObjectType Item_Reference
		{
			get
			{
				return this.item_ReferenceField;
			}
			set
			{
				this.item_ReferenceField = value;
				this.RaisePropertyChanged("Item_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public string Description
		{
			get
			{
				return this.descriptionField;
			}
			set
			{
				this.descriptionField = value;
				this.RaisePropertyChanged("Description");
			}
		}

		[XmlElement(Order = 5)]
		public Spend_CategoryObjectType Spend_Category_Reference
		{
			get
			{
				return this.spend_Category_ReferenceField;
			}
			set
			{
				this.spend_Category_ReferenceField = value;
				this.RaisePropertyChanged("Spend_Category_Reference");
			}
		}

		[XmlElement(Order = 6)]
		public Tax_ApplicabilityObjectType Tax_Applicability_Reference
		{
			get
			{
				return this.tax_Applicability_ReferenceField;
			}
			set
			{
				this.tax_Applicability_ReferenceField = value;
				this.RaisePropertyChanged("Tax_Applicability_Reference");
			}
		}

		[XmlElement(Order = 7)]
		public Tax_CodeObjectType Tax_Code_Reference
		{
			get
			{
				return this.tax_Code_ReferenceField;
			}
			set
			{
				this.tax_Code_ReferenceField = value;
				this.RaisePropertyChanged("Tax_Code_Reference");
			}
		}

		[XmlElement(Order = 8)]
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

		[XmlElement(DataType = "date", Order = 9)]
		public DateTime Start_Date
		{
			get
			{
				return this.start_DateField;
			}
			set
			{
				this.start_DateField = value;
				this.RaisePropertyChanged("Start_Date");
			}
		}

		[XmlIgnore]
		public bool Start_DateSpecified
		{
			get
			{
				return this.start_DateFieldSpecified;
			}
			set
			{
				this.start_DateFieldSpecified = value;
				this.RaisePropertyChanged("Start_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 10)]
		public DateTime End_Date
		{
			get
			{
				return this.end_DateField;
			}
			set
			{
				this.end_DateField = value;
				this.RaisePropertyChanged("End_Date");
			}
		}

		[XmlIgnore]
		public bool End_DateSpecified
		{
			get
			{
				return this.end_DateFieldSpecified;
			}
			set
			{
				this.end_DateFieldSpecified = value;
				this.RaisePropertyChanged("End_DateSpecified");
			}
		}

		[XmlElement(Order = 11)]
		public Supplier_Contract_Line_Renewal_DataType Supplier_Contract_Line_Renewal_Data
		{
			get
			{
				return this.supplier_Contract_Line_Renewal_DataField;
			}
			set
			{
				this.supplier_Contract_Line_Renewal_DataField = value;
				this.RaisePropertyChanged("Supplier_Contract_Line_Renewal_Data");
			}
		}

		[XmlElement(Order = 12)]
		public bool Retention
		{
			get
			{
				return this.retentionField;
			}
			set
			{
				this.retentionField = value;
				this.RaisePropertyChanged("Retention");
			}
		}

		[XmlIgnore]
		public bool RetentionSpecified
		{
			get
			{
				return this.retentionFieldSpecified;
			}
			set
			{
				this.retentionFieldSpecified = value;
				this.RaisePropertyChanged("RetentionSpecified");
			}
		}

		[XmlElement(Order = 13)]
		public Address_ReferenceObjectType Ship_To_Address_Reference
		{
			get
			{
				return this.ship_To_Address_ReferenceField;
			}
			set
			{
				this.ship_To_Address_ReferenceField = value;
				this.RaisePropertyChanged("Ship_To_Address_Reference");
			}
		}

		[XmlElement(Order = 14)]
		public WorkerObjectType Ship_To_Contact_Reference
		{
			get
			{
				return this.ship_To_Contact_ReferenceField;
			}
			set
			{
				this.ship_To_Contact_ReferenceField = value;
				this.RaisePropertyChanged("Ship_To_Contact_Reference");
			}
		}

		[XmlElement(Order = 15)]
		public string Memo
		{
			get
			{
				return this.memoField;
			}
			set
			{
				this.memoField = value;
				this.RaisePropertyChanged("Memo");
			}
		}

		[XmlElement(Order = 16)]
		public LocationObjectType Location_Reference
		{
			get
			{
				return this.location_ReferenceField;
			}
			set
			{
				this.location_ReferenceField = value;
				this.RaisePropertyChanged("Location_Reference");
			}
		}

		[XmlElement("Worktag_Reference", Order = 17)]
		public Accounting_WorktagObjectType[] Worktag_Reference
		{
			get
			{
				return this.worktag_ReferenceField;
			}
			set
			{
				this.worktag_ReferenceField = value;
				this.RaisePropertyChanged("Worktag_Reference");
			}
		}

		[XmlElement("Related_Document_Lines_Reference", Order = 18)]
		public Business_Document_LineObjectType[] Related_Document_Lines_Reference
		{
			get
			{
				return this.related_Document_Lines_ReferenceField;
			}
			set
			{
				this.related_Document_Lines_ReferenceField = value;
				this.RaisePropertyChanged("Related_Document_Lines_Reference");
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
