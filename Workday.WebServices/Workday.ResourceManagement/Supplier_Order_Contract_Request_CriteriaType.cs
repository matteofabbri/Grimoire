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
	public class Supplier_Order_Contract_Request_CriteriaType : INotifyPropertyChanged
	{
		private OrganizationObjectType[] organization_ReferenceField;

		private Resource_ProviderObjectType[] supplier_ReferenceField;

		private string contract_NameField;

		private DateTime contract_Start_Date_On_or_AfterField;

		private bool contract_Start_Date_On_or_AfterFieldSpecified;

		private DateTime contract_Start_Date_On_or_BeforeField;

		private bool contract_Start_Date_On_or_BeforeFieldSpecified;

		private DateTime contract_End_Date_On_or_AfterField;

		private bool contract_End_Date_On_or_AfterFieldSpecified;

		private DateTime contract_End_Date_On_or_BeforeField;

		private bool contract_End_Date_On_or_BeforeFieldSpecified;

		private string supplier_Order_Contract_StatusField;

		private string supplier_Contract_Reference_NumberField;

		private WorkerObjectType[] buyer_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Organization_Reference", Order = 0)]
		public OrganizationObjectType[] Organization_Reference
		{
			get
			{
				return this.organization_ReferenceField;
			}
			set
			{
				this.organization_ReferenceField = value;
				this.RaisePropertyChanged("Organization_Reference");
			}
		}

		[XmlElement("Supplier_Reference", Order = 1)]
		public Resource_ProviderObjectType[] Supplier_Reference
		{
			get
			{
				return this.supplier_ReferenceField;
			}
			set
			{
				this.supplier_ReferenceField = value;
				this.RaisePropertyChanged("Supplier_Reference");
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

		[XmlElement(DataType = "date", Order = 3)]
		public DateTime Contract_Start_Date_On_or_After
		{
			get
			{
				return this.contract_Start_Date_On_or_AfterField;
			}
			set
			{
				this.contract_Start_Date_On_or_AfterField = value;
				this.RaisePropertyChanged("Contract_Start_Date_On_or_After");
			}
		}

		[XmlIgnore]
		public bool Contract_Start_Date_On_or_AfterSpecified
		{
			get
			{
				return this.contract_Start_Date_On_or_AfterFieldSpecified;
			}
			set
			{
				this.contract_Start_Date_On_or_AfterFieldSpecified = value;
				this.RaisePropertyChanged("Contract_Start_Date_On_or_AfterSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 4)]
		public DateTime Contract_Start_Date_On_or_Before
		{
			get
			{
				return this.contract_Start_Date_On_or_BeforeField;
			}
			set
			{
				this.contract_Start_Date_On_or_BeforeField = value;
				this.RaisePropertyChanged("Contract_Start_Date_On_or_Before");
			}
		}

		[XmlIgnore]
		public bool Contract_Start_Date_On_or_BeforeSpecified
		{
			get
			{
				return this.contract_Start_Date_On_or_BeforeFieldSpecified;
			}
			set
			{
				this.contract_Start_Date_On_or_BeforeFieldSpecified = value;
				this.RaisePropertyChanged("Contract_Start_Date_On_or_BeforeSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 5)]
		public DateTime Contract_End_Date_On_or_After
		{
			get
			{
				return this.contract_End_Date_On_or_AfterField;
			}
			set
			{
				this.contract_End_Date_On_or_AfterField = value;
				this.RaisePropertyChanged("Contract_End_Date_On_or_After");
			}
		}

		[XmlIgnore]
		public bool Contract_End_Date_On_or_AfterSpecified
		{
			get
			{
				return this.contract_End_Date_On_or_AfterFieldSpecified;
			}
			set
			{
				this.contract_End_Date_On_or_AfterFieldSpecified = value;
				this.RaisePropertyChanged("Contract_End_Date_On_or_AfterSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 6)]
		public DateTime Contract_End_Date_On_or_Before
		{
			get
			{
				return this.contract_End_Date_On_or_BeforeField;
			}
			set
			{
				this.contract_End_Date_On_or_BeforeField = value;
				this.RaisePropertyChanged("Contract_End_Date_On_or_Before");
			}
		}

		[XmlIgnore]
		public bool Contract_End_Date_On_or_BeforeSpecified
		{
			get
			{
				return this.contract_End_Date_On_or_BeforeFieldSpecified;
			}
			set
			{
				this.contract_End_Date_On_or_BeforeFieldSpecified = value;
				this.RaisePropertyChanged("Contract_End_Date_On_or_BeforeSpecified");
			}
		}

		[XmlElement(Order = 7)]
		public string Supplier_Order_Contract_Status
		{
			get
			{
				return this.supplier_Order_Contract_StatusField;
			}
			set
			{
				this.supplier_Order_Contract_StatusField = value;
				this.RaisePropertyChanged("Supplier_Order_Contract_Status");
			}
		}

		[XmlElement(Order = 8)]
		public string Supplier_Contract_Reference_Number
		{
			get
			{
				return this.supplier_Contract_Reference_NumberField;
			}
			set
			{
				this.supplier_Contract_Reference_NumberField = value;
				this.RaisePropertyChanged("Supplier_Contract_Reference_Number");
			}
		}

		[XmlElement("Buyer_Reference", Order = 9)]
		public WorkerObjectType[] Buyer_Reference
		{
			get
			{
				return this.buyer_ReferenceField;
			}
			set
			{
				this.buyer_ReferenceField = value;
				this.RaisePropertyChanged("Buyer_Reference");
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
