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
	public class Asset_Edit_DataType : INotifyPropertyChanged
	{
		private OrganizationObjectType company_ReferenceField;

		private string asset_IDField;

		private string asset_DescriptionField;

		private string asset_NameField;

		private decimal total_Asset_CostField;

		private bool total_Asset_CostFieldSpecified;

		private decimal total_QuantityField;

		private bool total_QuantityFieldSpecified;

		private Item_DescriptorObjectType item_ReferenceField;

		private string asset_IdentifierField;

		private string serial_NumberField;

		private Asset_ClassObjectType asset_Class_ReferenceField;

		private Asset_TypeObjectType asset_Type_ReferenceField;

		private string manufacturerField;

		private decimal business_Use_PercentageField;

		private bool business_Use_PercentageFieldSpecified;

		private Related_Asset_Replacement_DataType[] related_Asset_Replacement_DataField;

		private Financials_Attachment_DataType[] attachment_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public OrganizationObjectType Company_Reference
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

		[XmlElement(Order = 3)]
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

		[XmlElement(Order = 4)]
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

		[XmlElement(Order = 5)]
		public decimal Total_Quantity
		{
			get
			{
				return this.total_QuantityField;
			}
			set
			{
				this.total_QuantityField = value;
				this.RaisePropertyChanged("Total_Quantity");
			}
		}

		[XmlIgnore]
		public bool Total_QuantitySpecified
		{
			get
			{
				return this.total_QuantityFieldSpecified;
			}
			set
			{
				this.total_QuantityFieldSpecified = value;
				this.RaisePropertyChanged("Total_QuantitySpecified");
			}
		}

		[XmlElement(Order = 6)]
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

		[XmlElement(Order = 7)]
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

		[XmlElement(Order = 8)]
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

		[XmlElement(Order = 9)]
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

		[XmlElement(Order = 10)]
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

		[XmlElement(Order = 11)]
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

		[XmlElement(Order = 12)]
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

		[XmlElement("Related_Asset_Replacement_Data", Order = 13)]
		public Related_Asset_Replacement_DataType[] Related_Asset_Replacement_Data
		{
			get
			{
				return this.related_Asset_Replacement_DataField;
			}
			set
			{
				this.related_Asset_Replacement_DataField = value;
				this.RaisePropertyChanged("Related_Asset_Replacement_Data");
			}
		}

		[XmlElement("Attachment_Data", Order = 14)]
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
