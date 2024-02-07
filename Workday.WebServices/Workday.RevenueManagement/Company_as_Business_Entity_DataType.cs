using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Company_as_Business_Entity_DataType : INotifyPropertyChanged
	{
		private string company_as_Business_Entity_IDField;

		private CompanyObjectType company_ReferenceField;

		private CustomerObjectType customer_ReferenceField;

		private SupplierObjectType supplier_ReferenceField;

		private string commentsField;

		private bool copy_WorktagsField;

		private bool copy_WorktagsFieldSpecified;

		private bool copy_Tax_FieldsField;

		private bool copy_Tax_FieldsFieldSpecified;

		private bool copy_AttachmentsField;

		private bool copy_AttachmentsFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Company_as_Business_Entity_ID
		{
			get
			{
				return this.company_as_Business_Entity_IDField;
			}
			set
			{
				this.company_as_Business_Entity_IDField = value;
				this.RaisePropertyChanged("Company_as_Business_Entity_ID");
			}
		}

		[XmlElement(Order = 1)]
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

		[XmlElement(Order = 2)]
		public CustomerObjectType Customer_Reference
		{
			get
			{
				return this.customer_ReferenceField;
			}
			set
			{
				this.customer_ReferenceField = value;
				this.RaisePropertyChanged("Customer_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public SupplierObjectType Supplier_Reference
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

		[XmlElement(Order = 4)]
		public string Comments
		{
			get
			{
				return this.commentsField;
			}
			set
			{
				this.commentsField = value;
				this.RaisePropertyChanged("Comments");
			}
		}

		[XmlElement(Order = 5)]
		public bool Copy_Worktags
		{
			get
			{
				return this.copy_WorktagsField;
			}
			set
			{
				this.copy_WorktagsField = value;
				this.RaisePropertyChanged("Copy_Worktags");
			}
		}

		[XmlIgnore]
		public bool Copy_WorktagsSpecified
		{
			get
			{
				return this.copy_WorktagsFieldSpecified;
			}
			set
			{
				this.copy_WorktagsFieldSpecified = value;
				this.RaisePropertyChanged("Copy_WorktagsSpecified");
			}
		}

		[XmlElement(Order = 6)]
		public bool Copy_Tax_Fields
		{
			get
			{
				return this.copy_Tax_FieldsField;
			}
			set
			{
				this.copy_Tax_FieldsField = value;
				this.RaisePropertyChanged("Copy_Tax_Fields");
			}
		}

		[XmlIgnore]
		public bool Copy_Tax_FieldsSpecified
		{
			get
			{
				return this.copy_Tax_FieldsFieldSpecified;
			}
			set
			{
				this.copy_Tax_FieldsFieldSpecified = value;
				this.RaisePropertyChanged("Copy_Tax_FieldsSpecified");
			}
		}

		[XmlElement(Order = 7)]
		public bool Copy_Attachments
		{
			get
			{
				return this.copy_AttachmentsField;
			}
			set
			{
				this.copy_AttachmentsField = value;
				this.RaisePropertyChanged("Copy_Attachments");
			}
		}

		[XmlIgnore]
		public bool Copy_AttachmentsSpecified
		{
			get
			{
				return this.copy_AttachmentsFieldSpecified;
			}
			set
			{
				this.copy_AttachmentsFieldSpecified = value;
				this.RaisePropertyChanged("Copy_AttachmentsSpecified");
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
