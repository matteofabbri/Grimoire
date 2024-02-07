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
	public class Integration_Repository_Document_DataType : INotifyPropertyChanged
	{
		private decimal file_SizeField;

		private bool file_SizeFieldSpecified;

		private object itemField;

		private Document_TypeObjectType document_Type_ReferenceField;

		private DateTime expiration_TimestampField;

		private System_AccountObjectType owner_ReferenceField;

		private Document_TagObjectType[] document_Tag_ReferenceField;

		private string[] custom_Document_TagField;

		private InstanceObjectType[] secured_Instance_ReferenceField;

		private string document_IDField;

		private string file_NameField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public decimal File_Size
		{
			get
			{
				return this.file_SizeField;
			}
			set
			{
				this.file_SizeField = value;
				this.RaisePropertyChanged("File_Size");
			}
		}

		[XmlIgnore]
		public bool File_SizeSpecified
		{
			get
			{
				return this.file_SizeFieldSpecified;
			}
			set
			{
				this.file_SizeFieldSpecified = value;
				this.RaisePropertyChanged("File_SizeSpecified");
			}
		}

		[XmlElement("Content_Type", typeof(string), Order = 1), XmlElement("Content_Type_Reference", typeof(Mime_TypeObjectType), Order = 1)]
		public object Item
		{
			get
			{
				return this.itemField;
			}
			set
			{
				this.itemField = value;
				this.RaisePropertyChanged("Item");
			}
		}

		[XmlElement(Order = 2)]
		public Document_TypeObjectType Document_Type_Reference
		{
			get
			{
				return this.document_Type_ReferenceField;
			}
			set
			{
				this.document_Type_ReferenceField = value;
				this.RaisePropertyChanged("Document_Type_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public DateTime Expiration_Timestamp
		{
			get
			{
				return this.expiration_TimestampField;
			}
			set
			{
				this.expiration_TimestampField = value;
				this.RaisePropertyChanged("Expiration_Timestamp");
			}
		}

		[XmlElement(Order = 4)]
		public System_AccountObjectType Owner_Reference
		{
			get
			{
				return this.owner_ReferenceField;
			}
			set
			{
				this.owner_ReferenceField = value;
				this.RaisePropertyChanged("Owner_Reference");
			}
		}

		[XmlElement("Document_Tag_Reference", Order = 5)]
		public Document_TagObjectType[] Document_Tag_Reference
		{
			get
			{
				return this.document_Tag_ReferenceField;
			}
			set
			{
				this.document_Tag_ReferenceField = value;
				this.RaisePropertyChanged("Document_Tag_Reference");
			}
		}

		[XmlElement("Custom_Document_Tag", Order = 6)]
		public string[] Custom_Document_Tag
		{
			get
			{
				return this.custom_Document_TagField;
			}
			set
			{
				this.custom_Document_TagField = value;
				this.RaisePropertyChanged("Custom_Document_Tag");
			}
		}

		[XmlElement("Secured_Instance_Reference", Order = 7)]
		public InstanceObjectType[] Secured_Instance_Reference
		{
			get
			{
				return this.secured_Instance_ReferenceField;
			}
			set
			{
				this.secured_Instance_ReferenceField = value;
				this.RaisePropertyChanged("Secured_Instance_Reference");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public string Document_ID
		{
			get
			{
				return this.document_IDField;
			}
			set
			{
				this.document_IDField = value;
				this.RaisePropertyChanged("Document_ID");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
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
