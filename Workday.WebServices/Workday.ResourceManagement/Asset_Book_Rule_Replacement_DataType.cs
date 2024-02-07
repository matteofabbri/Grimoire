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
	public class Asset_Book_Rule_Replacement_DataType : INotifyPropertyChanged
	{
		private string idField;

		private string asset_Book_Rule_OrderField;

		private Spend_Category_or_HierarchyObjectType[] spend_Category_or_Hierarchy_ReferenceField;

		private Asset_ClassObjectType[] asset_Class_ReferenceField;

		private Asset_TypeObjectType[] asset_Type_ReferenceField;

		private OrganizationObjectType[] company_ReferenceField;

		private CurrencyObjectType currency_ReferenceField;

		private decimal greater_Than_AmountField;

		private bool greater_Than_AmountFieldSpecified;

		private Business_Asset_Amount_BasisObjectType amount_Basis_ReferenceField;

		private Accounting_TreatmentObjectType accounting_Treatment_ReferenceField;

		private Depreciation_ProfileObjectType depreciation_Profile_ReferenceField;

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
		public string Asset_Book_Rule_Order
		{
			get
			{
				return this.asset_Book_Rule_OrderField;
			}
			set
			{
				this.asset_Book_Rule_OrderField = value;
				this.RaisePropertyChanged("Asset_Book_Rule_Order");
			}
		}

		[XmlElement("Spend_Category_or_Hierarchy_Reference", Order = 2)]
		public Spend_Category_or_HierarchyObjectType[] Spend_Category_or_Hierarchy_Reference
		{
			get
			{
				return this.spend_Category_or_Hierarchy_ReferenceField;
			}
			set
			{
				this.spend_Category_or_Hierarchy_ReferenceField = value;
				this.RaisePropertyChanged("Spend_Category_or_Hierarchy_Reference");
			}
		}

		[XmlElement("Asset_Class_Reference", Order = 3)]
		public Asset_ClassObjectType[] Asset_Class_Reference
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

		[XmlElement("Asset_Type_Reference", Order = 4)]
		public Asset_TypeObjectType[] Asset_Type_Reference
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

		[XmlElement("Company_Reference", Order = 5)]
		public OrganizationObjectType[] Company_Reference
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

		[XmlElement(Order = 6)]
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

		[XmlElement(Order = 7)]
		public decimal Greater_Than_Amount
		{
			get
			{
				return this.greater_Than_AmountField;
			}
			set
			{
				this.greater_Than_AmountField = value;
				this.RaisePropertyChanged("Greater_Than_Amount");
			}
		}

		[XmlIgnore]
		public bool Greater_Than_AmountSpecified
		{
			get
			{
				return this.greater_Than_AmountFieldSpecified;
			}
			set
			{
				this.greater_Than_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Greater_Than_AmountSpecified");
			}
		}

		[XmlElement(Order = 8)]
		public Business_Asset_Amount_BasisObjectType Amount_Basis_Reference
		{
			get
			{
				return this.amount_Basis_ReferenceField;
			}
			set
			{
				this.amount_Basis_ReferenceField = value;
				this.RaisePropertyChanged("Amount_Basis_Reference");
			}
		}

		[XmlElement(Order = 9)]
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

		[XmlElement(Order = 10)]
		public Depreciation_ProfileObjectType Depreciation_Profile_Reference
		{
			get
			{
				return this.depreciation_Profile_ReferenceField;
			}
			set
			{
				this.depreciation_Profile_ReferenceField = value;
				this.RaisePropertyChanged("Depreciation_Profile_Reference");
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
