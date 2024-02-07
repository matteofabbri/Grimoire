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
	public class Company_Creditor_Identifier_WS_Detail_DataType : INotifyPropertyChanged
	{
		private string creditor_Identifier_Reference_IDField;

		private CompanyObjectType company_ReferenceField;

		private CountryObjectType country_ReferenceField;

		private Business_Form_LayoutObjectType mandate_Business_Form_Layout_ReferenceField;

		private Business_Form_LayoutObjectType mandate_Prenotification_Business_Form_Layout_ReferenceField;

		private string creditor_IdentificationField;

		private bool activeField;

		private bool activeFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Creditor_Identifier_Reference_ID
		{
			get
			{
				return this.creditor_Identifier_Reference_IDField;
			}
			set
			{
				this.creditor_Identifier_Reference_IDField = value;
				this.RaisePropertyChanged("Creditor_Identifier_Reference_ID");
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
		public CountryObjectType Country_Reference
		{
			get
			{
				return this.country_ReferenceField;
			}
			set
			{
				this.country_ReferenceField = value;
				this.RaisePropertyChanged("Country_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public Business_Form_LayoutObjectType Mandate_Business_Form_Layout_Reference
		{
			get
			{
				return this.mandate_Business_Form_Layout_ReferenceField;
			}
			set
			{
				this.mandate_Business_Form_Layout_ReferenceField = value;
				this.RaisePropertyChanged("Mandate_Business_Form_Layout_Reference");
			}
		}

		[XmlElement("Mandate_Pre-notification_Business_Form_Layout_Reference", Order = 4)]
		public Business_Form_LayoutObjectType Mandate_Prenotification_Business_Form_Layout_Reference
		{
			get
			{
				return this.mandate_Prenotification_Business_Form_Layout_ReferenceField;
			}
			set
			{
				this.mandate_Prenotification_Business_Form_Layout_ReferenceField = value;
				this.RaisePropertyChanged("Mandate_Prenotification_Business_Form_Layout_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public string Creditor_Identification
		{
			get
			{
				return this.creditor_IdentificationField;
			}
			set
			{
				this.creditor_IdentificationField = value;
				this.RaisePropertyChanged("Creditor_Identification");
			}
		}

		[XmlElement(Order = 6)]
		public bool Active
		{
			get
			{
				return this.activeField;
			}
			set
			{
				this.activeField = value;
				this.RaisePropertyChanged("Active");
			}
		}

		[XmlIgnore]
		public bool ActiveSpecified
		{
			get
			{
				return this.activeFieldSpecified;
			}
			set
			{
				this.activeFieldSpecified = value;
				this.RaisePropertyChanged("ActiveSpecified");
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
