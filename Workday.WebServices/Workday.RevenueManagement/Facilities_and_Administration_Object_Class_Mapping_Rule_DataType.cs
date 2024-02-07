using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Facilities_and_Administration_Object_Class_Mapping_Rule_DataType : INotifyPropertyChanged
	{
		private Object_ClassObjectType object_Class_ReferenceField;

		private bool default_Object_ClassField;

		private bool default_Object_ClassFieldSpecified;

		private Facilities_and_Administration_Object_Class_Mapping_Rule_Line_DataType[] facilities_and_Administration_Object_Class_Mapping_Rule_Line_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Object_ClassObjectType Object_Class_Reference
		{
			get
			{
				return this.object_Class_ReferenceField;
			}
			set
			{
				this.object_Class_ReferenceField = value;
				this.RaisePropertyChanged("Object_Class_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public bool Default_Object_Class
		{
			get
			{
				return this.default_Object_ClassField;
			}
			set
			{
				this.default_Object_ClassField = value;
				this.RaisePropertyChanged("Default_Object_Class");
			}
		}

		[XmlIgnore]
		public bool Default_Object_ClassSpecified
		{
			get
			{
				return this.default_Object_ClassFieldSpecified;
			}
			set
			{
				this.default_Object_ClassFieldSpecified = value;
				this.RaisePropertyChanged("Default_Object_ClassSpecified");
			}
		}

		[XmlElement("Facilities_and_Administration_Object_Class_Mapping_Rule_Line_Data", Order = 2)]
		public Facilities_and_Administration_Object_Class_Mapping_Rule_Line_DataType[] Facilities_and_Administration_Object_Class_Mapping_Rule_Line_Data
		{
			get
			{
				return this.facilities_and_Administration_Object_Class_Mapping_Rule_Line_DataField;
			}
			set
			{
				this.facilities_and_Administration_Object_Class_Mapping_Rule_Line_DataField = value;
				this.RaisePropertyChanged("Facilities_and_Administration_Object_Class_Mapping_Rule_Line_Data");
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
