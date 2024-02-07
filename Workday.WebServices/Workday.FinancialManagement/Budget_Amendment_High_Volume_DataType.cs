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
	public class Budget_Amendment_High_Volume_DataType : INotifyPropertyChanged
	{
		private string idField;

		private bool submitField;

		private bool submitFieldSpecified;

		private CompanyObjectType company_ReferenceField;

		private Budget_StructureObjectType budget_Structure_ReferenceField;

		private Budget_SourceObjectType budget_Name_ReferenceField;

		private decimal fiscal_YearField;

		private DateTime amendment_DateField;

		private string descriptionField;

		private Budget_Amendment_TypeObjectType budget_Amendment_Type_ReferenceField;

		private bool balanced_AmendmentField;

		private bool balanced_AmendmentFieldSpecified;

		private Budget_Amendment_Entry_High_Volume_DataType[] amendment_Entry_DataField;

		private Financials_Attachment_DataType[] attachment_DataField;

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
		public Budget_StructureObjectType Budget_Structure_Reference
		{
			get
			{
				return this.budget_Structure_ReferenceField;
			}
			set
			{
				this.budget_Structure_ReferenceField = value;
				this.RaisePropertyChanged("Budget_Structure_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public Budget_SourceObjectType Budget_Name_Reference
		{
			get
			{
				return this.budget_Name_ReferenceField;
			}
			set
			{
				this.budget_Name_ReferenceField = value;
				this.RaisePropertyChanged("Budget_Name_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public decimal Fiscal_Year
		{
			get
			{
				return this.fiscal_YearField;
			}
			set
			{
				this.fiscal_YearField = value;
				this.RaisePropertyChanged("Fiscal_Year");
			}
		}

		[XmlElement(DataType = "date", Order = 6)]
		public DateTime Amendment_Date
		{
			get
			{
				return this.amendment_DateField;
			}
			set
			{
				this.amendment_DateField = value;
				this.RaisePropertyChanged("Amendment_Date");
			}
		}

		[XmlElement(Order = 7)]
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

		[XmlElement(Order = 8)]
		public Budget_Amendment_TypeObjectType Budget_Amendment_Type_Reference
		{
			get
			{
				return this.budget_Amendment_Type_ReferenceField;
			}
			set
			{
				this.budget_Amendment_Type_ReferenceField = value;
				this.RaisePropertyChanged("Budget_Amendment_Type_Reference");
			}
		}

		[XmlElement(Order = 9)]
		public bool Balanced_Amendment
		{
			get
			{
				return this.balanced_AmendmentField;
			}
			set
			{
				this.balanced_AmendmentField = value;
				this.RaisePropertyChanged("Balanced_Amendment");
			}
		}

		[XmlIgnore]
		public bool Balanced_AmendmentSpecified
		{
			get
			{
				return this.balanced_AmendmentFieldSpecified;
			}
			set
			{
				this.balanced_AmendmentFieldSpecified = value;
				this.RaisePropertyChanged("Balanced_AmendmentSpecified");
			}
		}

		[XmlElement("Amendment_Entry_Data", Order = 10)]
		public Budget_Amendment_Entry_High_Volume_DataType[] Amendment_Entry_Data
		{
			get
			{
				return this.amendment_Entry_DataField;
			}
			set
			{
				this.amendment_Entry_DataField = value;
				this.RaisePropertyChanged("Amendment_Entry_Data");
			}
		}

		[XmlElement("Attachment_Data", Order = 11)]
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
