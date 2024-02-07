using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.StudentRecords
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Business_Process_Attachment_DataType : INotifyPropertyChanged
	{
		private string file_NameField;

		private string event_Attachment_DescriptionField;

		private Event_Attachment_CategoryObjectType event_Attachment_Category_ReferenceField;

		private byte[] fileField;

		private string content_TypeField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string File_Name
		{
			get
			{
				return this.file_NameField;
			}
			set
			{
				this.file_NameField = value;
				this.RaisePropertyChanged("File_Name");
			}
		}

		[XmlElement(Order = 1)]
		public string Event_Attachment_Description
		{
			get
			{
				return this.event_Attachment_DescriptionField;
			}
			set
			{
				this.event_Attachment_DescriptionField = value;
				this.RaisePropertyChanged("Event_Attachment_Description");
			}
		}

		[XmlElement(Order = 2)]
		public Event_Attachment_CategoryObjectType Event_Attachment_Category_Reference
		{
			get
			{
				return this.event_Attachment_Category_ReferenceField;
			}
			set
			{
				this.event_Attachment_Category_ReferenceField = value;
				this.RaisePropertyChanged("Event_Attachment_Category_Reference");
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
