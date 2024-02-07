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
	public class AS2_Settings_DataType : INotifyPropertyChanged
	{
		private string aS2_From_IDField;

		private string aS2_IDField;

		private x509_Public_KeyObjectType public_Key_for_Encryption_ReferenceField;

		private x509_Private_Key_PairObjectType private_Key_Pair_for_Signing_ReferenceField;

		private x509_Public_KeyObjectType public_Key_for_SSL_ReferenceField;

		private x509_Public_KeyObjectType public_Key_for_SSL_Accept_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string AS2_From_ID
		{
			get
			{
				return this.aS2_From_IDField;
			}
			set
			{
				this.aS2_From_IDField = value;
				this.RaisePropertyChanged("AS2_From_ID");
			}
		}

		[XmlElement(Order = 1)]
		public string AS2_ID
		{
			get
			{
				return this.aS2_IDField;
			}
			set
			{
				this.aS2_IDField = value;
				this.RaisePropertyChanged("AS2_ID");
			}
		}

		[XmlElement(Order = 2)]
		public x509_Public_KeyObjectType Public_Key_for_Encryption_Reference
		{
			get
			{
				return this.public_Key_for_Encryption_ReferenceField;
			}
			set
			{
				this.public_Key_for_Encryption_ReferenceField = value;
				this.RaisePropertyChanged("Public_Key_for_Encryption_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public x509_Private_Key_PairObjectType Private_Key_Pair_for_Signing_Reference
		{
			get
			{
				return this.private_Key_Pair_for_Signing_ReferenceField;
			}
			set
			{
				this.private_Key_Pair_for_Signing_ReferenceField = value;
				this.RaisePropertyChanged("Private_Key_Pair_for_Signing_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public x509_Public_KeyObjectType Public_Key_for_SSL_Reference
		{
			get
			{
				return this.public_Key_for_SSL_ReferenceField;
			}
			set
			{
				this.public_Key_for_SSL_ReferenceField = value;
				this.RaisePropertyChanged("Public_Key_for_SSL_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public x509_Public_KeyObjectType Public_Key_for_SSL_Accept_Reference
		{
			get
			{
				return this.public_Key_for_SSL_Accept_ReferenceField;
			}
			set
			{
				this.public_Key_for_SSL_Accept_ReferenceField = value;
				this.RaisePropertyChanged("Public_Key_for_SSL_Accept_Reference");
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
