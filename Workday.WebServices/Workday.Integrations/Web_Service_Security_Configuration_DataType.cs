using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Integrations
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Web_Service_Security_Configuration_DataType : INotifyPropertyChanged
	{
		private bool enable_x509_Token_AuthenticationField;

		private bool enable_x509_Token_AuthenticationFieldSpecified;

		private x509_Public_KeyObjectType x509_Public_Key_ReferenceField;

		private bool enable_SAML_AuthenticationField;

		private bool enable_SAML_AuthenticationFieldSpecified;

		private string sAML_IssuerField;

		private x509_Public_KeyObjectType identity_Provider_Public_Key_ReferenceField;

		private x509_Public_KeyObjectType holderofKey_Public_Key_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public bool Enable_x509_Token_Authentication
		{
			get
			{
				return this.enable_x509_Token_AuthenticationField;
			}
			set
			{
				this.enable_x509_Token_AuthenticationField = value;
				this.RaisePropertyChanged("Enable_x509_Token_Authentication");
			}
		}

		[XmlIgnore]
		public bool Enable_x509_Token_AuthenticationSpecified
		{
			get
			{
				return this.enable_x509_Token_AuthenticationFieldSpecified;
			}
			set
			{
				this.enable_x509_Token_AuthenticationFieldSpecified = value;
				this.RaisePropertyChanged("Enable_x509_Token_AuthenticationSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public x509_Public_KeyObjectType X509_Public_Key_Reference
		{
			get
			{
				return this.x509_Public_Key_ReferenceField;
			}
			set
			{
				this.x509_Public_Key_ReferenceField = value;
				this.RaisePropertyChanged("X509_Public_Key_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public bool Enable_SAML_Authentication
		{
			get
			{
				return this.enable_SAML_AuthenticationField;
			}
			set
			{
				this.enable_SAML_AuthenticationField = value;
				this.RaisePropertyChanged("Enable_SAML_Authentication");
			}
		}

		[XmlIgnore]
		public bool Enable_SAML_AuthenticationSpecified
		{
			get
			{
				return this.enable_SAML_AuthenticationFieldSpecified;
			}
			set
			{
				this.enable_SAML_AuthenticationFieldSpecified = value;
				this.RaisePropertyChanged("Enable_SAML_AuthenticationSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public string SAML_Issuer
		{
			get
			{
				return this.sAML_IssuerField;
			}
			set
			{
				this.sAML_IssuerField = value;
				this.RaisePropertyChanged("SAML_Issuer");
			}
		}

		[XmlElement(Order = 4)]
		public x509_Public_KeyObjectType Identity_Provider_Public_Key_Reference
		{
			get
			{
				return this.identity_Provider_Public_Key_ReferenceField;
			}
			set
			{
				this.identity_Provider_Public_Key_ReferenceField = value;
				this.RaisePropertyChanged("Identity_Provider_Public_Key_Reference");
			}
		}

		[XmlElement("Holder-of-Key_Public_Key_Reference", Order = 5)]
		public x509_Public_KeyObjectType HolderofKey_Public_Key_Reference
		{
			get
			{
				return this.holderofKey_Public_Key_ReferenceField;
			}
			set
			{
				this.holderofKey_Public_Key_ReferenceField = value;
				this.RaisePropertyChanged("HolderofKey_Public_Key_Reference");
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
