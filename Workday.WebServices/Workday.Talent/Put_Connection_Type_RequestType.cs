using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.Talent
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Put_Connection_Type_RequestType : INotifyPropertyChanged
	{
		private Mentor_TypeObjectType connection_Type_ReferenceField;

		private Connection_Type_DataType connection_Type_DataField;

		private bool deleteField;

		private bool deleteFieldSpecified;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Mentor_TypeObjectType Connection_Type_Reference
		{
			get
			{
				return this.connection_Type_ReferenceField;
			}
			set
			{
				this.connection_Type_ReferenceField = value;
				this.RaisePropertyChanged("Connection_Type_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Connection_Type_DataType Connection_Type_Data
		{
			get
			{
				return this.connection_Type_DataField;
			}
			set
			{
				this.connection_Type_DataField = value;
				this.RaisePropertyChanged("Connection_Type_Data");
			}
		}

		[XmlElement(Order = 2)]
		public bool Delete
		{
			get
			{
				return this.deleteField;
			}
			set
			{
				this.deleteField = value;
				this.RaisePropertyChanged("Delete");
			}
		}

		[XmlIgnore]
		public bool DeleteSpecified
		{
			get
			{
				return this.deleteFieldSpecified;
			}
			set
			{
				this.deleteFieldSpecified = value;
				this.RaisePropertyChanged("DeleteSpecified");
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
