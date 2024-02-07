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
	public class PGP_Encryption_Settings_DataType : INotifyPropertyChanged
	{
		private PGP_Public_KeyObjectType certificate_ReferenceField;

		private bool ascii_ArmoredField;

		private bool ascii_ArmoredFieldSpecified;

		private bool containing_Integrity_CheckField;

		private bool containing_Integrity_CheckFieldSpecified;

		private string decrypted_FilenameField;

		private bool pGP_26x_CompatibleField;

		private bool pGP_26x_CompatibleFieldSpecified;

		private PGP_Private_Key_PairObjectType digitally_Sign_Key_Pair_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public PGP_Public_KeyObjectType Certificate_Reference
		{
			get
			{
				return this.certificate_ReferenceField;
			}
			set
			{
				this.certificate_ReferenceField = value;
				this.RaisePropertyChanged("Certificate_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public bool Ascii_Armored
		{
			get
			{
				return this.ascii_ArmoredField;
			}
			set
			{
				this.ascii_ArmoredField = value;
				this.RaisePropertyChanged("Ascii_Armored");
			}
		}

		[XmlIgnore]
		public bool Ascii_ArmoredSpecified
		{
			get
			{
				return this.ascii_ArmoredFieldSpecified;
			}
			set
			{
				this.ascii_ArmoredFieldSpecified = value;
				this.RaisePropertyChanged("Ascii_ArmoredSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public bool Containing_Integrity_Check
		{
			get
			{
				return this.containing_Integrity_CheckField;
			}
			set
			{
				this.containing_Integrity_CheckField = value;
				this.RaisePropertyChanged("Containing_Integrity_Check");
			}
		}

		[XmlIgnore]
		public bool Containing_Integrity_CheckSpecified
		{
			get
			{
				return this.containing_Integrity_CheckFieldSpecified;
			}
			set
			{
				this.containing_Integrity_CheckFieldSpecified = value;
				this.RaisePropertyChanged("Containing_Integrity_CheckSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public string Decrypted_Filename
		{
			get
			{
				return this.decrypted_FilenameField;
			}
			set
			{
				this.decrypted_FilenameField = value;
				this.RaisePropertyChanged("Decrypted_Filename");
			}
		}

		[XmlElement("PGP_2.6x_Compatible", Order = 4)]
		public bool PGP_26x_Compatible
		{
			get
			{
				return this.pGP_26x_CompatibleField;
			}
			set
			{
				this.pGP_26x_CompatibleField = value;
				this.RaisePropertyChanged("PGP_26x_Compatible");
			}
		}

		[XmlIgnore]
		public bool PGP_26x_CompatibleSpecified
		{
			get
			{
				return this.pGP_26x_CompatibleFieldSpecified;
			}
			set
			{
				this.pGP_26x_CompatibleFieldSpecified = value;
				this.RaisePropertyChanged("PGP_26x_CompatibleSpecified");
			}
		}

		[XmlElement(Order = 5)]
		public PGP_Private_Key_PairObjectType Digitally_Sign_Key_Pair_Reference
		{
			get
			{
				return this.digitally_Sign_Key_Pair_ReferenceField;
			}
			set
			{
				this.digitally_Sign_Key_Pair_ReferenceField = value;
				this.RaisePropertyChanged("Digitally_Sign_Key_Pair_Reference");
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
