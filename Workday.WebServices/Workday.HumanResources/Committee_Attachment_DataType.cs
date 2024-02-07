using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.HumanResources
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Committee_Attachment_DataType : INotifyPropertyChanged
	{
		private Committee_AttachmentObjectType committee_Attachment_ReferenceField;

		private string idField;

		private string fileNameField;

		private byte[] fileField;

		private string commentField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Committee_AttachmentObjectType Committee_Attachment_Reference
		{
			get
			{
				return this.committee_Attachment_ReferenceField;
			}
			set
			{
				this.committee_Attachment_ReferenceField = value;
				this.RaisePropertyChanged("Committee_Attachment_Reference");
			}
		}

		[XmlElement(Order = 1)]
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

		[XmlElement(Order = 2)]
		public string FileName
		{
			get
			{
				return this.fileNameField;
			}
			set
			{
				this.fileNameField = value;
				this.RaisePropertyChanged("FileName");
			}
		}

		[XmlElement(DataType = "base64Binary", Order = 3)]
		public byte[] File
		{
			get
			{
				return this.fileField;
			}
			set
			{
				this.fileField = value;
				this.RaisePropertyChanged("File");
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
