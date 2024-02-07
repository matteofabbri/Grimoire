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
	public class Donor_DataType : INotifyPropertyChanged
	{
		private string donor_IDField;

		private string donor_NameField;

		private object itemField;

		private Donor_TypeObjectType donor_Type_ReferenceField;

		private Contact_Information_DataType contact_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Donor_ID
		{
			get
			{
				return this.donor_IDField;
			}
			set
			{
				this.donor_IDField = value;
				this.RaisePropertyChanged("Donor_ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Donor_Name
		{
			get
			{
				return this.donor_NameField;
			}
			set
			{
				this.donor_NameField = value;
				this.RaisePropertyChanged("Donor_Name");
			}
		}

		[XmlElement("Customer_Reference", typeof(CustomerObjectType), Order = 2), XmlElement("Financial_Institution_Reference", typeof(Financial_InstitutionObjectType), Order = 2), XmlElement("Investor_Reference", typeof(InvestorObjectType), Order = 2), XmlElement("Sponsor_Reference", typeof(SponsorObjectType), Order = 2), XmlElement("Tax_Authority_Reference", typeof(Tax_AuthorityObjectType), Order = 2)]
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

		[XmlElement(Order = 3)]
		public Donor_TypeObjectType Donor_Type_Reference
		{
			get
			{
				return this.donor_Type_ReferenceField;
			}
			set
			{
				this.donor_Type_ReferenceField = value;
				this.RaisePropertyChanged("Donor_Type_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public Contact_Information_DataType Contact_Data
		{
			get
			{
				return this.contact_DataField;
			}
			set
			{
				this.contact_DataField = value;
				this.RaisePropertyChanged("Contact_Data");
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
