using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.StudentRecruiting
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Attachment_WWS_DataType : INotifyPropertyChanged
	{
		private string idField;

		private string filenameField;

		private byte[] file_ContentField;

		private Mime_TypeObjectType mime_Type_ReferenceField;

		private string commentField;

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

		[XmlElement(DataType = "base64Binary", Order = 2)]
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
		public string Comment
		{
			get
			{
				return this.commentField;
			}
			set
			{
				this.commentField = value;
				this.RaisePropertyChanged("Comment");
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
