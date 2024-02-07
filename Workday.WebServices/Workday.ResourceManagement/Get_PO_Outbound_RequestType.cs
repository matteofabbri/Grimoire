using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Get_PO_Outbound_RequestType : INotifyPropertyChanged
	{
		private Purchase_OrderObjectType itemField;

		private bool include_Attachment_DataField;

		private bool include_Attachment_DataFieldSpecified;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Purchase_Order_Reference", Order = 0)]
		public Purchase_OrderObjectType Item
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

		[XmlElement(Order = 1)]
		public bool Include_Attachment_Data
		{
			get
			{
				return this.include_Attachment_DataField;
			}
			set
			{
				this.include_Attachment_DataField = value;
				this.RaisePropertyChanged("Include_Attachment_Data");
			}
		}

		[XmlIgnore]
		public bool Include_Attachment_DataSpecified
		{
			get
			{
				return this.include_Attachment_DataFieldSpecified;
			}
			set
			{
				this.include_Attachment_DataFieldSpecified = value;
				this.RaisePropertyChanged("Include_Attachment_DataSpecified");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public string version
		{
			get
			{
				return this.versionField;
			}
			set
			{
				this.versionField = value;
				this.RaisePropertyChanged("version");
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
