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
	public class Business_Asset_for_Register_WWS_DataType : INotifyPropertyChanged
	{
		private string business_Asset_IDField;

		private string business_Asset_NumberField;

		private CompanyObjectType company_ReferenceField;

		private string business_Asset_NameField;

		private Item_DescriptorObjectType item_ReferenceField;

		private string business_Asset_DescriptionField;

		private Spend_CategoryObjectType spend_Category_ReferenceField;

		private Accounting_TreatmentObjectType accounting_Treatment_ReferenceField;

		private Acquisition_MethodObjectType acquisition_Method_ReferenceField;

		private decimal acquisition_CostField;

		private bool acquisition_CostFieldSpecified;

		private decimal residual_ValueField;

		private bool residual_ValueFieldSpecified;

		private decimal fair_Market_ValueField;

		private bool fair_Market_ValueFieldSpecified;

		private decimal quantityField;

		private bool quantityFieldSpecified;

		private Accounting_WorktagObjectType[] worktags_ReferenceField;

		private DateTime date_AcquiredField;

		private DateTime date_Placed_in_ServiceField;

		private bool date_Placed_in_ServiceFieldSpecified;

		private DateTime last_Issue_DateField;

		private bool last_Issue_DateFieldSpecified;

		private Worker_iData_ReferenceType issued_to_Worker_ReferenceField;

		private LocationObjectType location_ReferenceField;

		private string asset_IdentifierField;

		private string serial_NumberField;

		private string manufacturerField;

		private Asset_ClassObjectType asset_Class_ReferenceField;

		private Asset_TypeObjectType asset_Type_ReferenceField;

		private decimal business_Use_PercentageField;

		private bool business_Use_PercentageFieldSpecified;

		private InstanceObjectType[] related_Assets_ReferenceField;

		private string pO_NumberField;

		private string receipt_NumberField;

		private string supplier_Invoice_NumberField;

		private string project_NumberField;

		private string contract_NumberField;

		private DateTime contract_Line_Start_DateField;

		private bool contract_Line_Start_DateFieldSpecified;

		private DateTime contract_Line_End_DateField;

		private bool contract_Line_End_DateFieldSpecified;

		private Asset_Book_Configuration_WWS_DataType depreciation_Schedule_DataField;

		private bool component_Lifecycles_are_DiscreteField;

		private bool component_Lifecycles_are_DiscreteFieldSpecified;

		private Component_Asset_WWS_DataType[] component_Asset_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Business_Asset_ID
		{
			get
			{
				return this.business_Asset_IDField;
			}
			set
			{
				this.business_Asset_IDField = value;
				this.RaisePropertyChanged("Business_Asset_ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Business_Asset_Number
		{
			get
			{
				return this.business_Asset_NumberField;
			}
			set
			{
				this.business_Asset_NumberField = value;
				this.RaisePropertyChanged("Business_Asset_Number");
			}
		}

		[XmlElement(Order = 2)]
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

		[XmlElement(Order = 3)]
		public string Business_Asset_Name
		{
			get
			{
				return this.business_Asset_NameField;
			}
			set
			{
				this.business_Asset_NameField = value;
				this.RaisePropertyChanged("Business_Asset_Name");
			}
		}

		[XmlElement(Order = 4)]
		public Item_DescriptorObjectType Item_Reference
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

		[XmlElement(Order = 5)]
		public string Business_Asset_Description
		{
			get
			{
				return this.business_Asset_DescriptionField;
			}
			set
			{
				this.business_Asset_DescriptionField = value;
				this.RaisePropertyChanged("Business_Asset_Description");
			}
		}

		[XmlElement(Order = 6)]
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

		[XmlElement(Order = 7)]
		public Accounting_TreatmentObjectType Accounting_Treatment_Reference
		{
			get
			{
				return this.accounting_Treatment_ReferenceField;
			}
			set
			{
				this.accounting_Treatment_ReferenceField = value;
				this.RaisePropertyChanged("Accounting_Treatment_Reference");
			}
		}

		[XmlElement(Order = 8)]
		public Acquisition_MethodObjectType Acquisition_Method_Reference
		{
			get
			{
				return this.acquisition_Method_ReferenceField;
			}
			set
			{
				this.acquisition_Method_ReferenceField = value;
				this.RaisePropertyChanged("Acquisition_Method_Reference");
			}
		}

		[XmlElement(Order = 9)]
		public decimal Acquisition_Cost
		{
			get
			{
				return this.acquisition_CostField;
			}
			set
			{
				this.acquisition_CostField = value;
				this.RaisePropertyChanged("Acquisition_Cost");
			}
		}

		[XmlIgnore]
		public bool Acquisition_CostSpecified
		{
			get
			{
				return this.acquisition_CostFieldSpecified;
			}
			set
			{
				this.acquisition_CostFieldSpecified = value;
				this.RaisePropertyChanged("Acquisition_CostSpecified");
			}
		}

		[XmlElement(Order = 10)]
		public decimal Residual_Value
		{
			get
			{
				return this.residual_ValueField;
			}
			set
			{
				this.residual_ValueField = value;
				this.RaisePropertyChanged("Residual_Value");
			}
		}

		[XmlIgnore]
		public bool Residual_ValueSpecified
		{
			get
			{
				return this.residual_ValueFieldSpecified;
			}
			set
			{
				this.residual_ValueFieldSpecified = value;
				this.RaisePropertyChanged("Residual_ValueSpecified");
			}
		}

		[XmlElement(Order = 11)]
		public decimal Fair_Market_Value
		{
			get
			{
				return this.fair_Market_ValueField;
			}
			set
			{
				this.fair_Market_ValueField = value;
				this.RaisePropertyChanged("Fair_Market_Value");
			}
		}

		[XmlIgnore]
		public bool Fair_Market_ValueSpecified
		{
			get
			{
				return this.fair_Market_ValueFieldSpecified;
			}
			set
			{
				this.fair_Market_ValueFieldSpecified = value;
				this.RaisePropertyChanged("Fair_Market_ValueSpecified");
			}
		}

		[XmlElement(Order = 12)]
		public decimal Quantity
		{
			get
			{
				return this.quantityField;
			}
			set
			{
				this.quantityField = value;
				this.RaisePropertyChanged("Quantity");
			}
		}

		[XmlIgnore]
		public bool QuantitySpecified
		{
			get
			{
				return this.quantityFieldSpecified;
			}
			set
			{
				this.quantityFieldSpecified = value;
				this.RaisePropertyChanged("QuantitySpecified");
			}
		}

		[XmlElement("Worktags_Reference", Order = 13)]
		public Accounting_WorktagObjectType[] Worktags_Reference
		{
			get
			{
				return this.worktags_ReferenceField;
			}
			set
			{
				this.worktags_ReferenceField = value;
				this.RaisePropertyChanged("Worktags_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 14)]
		public DateTime Date_Acquired
		{
			get
			{
				return this.date_AcquiredField;
			}
			set
			{
				this.date_AcquiredField = value;
				this.RaisePropertyChanged("Date_Acquired");
			}
		}

		[XmlElement(DataType = "date", Order = 15)]
		public DateTime Date_Placed_in_Service
		{
			get
			{
				return this.date_Placed_in_ServiceField;
			}
			set
			{
				this.date_Placed_in_ServiceField = value;
				this.RaisePropertyChanged("Date_Placed_in_Service");
			}
		}

		[XmlIgnore]
		public bool Date_Placed_in_ServiceSpecified
		{
			get
			{
				return this.date_Placed_in_ServiceFieldSpecified;
			}
			set
			{
				this.date_Placed_in_ServiceFieldSpecified = value;
				this.RaisePropertyChanged("Date_Placed_in_ServiceSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 16)]
		public DateTime Last_Issue_Date
		{
			get
			{
				return this.last_Issue_DateField;
			}
			set
			{
				this.last_Issue_DateField = value;
				this.RaisePropertyChanged("Last_Issue_Date");
			}
		}

		[XmlIgnore]
		public bool Last_Issue_DateSpecified
		{
			get
			{
				return this.last_Issue_DateFieldSpecified;
			}
			set
			{
				this.last_Issue_DateFieldSpecified = value;
				this.RaisePropertyChanged("Last_Issue_DateSpecified");
			}
		}

		[XmlElement(Order = 17)]
		public Worker_iData_ReferenceType Issued_to_Worker_Reference
		{
			get
			{
				return this.issued_to_Worker_ReferenceField;
			}
			set
			{
				this.issued_to_Worker_ReferenceField = value;
				this.RaisePropertyChanged("Issued_to_Worker_Reference");
			}
		}

		[XmlElement(Order = 18)]
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

		[XmlElement(Order = 19)]
		public string Asset_Identifier
		{
			get
			{
				return this.asset_IdentifierField;
			}
			set
			{
				this.asset_IdentifierField = value;
				this.RaisePropertyChanged("Asset_Identifier");
			}
		}

		[XmlElement(Order = 20)]
		public string Serial_Number
		{
			get
			{
				return this.serial_NumberField;
			}
			set
			{
				this.serial_NumberField = value;
				this.RaisePropertyChanged("Serial_Number");
			}
		}

		[XmlElement(Order = 21)]
		public string Manufacturer
		{
			get
			{
				return this.manufacturerField;
			}
			set
			{
				this.manufacturerField = value;
				this.RaisePropertyChanged("Manufacturer");
			}
		}

		[XmlElement(Order = 22)]
		public Asset_ClassObjectType Asset_Class_Reference
		{
			get
			{
				return this.asset_Class_ReferenceField;
			}
			set
			{
				this.asset_Class_ReferenceField = value;
				this.RaisePropertyChanged("Asset_Class_Reference");
			}
		}

		[XmlElement(Order = 23)]
		public Asset_TypeObjectType Asset_Type_Reference
		{
			get
			{
				return this.asset_Type_ReferenceField;
			}
			set
			{
				this.asset_Type_ReferenceField = value;
				this.RaisePropertyChanged("Asset_Type_Reference");
			}
		}

		[XmlElement(Order = 24)]
		public decimal Business_Use_Percentage
		{
			get
			{
				return this.business_Use_PercentageField;
			}
			set
			{
				this.business_Use_PercentageField = value;
				this.RaisePropertyChanged("Business_Use_Percentage");
			}
		}

		[XmlIgnore]
		public bool Business_Use_PercentageSpecified
		{
			get
			{
				return this.business_Use_PercentageFieldSpecified;
			}
			set
			{
				this.business_Use_PercentageFieldSpecified = value;
				this.RaisePropertyChanged("Business_Use_PercentageSpecified");
			}
		}

		[XmlElement("Related_Assets_Reference", Order = 25)]
		public InstanceObjectType[] Related_Assets_Reference
		{
			get
			{
				return this.related_Assets_ReferenceField;
			}
			set
			{
				this.related_Assets_ReferenceField = value;
				this.RaisePropertyChanged("Related_Assets_Reference");
			}
		}

		[XmlElement(Order = 26)]
		public string PO_Number
		{
			get
			{
				return this.pO_NumberField;
			}
			set
			{
				this.pO_NumberField = value;
				this.RaisePropertyChanged("PO_Number");
			}
		}

		[XmlElement(Order = 27)]
		public string Receipt_Number
		{
			get
			{
				return this.receipt_NumberField;
			}
			set
			{
				this.receipt_NumberField = value;
				this.RaisePropertyChanged("Receipt_Number");
			}
		}

		[XmlElement(Order = 28)]
		public string Supplier_Invoice_Number
		{
			get
			{
				return this.supplier_Invoice_NumberField;
			}
			set
			{
				this.supplier_Invoice_NumberField = value;
				this.RaisePropertyChanged("Supplier_Invoice_Number");
			}
		}

		[XmlElement(Order = 29)]
		public string Project_Number
		{
			get
			{
				return this.project_NumberField;
			}
			set
			{
				this.project_NumberField = value;
				this.RaisePropertyChanged("Project_Number");
			}
		}

		[XmlElement(Order = 30)]
		public string Contract_Number
		{
			get
			{
				return this.contract_NumberField;
			}
			set
			{
				this.contract_NumberField = value;
				this.RaisePropertyChanged("Contract_Number");
			}
		}

		[XmlElement(DataType = "date", Order = 31)]
		public DateTime Contract_Line_Start_Date
		{
			get
			{
				return this.contract_Line_Start_DateField;
			}
			set
			{
				this.contract_Line_Start_DateField = value;
				this.RaisePropertyChanged("Contract_Line_Start_Date");
			}
		}

		[XmlIgnore]
		public bool Contract_Line_Start_DateSpecified
		{
			get
			{
				return this.contract_Line_Start_DateFieldSpecified;
			}
			set
			{
				this.contract_Line_Start_DateFieldSpecified = value;
				this.RaisePropertyChanged("Contract_Line_Start_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 32)]
		public DateTime Contract_Line_End_Date
		{
			get
			{
				return this.contract_Line_End_DateField;
			}
			set
			{
				this.contract_Line_End_DateField = value;
				this.RaisePropertyChanged("Contract_Line_End_Date");
			}
		}

		[XmlIgnore]
		public bool Contract_Line_End_DateSpecified
		{
			get
			{
				return this.contract_Line_End_DateFieldSpecified;
			}
			set
			{
				this.contract_Line_End_DateFieldSpecified = value;
				this.RaisePropertyChanged("Contract_Line_End_DateSpecified");
			}
		}

		[XmlElement(Order = 33)]
		public Asset_Book_Configuration_WWS_DataType Depreciation_Schedule_Data
		{
			get
			{
				return this.depreciation_Schedule_DataField;
			}
			set
			{
				this.depreciation_Schedule_DataField = value;
				this.RaisePropertyChanged("Depreciation_Schedule_Data");
			}
		}

		[XmlElement(Order = 34)]
		public bool Component_Lifecycles_are_Discrete
		{
			get
			{
				return this.component_Lifecycles_are_DiscreteField;
			}
			set
			{
				this.component_Lifecycles_are_DiscreteField = value;
				this.RaisePropertyChanged("Component_Lifecycles_are_Discrete");
			}
		}

		[XmlIgnore]
		public bool Component_Lifecycles_are_DiscreteSpecified
		{
			get
			{
				return this.component_Lifecycles_are_DiscreteFieldSpecified;
			}
			set
			{
				this.component_Lifecycles_are_DiscreteFieldSpecified = value;
				this.RaisePropertyChanged("Component_Lifecycles_are_DiscreteSpecified");
			}
		}

		[XmlElement("Component_Asset_Data", Order = 35)]
		public Component_Asset_WWS_DataType[] Component_Asset_Data
		{
			get
			{
				return this.component_Asset_DataField;
			}
			set
			{
				this.component_Asset_DataField = value;
				this.RaisePropertyChanged("Component_Asset_Data");
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
