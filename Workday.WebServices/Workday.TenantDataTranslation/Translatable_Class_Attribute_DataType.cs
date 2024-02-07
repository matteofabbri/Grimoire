using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.TenantDataTranslation
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Translatable_Class_Attribute_DataType : INotifyPropertyChanged
	{
		private User_LanguageObjectType user_Language_ReferenceField;

		private string class_NameField;

		private Attribute_ReferenceType attribute_ReferenceField;

		private Translated_Value_for_Instance_DataType[] translated_Value_for_Instance_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public User_LanguageObjectType User_Language_Reference
		{
			get
			{
				return this.user_Language_ReferenceField;
			}
			set
			{
				this.user_Language_ReferenceField = value;
				this.RaisePropertyChanged("User_Language_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public string Class_Name
		{
			get
			{
				return this.class_NameField;
			}
			set
			{
				this.class_NameField = value;
				this.RaisePropertyChanged("Class_Name");
			}
		}

		[XmlElement(Order = 2)]
		public Attribute_ReferenceType Attribute_Reference
		{
			get
			{
				return this.attribute_ReferenceField;
			}
			set
			{
				this.attribute_ReferenceField = value;
				this.RaisePropertyChanged("Attribute_Reference");
			}
		}

		[XmlElement("Translated_Value_for_Instance_Data", Order = 3)]
		public Translated_Value_for_Instance_DataType[] Translated_Value_for_Instance_Data
		{
			get
			{
				return this.translated_Value_for_Instance_DataField;
			}
			set
			{
				this.translated_Value_for_Instance_DataField = value;
				this.RaisePropertyChanged("Translated_Value_for_Instance_Data");
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
