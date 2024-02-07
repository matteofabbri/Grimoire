using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.CashManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Business_Entity_Contact_DataType : INotifyPropertyChanged
	{
		private bool primary_Bill_To_ContactField;

		private bool primary_Bill_To_ContactFieldSpecified;

		private bool default_Bill_To_ContactField;

		private bool default_Bill_To_ContactFieldSpecified;

		private string business_Entity_Contact_IDField;

		private object itemField;

		private Business_Entity_Contact_Personal_DataType business_Entity_Contact_Personal_DataField;

		private IDType[] external_ID_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public bool Primary_Bill_To_Contact
		{
			get
			{
				return this.primary_Bill_To_ContactField;
			}
			set
			{
				this.primary_Bill_To_ContactField = value;
				this.RaisePropertyChanged("Primary_Bill_To_Contact");
			}
		}

		[XmlIgnore]
		public bool Primary_Bill_To_ContactSpecified
		{
			get
			{
				return this.primary_Bill_To_ContactFieldSpecified;
			}
			set
			{
				this.primary_Bill_To_ContactFieldSpecified = value;
				this.RaisePropertyChanged("Primary_Bill_To_ContactSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public bool Default_Bill_To_Contact
		{
			get
			{
				return this.default_Bill_To_ContactField;
			}
			set
			{
				this.default_Bill_To_ContactField = value;
				this.RaisePropertyChanged("Default_Bill_To_Contact");
			}
		}

		[XmlIgnore]
		public bool Default_Bill_To_ContactSpecified
		{
			get
			{
				return this.default_Bill_To_ContactFieldSpecified;
			}
			set
			{
				this.default_Bill_To_ContactFieldSpecified = value;
				this.RaisePropertyChanged("Default_Bill_To_ContactSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public string Business_Entity_Contact_ID
		{
			get
			{
				return this.business_Entity_Contact_IDField;
			}
			set
			{
				this.business_Entity_Contact_IDField = value;
				this.RaisePropertyChanged("Business_Entity_Contact_ID");
			}
		}

		[XmlElement("Billable_Entity_Reference", typeof(Billable_EntityObjectType), Order = 3), XmlElement("Financial_Institution_Reference", typeof(Financial_InstitutionObjectType), Order = 3), XmlElement("Supplier_Reference", typeof(SupplierObjectType), Order = 3), XmlElement("Tax_Authority_Reference", typeof(Tax_AuthorityObjectType), Order = 3)]
		public object Item
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

		[XmlElement(Order = 4)]
		public Business_Entity_Contact_Personal_DataType Business_Entity_Contact_Personal_Data
		{
			get
			{
				return this.business_Entity_Contact_Personal_DataField;
			}
			set
			{
				this.business_Entity_Contact_Personal_DataField = value;
				this.RaisePropertyChanged("Business_Entity_Contact_Personal_Data");
			}
		}

		[XmlArray(Order = 5), XmlArrayItem("ID", IsNullable = false)]
		public IDType[] External_ID_Data
		{
			get
			{
				return this.external_ID_DataField;
			}
			set
			{
				this.external_ID_DataField = value;
				this.RaisePropertyChanged("External_ID_Data");
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
