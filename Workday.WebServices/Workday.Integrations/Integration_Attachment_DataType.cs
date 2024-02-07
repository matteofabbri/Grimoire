using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.Integrations
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Integration_Attachment_DataType : INotifyPropertyChanged
	{
		private string file_IDField;

		private byte[] file_ContentField;

		private Mime_TypeObjectType content_Type_ReferenceField;

		private string commentsField;

		private string content_TypeField;

		private string filenameField;

		private string encodingField;

		private bool compressedField;

		private bool compressedFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string File_ID
		{
			get
			{
				return this.file_IDField;
			}
			set
			{
				this.file_IDField = value;
				this.RaisePropertyChanged("File_ID");
			}
		}

		[XmlElement(DataType = "base64Binary", Order = 1)]
		public byte[] File_Content
		{
			get
			{
				return this.file_ContentField;
			}
			set
			{
				this.file_ContentField = value;
				this.RaisePropertyChanged("File_Content");
			}
		}

		[XmlElement(Order = 2)]
		public Mime_TypeObjectType Content_Type_Reference
		{
			get
			{
				return this.content_Type_ReferenceField;
			}
			set
			{
				this.content_Type_ReferenceField = value;
				this.RaisePropertyChanged("Content_Type_Reference");
			}
		}

		[XmlElement(Order = 3)]
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

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public string Content_Type
		{
			get
			{
				return this.content_TypeField;
			}
			set
			{
				this.content_TypeField = value;
				this.RaisePropertyChanged("Content_Type");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
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

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public string Encoding
		{
			get
			{
				return this.encodingField;
			}
			set
			{
				this.encodingField = value;
				this.RaisePropertyChanged("Encoding");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
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
