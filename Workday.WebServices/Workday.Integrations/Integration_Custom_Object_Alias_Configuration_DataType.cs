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
	public class Integration_Custom_Object_Alias_Configuration_DataType : INotifyPropertyChanged
	{
		private Integration_Document_FieldObjectType custom_Object_Alias_ReferenceField;

		private Custom_ObjectObjectType custom_Object_ReferenceField;

		private bool capture_Multiple_ValuesField;

		private bool capture_Multiple_ValuesFieldSpecified;

		private string custom_Object_REST_URLField;

		private string multiple_Custom_Object_REST_URLField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Integration_Document_FieldObjectType Custom_Object_Alias_Reference
		{
			get
			{
				return this.custom_Object_Alias_ReferenceField;
			}
			set
			{
				this.custom_Object_Alias_ReferenceField = value;
				this.RaisePropertyChanged("Custom_Object_Alias_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Custom_ObjectObjectType Custom_Object_Reference
		{
			get
			{
				return this.custom_Object_ReferenceField;
			}
			set
			{
				this.custom_Object_ReferenceField = value;
				this.RaisePropertyChanged("Custom_Object_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public bool Capture_Multiple_Values
		{
			get
			{
				return this.capture_Multiple_ValuesField;
			}
			set
			{
				this.capture_Multiple_ValuesField = value;
				this.RaisePropertyChanged("Capture_Multiple_Values");
			}
		}

		[XmlIgnore]
		public bool Capture_Multiple_ValuesSpecified
		{
			get
			{
				return this.capture_Multiple_ValuesFieldSpecified;
			}
			set
			{
				this.capture_Multiple_ValuesFieldSpecified = value;
				this.RaisePropertyChanged("Capture_Multiple_ValuesSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public string Custom_Object_REST_URL
		{
			get
			{
				return this.custom_Object_REST_URLField;
			}
			set
			{
				this.custom_Object_REST_URLField = value;
				this.RaisePropertyChanged("Custom_Object_REST_URL");
			}
		}

		[XmlElement(Order = 4)]
		public string Multiple_Custom_Object_REST_URL
		{
			get
			{
				return this.multiple_Custom_Object_REST_URLField;
			}
			set
			{
				this.multiple_Custom_Object_REST_URLField = value;
				this.RaisePropertyChanged("Multiple_Custom_Object_REST_URL");
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
