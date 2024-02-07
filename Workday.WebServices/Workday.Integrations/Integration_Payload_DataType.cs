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
	public class Integration_Payload_DataType : INotifyPropertyChanged
	{
		private PGP_Encryption_Settings_DataType pGP_Encryption_Settings_DataField;

		private bool compressedField;

		private bool compressedFieldSpecified;

		private bool use_Improved_CompressionField;

		private bool use_Improved_CompressionFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public PGP_Encryption_Settings_DataType PGP_Encryption_Settings_Data
		{
			get
			{
				return this.pGP_Encryption_Settings_DataField;
			}
			set
			{
				this.pGP_Encryption_Settings_DataField = value;
				this.RaisePropertyChanged("PGP_Encryption_Settings_Data");
			}
		}

		[XmlElement(Order = 1)]
		public bool Compressed
		{
			get
			{
				return this.compressedField;
			}
			set
			{
				this.compressedField = value;
				this.RaisePropertyChanged("Compressed");
			}
		}

		[XmlIgnore]
		public bool CompressedSpecified
		{
			get
			{
				return this.compressedFieldSpecified;
			}
			set
			{
				this.compressedFieldSpecified = value;
				this.RaisePropertyChanged("CompressedSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public bool Use_Improved_Compression
		{
			get
			{
				return this.use_Improved_CompressionField;
			}
			set
			{
				this.use_Improved_CompressionField = value;
				this.RaisePropertyChanged("Use_Improved_Compression");
			}
		}

		[XmlIgnore]
		public bool Use_Improved_CompressionSpecified
		{
			get
			{
				return this.use_Improved_CompressionFieldSpecified;
			}
			set
			{
				this.use_Improved_CompressionFieldSpecified = value;
				this.RaisePropertyChanged("Use_Improved_CompressionSpecified");
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
