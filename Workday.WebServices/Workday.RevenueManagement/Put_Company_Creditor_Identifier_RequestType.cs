using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Put_Company_Creditor_Identifier_RequestType : INotifyPropertyChanged
	{
		private Creditor_IdentifierObjectType creditor_Identifier_ReferenceField;

		private Business_Form_LayoutObjectType company_Mandate_Business_Form_Layout_ReferenceField;

		private Business_Form_LayoutObjectType company_Mandate_Prenotification_Business_Form_Layout_ReferenceField;

		private Company_Creditor_Identifier_WS_Detail_DataType[] company_Creditor_Identifier_WS_Detail_DataField;

		private bool add_OnlyField;

		private bool add_OnlyFieldSpecified;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Creditor_IdentifierObjectType Creditor_Identifier_Reference
		{
			get
			{
				return this.creditor_Identifier_ReferenceField;
			}
			set
			{
				this.creditor_Identifier_ReferenceField = value;
				this.RaisePropertyChanged("Creditor_Identifier_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Business_Form_LayoutObjectType Company_Mandate_Business_Form_Layout_Reference
		{
			get
			{
				return this.company_Mandate_Business_Form_Layout_ReferenceField;
			}
			set
			{
				this.company_Mandate_Business_Form_Layout_ReferenceField = value;
				this.RaisePropertyChanged("Company_Mandate_Business_Form_Layout_Reference");
			}
		}

		[XmlElement("Company_Mandate_Pre-notification_Business_Form_Layout_Reference", Order = 2)]
		public Business_Form_LayoutObjectType Company_Mandate_Prenotification_Business_Form_Layout_Reference
		{
			get
			{
				return this.company_Mandate_Prenotification_Business_Form_Layout_ReferenceField;
			}
			set
			{
				this.company_Mandate_Prenotification_Business_Form_Layout_ReferenceField = value;
				this.RaisePropertyChanged("Company_Mandate_Prenotification_Business_Form_Layout_Reference");
			}
		}

		[XmlElement("Company_Creditor_Identifier_WS_Detail_Data", Order = 3)]
		public Company_Creditor_Identifier_WS_Detail_DataType[] Company_Creditor_Identifier_WS_Detail_Data
		{
			get
			{
				return this.company_Creditor_Identifier_WS_Detail_DataField;
			}
			set
			{
				this.company_Creditor_Identifier_WS_Detail_DataField = value;
				this.RaisePropertyChanged("Company_Creditor_Identifier_WS_Detail_Data");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public bool Add_Only
		{
			get
			{
				return this.add_OnlyField;
			}
			set
			{
				this.add_OnlyField = value;
				this.RaisePropertyChanged("Add_Only");
			}
		}

		[XmlIgnore]
		public bool Add_OnlySpecified
		{
			get
			{
				return this.add_OnlyFieldSpecified;
			}
			set
			{
				this.add_OnlyFieldSpecified = value;
				this.RaisePropertyChanged("Add_OnlySpecified");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public string version
		{
			get
			{
				return this.versionField;
			}
			set
			{
				this.versionField = value;
				this.RaisePropertyChanged("version");
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
