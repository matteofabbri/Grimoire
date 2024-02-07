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
	public class Supplier_Contract_Request_CriteriaType : INotifyPropertyChanged
	{
		private OrganizationObjectType[] company_ReferenceField;

		private Resource_ProviderObjectType[] supplier_ReferenceField;

		private string contract_NameField;

		private Supplier_Contract_TypeObjectType[] contract_Type_ReferenceField;

		private DateTime contract_Start_Date_On_or_AfterField;

		private bool contract_Start_Date_On_or_AfterFieldSpecified;

		private DateTime contract_Start_Date_On_or_BeforeField;

		private bool contract_Start_Date_On_or_BeforeFieldSpecified;

		private DateTime contract_End_Date_On_or_AfterField;

		private bool contract_End_Date_On_or_AfterFieldSpecified;

		private DateTime contract_End_Date_On_or_BeforeField;

		private bool contract_End_Date_On_or_BeforeFieldSpecified;

		private string supplier_Reference_NumberField;

		private WorkerObjectType[] created_By_Worker_ReferenceField;

		private bool contract_On_HoldField;

		private bool contract_On_HoldFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Company_Reference", Order = 0)]
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

		[XmlElement("Contract_Type_Reference", Order = 3)]
		public Supplier_Contract_TypeObjectType[] Contract_Type_Reference
		{
			get
			{
				return this.contract_Type_ReferenceField;
			}
			set
			{
				this.contract_Type_ReferenceField = value;
				this.RaisePropertyChanged("Contract_Type_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 4)]
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

		[XmlElement(DataType = "date", Order = 5)]
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

		[XmlElement(DataType = "date", Order = 6)]
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

		[XmlElement(DataType = "date", Order = 7)]
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

		[XmlElement(Order = 8)]
		public string Supplier_Reference_Number
		{
			get
			{
				return this.supplier_Reference_NumberField;
			}
			set
			{
				this.supplier_Reference_NumberField = value;
				this.RaisePropertyChanged("Supplier_Reference_Number");
			}
		}

		[XmlElement("Created_By_Worker_Reference", Order = 9)]
		public WorkerObjectType[] Created_By_Worker_Reference
		{
			get
			{
				return this.created_By_Worker_ReferenceField;
			}
			set
			{
				this.created_By_Worker_ReferenceField = value;
				this.RaisePropertyChanged("Created_By_Worker_Reference");
			}
		}

		[XmlElement(Order = 10)]
		public bool Contract_On_Hold
		{
			get
			{
				return this.contract_On_HoldField;
			}
			set
			{
				this.contract_On_HoldField = value;
				this.RaisePropertyChanged("Contract_On_Hold");
			}
		}

		[XmlIgnore]
		public bool Contract_On_HoldSpecified
		{
			get
			{
				return this.contract_On_HoldFieldSpecified;
			}
			set
			{
				this.contract_On_HoldFieldSpecified = value;
				this.RaisePropertyChanged("Contract_On_HoldSpecified");
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
