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
	public class Cancel_Advanced_Ship_Notice_RequestType : INotifyPropertyChanged
	{
		private Advanced_Ship_NoticeObjectType advanced_Ship_Notice_ReferenceField;

		private Cancel_Advanced_Ship_Notice_DataType advanced_Ship_Notice_DataField;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Advanced_Ship_NoticeObjectType Advanced_Ship_Notice_Reference
		{
			get
			{
				return this.advanced_Ship_Notice_ReferenceField;
			}
			set
			{
				this.advanced_Ship_Notice_ReferenceField = value;
				this.RaisePropertyChanged("Advanced_Ship_Notice_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Cancel_Advanced_Ship_Notice_DataType Advanced_Ship_Notice_Data
		{
			get
			{
				return this.advanced_Ship_Notice_DataField;
			}
			set
			{
				this.advanced_Ship_Notice_DataField = value;
				this.RaisePropertyChanged("Advanced_Ship_Notice_Data");
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
