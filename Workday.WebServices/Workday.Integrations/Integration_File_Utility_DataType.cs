using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Workday.Integrations;

namespace Workday.Integrations
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Integration_File_Utility_DataType : INotifyPropertyChanged
	{
		private string idField;

		private string filenameField;

		private Abstract_Sequence_Generator_DataType sequence_Generator_DataField;

		private Mime_TypeObjectType mime_Type_ReferenceField;

		private bool compressedField;

		private bool compressedFieldSpecified;

		private decimal document_Retention_PolicyField;

		private bool document_Retention_PolicyFieldSpecified;

		private PGP_Encryption_Settings_DataType pGP_Encryption_Settings_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
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

		[XmlElement(Order = 1)]
		public string Filename
		{
			get
			{
				return this.filenameField;
			}
			set
			{
				this.filenameField = value;
				this.RaisePropertyChanged("Filename");
			}
		}

		[XmlElement(Order = 2)]
		public Abstract_Sequence_Generator_DataType Sequence_Generator_Data
		{
			get
			{
				return this.sequence_Generator_DataField;
			}
			set
			{
				this.sequence_Generator_DataField = value;
				this.RaisePropertyChanged("Sequence_Generator_Data");
			}
		}

		[XmlElement(Order = 3)]
		public Mime_TypeObjectType Mime_Type_Reference
		{
			get
			{
				return this.mime_Type_ReferenceField;
			}
			set
			{
				this.mime_Type_ReferenceField = value;
				this.RaisePropertyChanged("Mime_Type_Reference");
			}
		}

		[XmlElement(Order = 4)]
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

		[XmlElement(Order = 5)]
		public decimal Document_Retention_Policy
		{
			get
			{
				return this.document_Retention_PolicyField;
			}
			set
			{
				this.document_Retention_PolicyField = value;
				this.RaisePropertyChanged("Document_Retention_Policy");
			}
		}

		[XmlIgnore]
		public bool Document_Retention_PolicySpecified
		{
			get
			{
				return this.document_Retention_PolicyFieldSpecified;
			}
			set
			{
				this.document_Retention_PolicyFieldSpecified = value;
				this.RaisePropertyChanged("Document_Retention_PolicySpecified");
			}
		}

		[XmlElement(Order = 6)]
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
