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
	public class Attachment_Data_WWSType : INotifyPropertyChanged
	{
		private string file_IDField;

		private byte[] fileField;

		private string fileNameField;

		private string commentsField;

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
