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
	public class Asset_Acquisition_WWS_DataType : INotifyPropertyChanged
	{
		private decimal acquisition_CostField;

		private bool acquisition_CostFieldSpecified;

		private DateTime acquisition_DateField;

		private bool acquisition_DateFieldSpecified;

		private Acquisition_MethodObjectType acquisition_Method_ReferenceField;

		private string pO_NumberField;

		private string receipt_NumberField;

		private string supplier_Invoice_NumberField;

		private decimal residual_Value_At_AcquisitionField;

		private bool residual_Value_At_AcquisitionFieldSpecified;

		private Supplier_Invoice_Line_AbstractObjectType[] supplier_Invoice_Line_ReferenceField;

		private Unique_IdentifierObjectType receipt_Line_ReferenceField;

		private Business_AssetObjectType transfer_From_Business_Asset_ReferenceField;

		private Audited_Accounting_WorktagObjectType[] worktag_ReferenceField;

		private string project_NumberField;

		private string contract_NumberField;

		private DateTime contract_Line_Start_DateField;

		private bool contract_Line_Start_DateFieldSpecified;

		private DateTime contract_Line_End_DateField;

		private bool contract_Line_End_DateFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
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

		[XmlElement(DataType = "date", Order = 1)]
		public DateTime Acquisition_Date
		{
			get
			{
				return this.acquisition_DateField;
			}
			set
			{
				this.acquisition_DateField = value;
				this.RaisePropertyChanged("Acquisition_Date");
			}
		}

		[XmlIgnore]
		public bool Acquisition_DateSpecified
		{
			get
			{
				return this.acquisition_DateFieldSpecified;
			}
			set
			{
				this.acquisition_DateFieldSpecified = value;
				this.RaisePropertyChanged("Acquisition_DateSpecified");
			}
		}

		[XmlElement(Order = 2)]
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

		[XmlElement(Order = 3)]
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

		[XmlElement(Order = 4)]
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

		[XmlElement(Order = 5)]
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

		[XmlElement(Order = 6)]
		public decimal Residual_Value_At_Acquisition
		{
			get
			{
				return this.residual_Value_At_AcquisitionField;
			}
			set
			{
				this.residual_Value_At_AcquisitionField = value;
				this.RaisePropertyChanged("Residual_Value_At_Acquisition");
			}
		}

		[XmlIgnore]
		public bool Residual_Value_At_AcquisitionSpecified
		{
			get
			{
				return this.residual_Value_At_AcquisitionFieldSpecified;
			}
			set
			{
				this.residual_Value_At_AcquisitionFieldSpecified = value;
				this.RaisePropertyChanged("Residual_Value_At_AcquisitionSpecified");
			}
		}

		[XmlElement("Supplier_Invoice_Line_Reference", Order = 7)]
		public Supplier_Invoice_Line_AbstractObjectType[] Supplier_Invoice_Line_Reference
		{
			get
			{
				return this.supplier_Invoice_Line_ReferenceField;
			}
			set
			{
				this.supplier_Invoice_Line_ReferenceField = value;
				this.RaisePropertyChanged("Supplier_Invoice_Line_Reference");
			}
		}

		[XmlElement(Order = 8)]
		public Unique_IdentifierObjectType Receipt_Line_Reference
		{
			get
			{
				return this.receipt_Line_ReferenceField;
			}
			set
			{
				this.receipt_Line_ReferenceField = value;
				this.RaisePropertyChanged("Receipt_Line_Reference");
			}
		}

		[XmlElement(Order = 9)]
		public Business_AssetObjectType Transfer_From_Business_Asset_Reference
		{
			get
			{
				return this.transfer_From_Business_Asset_ReferenceField;
			}
			set
			{
				this.transfer_From_Business_Asset_ReferenceField = value;
				this.RaisePropertyChanged("Transfer_From_Business_Asset_Reference");
			}
		}

		[XmlElement("Worktag_Reference", Order = 10)]
		public Audited_Accounting_WorktagObjectType[] Worktag_Reference
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

		[XmlElement(Order = 11)]
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

		[XmlElement(Order = 12)]
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

		[XmlElement(DataType = "date", Order = 13)]
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

		[XmlElement(DataType = "date", Order = 14)]
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
