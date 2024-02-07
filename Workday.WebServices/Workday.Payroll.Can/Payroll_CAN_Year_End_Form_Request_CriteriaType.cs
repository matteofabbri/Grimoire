using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Payroll.Can
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Payroll_CAN_Year_End_Form_Request_CriteriaType : INotifyPropertyChanged
	{
		private Payroll_Payee_Tax_Report_TypeObjectType payroll_Year_End_Form_Type_ReferenceField;

		private decimal tax_YearField;

		private WorkerObjectType[] worker_ReferenceField;

		private CompanyObjectType[] company_ReferenceField;

		private string itemField;

		private ItemChoiceType itemElementNameField;

		private Unique_IdentifierObjectType payroll_Year_End_Form_Subtype_ReferenceField;

		private DateTime completed_MomentField;

		private bool completed_MomentFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Payroll_Payee_Tax_Report_TypeObjectType Payroll_Year_End_Form_Type_Reference
		{
			get
			{
				return this.payroll_Year_End_Form_Type_ReferenceField;
			}
			set
			{
				this.payroll_Year_End_Form_Type_ReferenceField = value;
				this.RaisePropertyChanged("Payroll_Year_End_Form_Type_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public decimal Tax_Year
		{
			get
			{
				return this.tax_YearField;
			}
			set
			{
				this.tax_YearField = value;
				this.RaisePropertyChanged("Tax_Year");
			}
		}

		[XmlElement("Worker_Reference", Order = 2)]
		public WorkerObjectType[] Worker_Reference
		{
			get
			{
				return this.worker_ReferenceField;
			}
			set
			{
				this.worker_ReferenceField = value;
				this.RaisePropertyChanged("Worker_Reference");
			}
		}

		[XmlElement("Company_Reference", Order = 3)]
		public CompanyObjectType[] Company_Reference
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

		[XmlChoiceIdentifier("ItemElementName"), XmlElement("Identification_Number", typeof(string), Order = 4), XmlElement("Payroll_Account_Number", typeof(string), Order = 4)]
		public string Item
		{
			get
			{
				return this.itemField;
			}
			set
			{
				this.itemField = value;
				this.RaisePropertyChanged("Item");
			}
		}

		[XmlElement(Order = 5), XmlIgnore]
		public ItemChoiceType ItemElementName
		{
			get
			{
				return this.itemElementNameField;
			}
			set
			{
				this.itemElementNameField = value;
				this.RaisePropertyChanged("ItemElementName");
			}
		}

		[XmlElement(Order = 6)]
		public Unique_IdentifierObjectType Payroll_Year_End_Form_Subtype_Reference
		{
			get
			{
				return this.payroll_Year_End_Form_Subtype_ReferenceField;
			}
			set
			{
				this.payroll_Year_End_Form_Subtype_ReferenceField = value;
				this.RaisePropertyChanged("Payroll_Year_End_Form_Subtype_Reference");
			}
		}

		[XmlElement(Order = 7)]
		public DateTime Completed_Moment
		{
			get
			{
				return this.completed_MomentField;
			}
			set
			{
				this.completed_MomentField = value;
				this.RaisePropertyChanged("Completed_Moment");
			}
		}

		[XmlIgnore]
		public bool Completed_MomentSpecified
		{
			get
			{
				return this.completed_MomentFieldSpecified;
			}
			set
			{
				this.completed_MomentFieldSpecified = value;
				this.RaisePropertyChanged("Completed_MomentSpecified");
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
