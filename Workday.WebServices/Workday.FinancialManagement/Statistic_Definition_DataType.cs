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
	public class Statistic_Definition_DataType : INotifyPropertyChanged
	{
		private string statistic_Definition_IDField;

		private string statistic_Definition_NameField;

		private string statistic_Definition_DescriptionField;

		private Fiscal_ScheduleObjectType fiscal_Schedule_ReferenceField;

		private Accounting_Worktag_TypeObjectType[] required_Dimensions_ReferenceField;

		private Accounting_Worktag_TypeObjectType[] optional_Dimensions_ReferenceField;

		private Financial_Entry_TypeObjectType[] ledger_Budget_Structure_ReferenceField;

		private bool statistic_Definition_Requires_CompanyField;

		private bool statistic_Definition_Requires_CompanyFieldSpecified;

		private Statistic_TypeObjectType statistic_Type_ReferenceField;

		private bool inactiveField;

		private bool inactiveFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Statistic_Definition_ID
		{
			get
			{
				return this.statistic_Definition_IDField;
			}
			set
			{
				this.statistic_Definition_IDField = value;
				this.RaisePropertyChanged("Statistic_Definition_ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Statistic_Definition_Name
		{
			get
			{
				return this.statistic_Definition_NameField;
			}
			set
			{
				this.statistic_Definition_NameField = value;
				this.RaisePropertyChanged("Statistic_Definition_Name");
			}
		}

		[XmlElement(Order = 2)]
		public string Statistic_Definition_Description
		{
			get
			{
				return this.statistic_Definition_DescriptionField;
			}
			set
			{
				this.statistic_Definition_DescriptionField = value;
				this.RaisePropertyChanged("Statistic_Definition_Description");
			}
		}

		[XmlElement(Order = 3)]
		public Fiscal_ScheduleObjectType Fiscal_Schedule_Reference
		{
			get
			{
				return this.fiscal_Schedule_ReferenceField;
			}
			set
			{
				this.fiscal_Schedule_ReferenceField = value;
				this.RaisePropertyChanged("Fiscal_Schedule_Reference");
			}
		}

		[XmlElement("Required_Dimensions_Reference", Order = 4)]
		public Accounting_Worktag_TypeObjectType[] Required_Dimensions_Reference
		{
			get
			{
				return this.required_Dimensions_ReferenceField;
			}
			set
			{
				this.required_Dimensions_ReferenceField = value;
				this.RaisePropertyChanged("Required_Dimensions_Reference");
			}
		}

		[XmlElement("Optional_Dimensions_Reference", Order = 5)]
		public Accounting_Worktag_TypeObjectType[] Optional_Dimensions_Reference
		{
			get
			{
				return this.optional_Dimensions_ReferenceField;
			}
			set
			{
				this.optional_Dimensions_ReferenceField = value;
				this.RaisePropertyChanged("Optional_Dimensions_Reference");
			}
		}

		[XmlElement("Ledger_Budget_Structure_Reference", Order = 6)]
		public Financial_Entry_TypeObjectType[] Ledger_Budget_Structure_Reference
		{
			get
			{
				return this.ledger_Budget_Structure_ReferenceField;
			}
			set
			{
				this.ledger_Budget_Structure_ReferenceField = value;
				this.RaisePropertyChanged("Ledger_Budget_Structure_Reference");
			}
		}

		[XmlElement(Order = 7)]
		public bool Statistic_Definition_Requires_Company
		{
			get
			{
				return this.statistic_Definition_Requires_CompanyField;
			}
			set
			{
				this.statistic_Definition_Requires_CompanyField = value;
				this.RaisePropertyChanged("Statistic_Definition_Requires_Company");
			}
		}

		[XmlIgnore]
		public bool Statistic_Definition_Requires_CompanySpecified
		{
			get
			{
				return this.statistic_Definition_Requires_CompanyFieldSpecified;
			}
			set
			{
				this.statistic_Definition_Requires_CompanyFieldSpecified = value;
				this.RaisePropertyChanged("Statistic_Definition_Requires_CompanySpecified");
			}
		}

		[XmlElement(Order = 8)]
		public Statistic_TypeObjectType Statistic_Type_Reference
		{
			get
			{
				return this.statistic_Type_ReferenceField;
			}
			set
			{
				this.statistic_Type_ReferenceField = value;
				this.RaisePropertyChanged("Statistic_Type_Reference");
			}
		}

		[XmlElement(Order = 9)]
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
