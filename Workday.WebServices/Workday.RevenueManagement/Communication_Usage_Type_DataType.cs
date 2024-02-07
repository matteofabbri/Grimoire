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
	public class Communication_Usage_Type_DataType : INotifyPropertyChanged
	{
		private Communication_Usage_TypeObjectType type_ReferenceField;

		private bool primaryField;

		private bool primaryFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Communication_Usage_TypeObjectType Type_Reference
		{
			get
			{
				return this.type_ReferenceField;
			}
			set
			{
				this.type_ReferenceField = value;
				this.RaisePropertyChanged("Type_Reference");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public bool Primary
		{
			get
			{
				return this.primaryField;
			}
			set
			{
				this.primaryField = value;
				this.RaisePropertyChanged("Primary");
			}
		}

		[XmlIgnore]
		public bool PrimarySpecified
		{
			get
			{
				return this.primaryFieldSpecified;
			}
			set
			{
				this.primaryFieldSpecified = value;
				this.RaisePropertyChanged("PrimarySpecified");
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
