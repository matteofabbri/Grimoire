using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Put_Credit_Card_Authorization_RequestType : INotifyPropertyChanged
	{
		private Unique_IdentifierObjectType credit_Card_Authorization_ReferenceField;

		private Credit_Card_Authorization_DataType credit_Card_Authorization_DataField;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Unique_IdentifierObjectType Credit_Card_Authorization_Reference
		{
			get
			{
				return this.credit_Card_Authorization_ReferenceField;
			}
			set
			{
				this.credit_Card_Authorization_ReferenceField = value;
				this.RaisePropertyChanged("Credit_Card_Authorization_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Credit_Card_Authorization_DataType Credit_Card_Authorization_Data
		{
			get
			{
				return this.credit_Card_Authorization_DataField;
			}
			set
			{
				this.credit_Card_Authorization_DataField = value;
				this.RaisePropertyChanged("Credit_Card_Authorization_Data");
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
