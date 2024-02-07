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
	public class Worker_Document_Details_DataType : INotifyPropertyChanged
	{
		private Document_Category__All_ObjectType document_Category_ReferenceField;

		private string filenameField;

		private string commentField;

		private byte[] fileField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Document_Category__All_ObjectType Document_Category_Reference
		{
			get
			{
				return this.document_Category_ReferenceField;
			}
			set
			{
				this.document_Category_ReferenceField = value;
				this.RaisePropertyChanged("Document_Category_Reference");
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
