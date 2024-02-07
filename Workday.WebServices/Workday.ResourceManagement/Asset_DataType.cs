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
	public class Asset_DataType : INotifyPropertyChanged
	{
		private string asset_Reference_IDField;

		private string asset_IDField;

		private CompanyObjectType company_ReferenceField;

		private CurrencyObjectType currency_ReferenceField;

		private string asset_NameField;

		private string asset_DescriptionField;

		private Document_StatusObjectType asset_Status_ReferenceField;

		private Spend_CategoryObjectType spend_Category_ReferenceField;

		private decimal total_Asset_CostField;

		private bool total_Asset_CostFieldSpecified;

		private decimal quantityField;

		private bool quantityFieldSpecified;

		private decimal quantity_AvailableField;

		private bool quantity_AvailableFieldSpecified;

		private decimal residual_ValueField;

		private bool residual_ValueFieldSpecified;

		private DateTime date_Placed_In_ServiceField;

		private bool date_Placed_In_ServiceFieldSpecified;

		private Accounting_TreatmentObjectType accounting_Treatment_ReferenceField;

		private string asset_IdentifierField;

		private string serial_NumberField;

		private string manufacturerField;

		private Asset_ClassObjectType asset_Class_ReferenceField;

		private Asset_TypeObjectType asset_Type_ReferenceField;

		private decimal business_Use_PercentageField;

		private bool business_Use_PercentageFieldSpecified;

		private Business_AssetObjectType[] related_Asset_ReferenceField;

		private bool event_In_ProgressField;

		private bool event_In_ProgressFieldSpecified;

		private Asset_Share_Response_DataType[] asset_Share_ReferenceField;

		private Asset_Acquisition_WWS_DataType[] acquisition_DataField;

		private Asset_Custodian_WWS_DataType[] custodian_DataField;

		private Asset_Components_WWS_DataType[] asset_Component_DataField;

		private Asset_Depreciation_WWS_DataType[] depreciation_DataField;

		private Asset_Disposal_WWS_DataType[] disposal_DataField;

		private Asset_Depreciation_Detail_Line_DataType[] depreciation_Detail_DataField;

		private Asset_Reinstatement_WWS_DataType[] reinstatement_DataField;

		private Asset_Intercompany_Transfer_WWS_DataType[] intercompany_Transfer_DataField;

		private Asset_Impairment_WWS_DataType[] impairment_DataField;

		private Asset_In_Service_Schedule_WWS_DataType[] in_Service_Schedule_DataField;

		private Asset_Cost_Adjustment_WWS_DataType[] cost_Adjustment_DataField;

		private Asset_Reclassification_WWS_DataType[] reclassification_DataField;

		private Asset_Removal_WWS_DataType[] removal_DataField;

		private Financials_Attachment_DataType[] attachment_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Asset_Reference_ID
		{
			get
			{
				return this.asset_Reference_IDField;
			}
			set
			{
				this.asset_Reference_IDField = value;
				this.RaisePropertyChanged("Asset_Reference_ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Asset_ID
		{
			get
			{
				return this.asset_IDField;
			}
			set
			{
				this.asset_IDField = value;
				this.RaisePropertyChanged("Asset_ID");
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

		[XmlElement(Order = 4)]
		public string Asset_Name
		{
			get
			{
				return this.asset_NameField;
			}
			set
			{
				this.asset_NameField = value;
				this.RaisePropertyChanged("Asset_Name");
			}
		}

		[XmlElement(Order = 5)]
		public string Asset_Description
		{
			get
			{
				return this.asset_DescriptionField;
			}
			set
			{
				this.asset_DescriptionField = value;
				this.RaisePropertyChanged("Asset_Description");
			}
		}

		[XmlElement(Order = 6)]
		public Document_StatusObjectType Asset_Status_Reference
		{
			get
			{
				return this.asset_Status_ReferenceField;
			}
			set
			{
				this.asset_Status_ReferenceField = value;
				this.RaisePropertyChanged("Asset_Status_Reference");
			}
		}

		[XmlElement(Order = 7)]
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

		[XmlElement(Order = 8)]
		public decimal Total_Asset_Cost
		{
			get
			{
				return this.total_Asset_CostField;
			}
			set
			{
				this.total_Asset_CostField = value;
				this.RaisePropertyChanged("Total_Asset_Cost");
			}
		}

		[XmlIgnore]
		public bool Total_Asset_CostSpecified
		{
			get
			{
				return this.total_Asset_CostFieldSpecified;
			}
			set
			{
				this.total_Asset_CostFieldSpecified = value;
				this.RaisePropertyChanged("Total_Asset_CostSpecified");
			}
		}

		[XmlElement(Order = 9)]
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

		[XmlElement(Order = 10)]
		public decimal Quantity_Available
		{
			get
			{
				return this.quantity_AvailableField;
			}
			set
			{
				this.quantity_AvailableField = value;
				this.RaisePropertyChanged("Quantity_Available");
			}
		}

		[XmlIgnore]
		public bool Quantity_AvailableSpecified
		{
			get
			{
				return this.quantity_AvailableFieldSpecified;
			}
			set
			{
				this.quantity_AvailableFieldSpecified = value;
				this.RaisePropertyChanged("Quantity_AvailableSpecified");
			}
		}

		[XmlElement(Order = 11)]
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

		[XmlElement(DataType = "date", Order = 12)]
		public DateTime Date_Placed_In_Service
		{
			get
			{
				return this.date_Placed_In_ServiceField;
			}
			set
			{
				this.date_Placed_In_ServiceField = value;
				this.RaisePropertyChanged("Date_Placed_In_Service");
			}
		}

		[XmlIgnore]
		public bool Date_Placed_In_ServiceSpecified
		{
			get
			{
				return this.date_Placed_In_ServiceFieldSpecified;
			}
			set
			{
				this.date_Placed_In_ServiceFieldSpecified = value;
				this.RaisePropertyChanged("Date_Placed_In_ServiceSpecified");
			}
		}

		[XmlElement(Order = 13)]
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

		[XmlElement(Order = 14)]
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

		[XmlElement(Order = 15)]
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

		[XmlElement(Order = 16)]
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

		[XmlElement(Order = 17)]
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

		[XmlElement(Order = 18)]
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

		[XmlElement(Order = 19)]
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

		[XmlElement("Related_Asset_Reference", Order = 20)]
		public Business_AssetObjectType[] Related_Asset_Reference
		{
			get
			{
				return this.related_Asset_ReferenceField;
			}
			set
			{
				this.related_Asset_ReferenceField = value;
				this.RaisePropertyChanged("Related_Asset_Reference");
			}
		}

		[XmlElement(Order = 21)]
		public bool Event_In_Progress
		{
			get
			{
				return this.event_In_ProgressField;
			}
			set
			{
				this.event_In_ProgressField = value;
				this.RaisePropertyChanged("Event_In_Progress");
			}
		}

		[XmlIgnore]
		public bool Event_In_ProgressSpecified
		{
			get
			{
				return this.event_In_ProgressFieldSpecified;
			}
			set
			{
				this.event_In_ProgressFieldSpecified = value;
				this.RaisePropertyChanged("Event_In_ProgressSpecified");
			}
		}

		[XmlElement("Asset_Share_Reference", Order = 22)]
		public Asset_Share_Response_DataType[] Asset_Share_Reference
		{
			get
			{
				return this.asset_Share_ReferenceField;
			}
			set
			{
				this.asset_Share_ReferenceField = value;
				this.RaisePropertyChanged("Asset_Share_Reference");
			}
		}

		[XmlElement("Acquisition_Data", Order = 23)]
		public Asset_Acquisition_WWS_DataType[] Acquisition_Data
		{
			get
			{
				return this.acquisition_DataField;
			}
			set
			{
				this.acquisition_DataField = value;
				this.RaisePropertyChanged("Acquisition_Data");
			}
		}

		[XmlElement("Custodian_Data", Order = 24)]
		public Asset_Custodian_WWS_DataType[] Custodian_Data
		{
			get
			{
				return this.custodian_DataField;
			}
			set
			{
				this.custodian_DataField = value;
				this.RaisePropertyChanged("Custodian_Data");
			}
		}

		[XmlElement("Asset_Component_Data", Order = 25)]
		public Asset_Components_WWS_DataType[] Asset_Component_Data
		{
			get
			{
				return this.asset_Component_DataField;
			}
			set
			{
				this.asset_Component_DataField = value;
				this.RaisePropertyChanged("Asset_Component_Data");
			}
		}

		[XmlElement("Depreciation_Data", Order = 26)]
		public Asset_Depreciation_WWS_DataType[] Depreciation_Data
		{
			get
			{
				return this.depreciation_DataField;
			}
			set
			{
				this.depreciation_DataField = value;
				this.RaisePropertyChanged("Depreciation_Data");
			}
		}

		[XmlElement("Disposal_Data", Order = 27)]
		public Asset_Disposal_WWS_DataType[] Disposal_Data
		{
			get
			{
				return this.disposal_DataField;
			}
			set
			{
				this.disposal_DataField = value;
				this.RaisePropertyChanged("Disposal_Data");
			}
		}

		[XmlArray(Order = 28), XmlArrayItem("Depreciation_Detail_Line_Data", typeof(Asset_Depreciation_Detail_Line_DataType), IsNullable = false)]
		public Asset_Depreciation_Detail_Line_DataType[] Depreciation_Detail_Data
		{
			get
			{
				return this.depreciation_Detail_DataField;
			}
			set
			{
				this.depreciation_Detail_DataField = value;
				this.RaisePropertyChanged("Depreciation_Detail_Data");
			}
		}

		[XmlElement("Reinstatement_Data", Order = 29)]
		public Asset_Reinstatement_WWS_DataType[] Reinstatement_Data
		{
			get
			{
				return this.reinstatement_DataField;
			}
			set
			{
				this.reinstatement_DataField = value;
				this.RaisePropertyChanged("Reinstatement_Data");
			}
		}

		[XmlElement("Intercompany_Transfer_Data", Order = 30)]
		public Asset_Intercompany_Transfer_WWS_DataType[] Intercompany_Transfer_Data
		{
			get
			{
				return this.intercompany_Transfer_DataField;
			}
			set
			{
				this.intercompany_Transfer_DataField = value;
				this.RaisePropertyChanged("Intercompany_Transfer_Data");
			}
		}

		[XmlElement("Impairment_Data", Order = 31)]
		public Asset_Impairment_WWS_DataType[] Impairment_Data
		{
			get
			{
				return this.impairment_DataField;
			}
			set
			{
				this.impairment_DataField = value;
				this.RaisePropertyChanged("Impairment_Data");
			}
		}

		[XmlElement("In_Service_Schedule_Data", Order = 32)]
		public Asset_In_Service_Schedule_WWS_DataType[] In_Service_Schedule_Data
		{
			get
			{
				return this.in_Service_Schedule_DataField;
			}
			set
			{
				this.in_Service_Schedule_DataField = value;
				this.RaisePropertyChanged("In_Service_Schedule_Data");
			}
		}

		[XmlElement("Cost_Adjustment_Data", Order = 33)]
		public Asset_Cost_Adjustment_WWS_DataType[] Cost_Adjustment_Data
		{
			get
			{
				return this.cost_Adjustment_DataField;
			}
			set
			{
				this.cost_Adjustment_DataField = value;
				this.RaisePropertyChanged("Cost_Adjustment_Data");
			}
		}

		[XmlElement("Reclassification_Data", Order = 34)]
		public Asset_Reclassification_WWS_DataType[] Reclassification_Data
		{
			get
			{
				return this.reclassification_DataField;
			}
			set
			{
				this.reclassification_DataField = value;
				this.RaisePropertyChanged("Reclassification_Data");
			}
		}

		[XmlElement("Removal_Data", Order = 35)]
		public Asset_Removal_WWS_DataType[] Removal_Data
		{
			get
			{
				return this.removal_DataField;
			}
			set
			{
				this.removal_DataField = value;
				this.RaisePropertyChanged("Removal_Data");
			}
		}

		[XmlElement("Attachment_Data", Order = 36)]
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
