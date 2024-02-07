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
	public class Facilities_and_Admin_Object_Class_MappingType : INotifyPropertyChanged
	{
		private Facilities_and_Admin_Object_Class_MappingObjectType facilities_and_Admin_Object_Class_Mapping_ReferenceField;

		private Facilities_and_Administration_Object_Class_Mapping_DataType[] facilities_and_Administration_Object_Class_Mapping_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Facilities_and_Admin_Object_Class_MappingObjectType Facilities_and_Admin_Object_Class_Mapping_Reference
		{
			get
			{
				return this.facilities_and_Admin_Object_Class_Mapping_ReferenceField;
			}
			set
			{
				this.facilities_and_Admin_Object_Class_Mapping_ReferenceField = value;
				this.RaisePropertyChanged("Facilities_and_Admin_Object_Class_Mapping_Reference");
			}
		}

		[XmlElement("Facilities_and_Administration_Object_Class_Mapping_Data", Order = 1)]
		public Facilities_and_Administration_Object_Class_Mapping_DataType[] Facilities_and_Administration_Object_Class_Mapping_Data
		{
			get
			{
				return this.facilities_and_Administration_Object_Class_Mapping_DataField;
			}
			set
			{
				this.facilities_and_Administration_Object_Class_Mapping_DataField = value;
				this.RaisePropertyChanged("Facilities_and_Administration_Object_Class_Mapping_Data");
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
