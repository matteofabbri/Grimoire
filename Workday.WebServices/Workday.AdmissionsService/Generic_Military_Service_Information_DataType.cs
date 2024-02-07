using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.Admissions
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Generic_Military_Service_Information_DataType : INotifyPropertyChanged
	{
		private Military_Service_ReferenceObjectType military_Service_ReferenceField;

		private Generic_Military_Service_Sub_DataType military_Service_DataField;

		private bool deleteField;

		private bool deleteFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Military_Service_ReferenceObjectType Military_Service_Reference
		{
			get
			{
				return this.military_Service_ReferenceField;
			}
			set
			{
				this.military_Service_ReferenceField = value;
				this.RaisePropertyChanged("Military_Service_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Generic_Military_Service_Sub_DataType Military_Service_Data
		{
			get
			{
				return this.military_Service_DataField;
			}
			set
			{
				this.military_Service_DataField = value;
				this.RaisePropertyChanged("Military_Service_Data");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
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
