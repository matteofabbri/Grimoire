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
	public class Committee_Meeting_Agenda_Item_Attachment_DataType : INotifyPropertyChanged
	{
		private Committee_Meeting_Agenda_Item_AttachmentObjectType attachment_ReferenceField;

		private string idField;

		private string filenameField;

		private string commentField;

		private byte[] fileField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Committee_Meeting_Agenda_Item_AttachmentObjectType Attachment_Reference
		{
			get
			{
				return this.attachment_ReferenceField;
			}
			set
			{
				this.attachment_ReferenceField = value;
				this.RaisePropertyChanged("Attachment_Reference");
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

		[XmlElement(Order = 3)]
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

		[XmlElement(DataType = "base64Binary", Order = 4)]
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
