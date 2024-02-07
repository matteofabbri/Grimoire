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
	public class Translated_Value_for_Instance_DataType : INotifyPropertyChanged
	{
		private InstanceObjectType instance_ReferenceField;

		private string base_ValueField;

		private string translated_ValueField;

		private string rich_Base_ValueField;

		private string translated_Rich_ValueField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public InstanceObjectType Instance_Reference
		{
			get
			{
				return this.instance_ReferenceField;
			}
			set
			{
				this.instance_ReferenceField = value;
				this.RaisePropertyChanged("Instance_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public string Base_Value
		{
			get
			{
				return this.base_ValueField;
			}
			set
			{
				this.base_ValueField = value;
				this.RaisePropertyChanged("Base_Value");
			}
		}

		[XmlElement(Order = 2)]
		public string Translated_Value
		{
			get
			{
				return this.translated_ValueField;
			}
			set
			{
				this.translated_ValueField = value;
				this.RaisePropertyChanged("Translated_Value");
			}
		}

		[XmlElement(Order = 3)]
		public string Rich_Base_Value
		{
			get
			{
				return this.rich_Base_ValueField;
			}
			set
			{
				this.rich_Base_ValueField = value;
				this.RaisePropertyChanged("Rich_Base_Value");
			}
		}

		[XmlElement(Order = 4)]
		public string Translated_Rich_Value
		{
			get
			{
				return this.translated_Rich_ValueField;
			}
			set
			{
				this.translated_Rich_ValueField = value;
				this.RaisePropertyChanged("Translated_Rich_Value");
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
