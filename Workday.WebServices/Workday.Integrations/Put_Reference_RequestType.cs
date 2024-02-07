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
	public class Put_Reference_RequestType : INotifyPropertyChanged
	{
		private Reference_IndexObjectType reference_ID_ReferenceField;

		private Reference_ID_DataType reference_ID_DataField;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Reference_IndexObjectType Reference_ID_Reference
		{
			get
			{
				return this.reference_ID_ReferenceField;
			}
			set
			{
				this.reference_ID_ReferenceField = value;
				this.RaisePropertyChanged("Reference_ID_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Reference_ID_DataType Reference_ID_Data
		{
			get
			{
				return this.reference_ID_DataField;
			}
			set
			{
				this.reference_ID_DataField = value;
				this.RaisePropertyChanged("Reference_ID_Data");
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
