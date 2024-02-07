using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.Payroll
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Successor_Employer_DataType : INotifyPropertyChanged
	{
		private Company_Relationship_TypeObjectType successor_Employer_Type_ReferenceField;

		private DateTime acquisition_or_Merger_DateField;

		private DateTime payroll_Processing_Begin_DateField;

		private CompanyObjectType successor_Company_ReferenceField;

		private CompanyObjectType[] predecessor_Company_ReferenceField;

		private Withholding_Order_TypeObjectType[] withholding_Order_Type_ReferenceField;

		private Payroll_Tax_AuthorityObjectType[] tax_Authorities_not_Recognizing_Predecessor_Payments_ReferenceField;

		private string idField;

		private string federal_Tax_IDField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Company_Relationship_TypeObjectType Successor_Employer_Type_Reference
		{
			get
			{
				return this.successor_Employer_Type_ReferenceField;
			}
			set
			{
				this.successor_Employer_Type_ReferenceField = value;
				this.RaisePropertyChanged("Successor_Employer_Type_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 1)]
		public DateTime Acquisition_or_Merger_Date
		{
			get
			{
				return this.acquisition_or_Merger_DateField;
			}
			set
			{
				this.acquisition_or_Merger_DateField = value;
				this.RaisePropertyChanged("Acquisition_or_Merger_Date");
			}
		}

		[XmlElement(DataType = "date", Order = 2)]
		public DateTime Payroll_Processing_Begin_Date
		{
			get
			{
				return this.payroll_Processing_Begin_DateField;
			}
			set
			{
				this.payroll_Processing_Begin_DateField = value;
				this.RaisePropertyChanged("Payroll_Processing_Begin_Date");
			}
		}

		[XmlElement(Order = 3)]
		public CompanyObjectType Successor_Company_Reference
		{
			get
			{
				return this.successor_Company_ReferenceField;
			}
			set
			{
				this.successor_Company_ReferenceField = value;
				this.RaisePropertyChanged("Successor_Company_Reference");
			}
		}

		[XmlElement("Predecessor_Company_Reference", Order = 4)]
		public CompanyObjectType[] Predecessor_Company_Reference
		{
			get
			{
				return this.predecessor_Company_ReferenceField;
			}
			set
			{
				this.predecessor_Company_ReferenceField = value;
				this.RaisePropertyChanged("Predecessor_Company_Reference");
			}
		}

		[XmlElement("Withholding_Order_Type_Reference", Order = 5)]
		public Withholding_Order_TypeObjectType[] Withholding_Order_Type_Reference
		{
			get
			{
				return this.withholding_Order_Type_ReferenceField;
			}
			set
			{
				this.withholding_Order_Type_ReferenceField = value;
				this.RaisePropertyChanged("Withholding_Order_Type_Reference");
			}
		}

		[XmlElement("Tax_Authorities_not_Recognizing_Predecessor_Payments_Reference", Order = 6)]
		public Payroll_Tax_AuthorityObjectType[] Tax_Authorities_not_Recognizing_Predecessor_Payments_Reference
		{
			get
			{
				return this.tax_Authorities_not_Recognizing_Predecessor_Payments_ReferenceField;
			}
			set
			{
				this.tax_Authorities_not_Recognizing_Predecessor_Payments_ReferenceField = value;
				this.RaisePropertyChanged("Tax_Authorities_not_Recognizing_Predecessor_Payments_Reference");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
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

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public string Federal_Tax_ID
		{
			get
			{
				return this.federal_Tax_IDField;
			}
			set
			{
				this.federal_Tax_IDField = value;
				this.RaisePropertyChanged("Federal_Tax_ID");
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
