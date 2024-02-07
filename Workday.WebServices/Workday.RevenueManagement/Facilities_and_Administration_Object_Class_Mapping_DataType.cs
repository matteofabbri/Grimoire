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
	public class Facilities_and_Administration_Object_Class_Mapping_DataType : INotifyPropertyChanged
	{
		private string facilities_and_Administration_Object_Class_Mapping_Reference_IDField;

		private Object_Class_SetObjectType object_Class_Set_ReferenceField;

		private Accounting_Worktag_TypeObjectType exception_Worktag_ReferenceField;

		private Facilities_and_Administration_Object_Class_Mapping_Rule_DataType[] facilities_and_Administration_Object_Class_Mapping_Rule_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Facilities_and_Administration_Object_Class_Mapping_Reference_ID
		{
			get
			{
				return this.facilities_and_Administration_Object_Class_Mapping_Reference_IDField;
			}
			set
			{
				this.facilities_and_Administration_Object_Class_Mapping_Reference_IDField = value;
				this.RaisePropertyChanged("Facilities_and_Administration_Object_Class_Mapping_Reference_ID");
			}
		}

		[XmlElement(Order = 1)]
		public Object_Class_SetObjectType Object_Class_Set_Reference
		{
			get
			{
				return this.object_Class_Set_ReferenceField;
			}
			set
			{
				this.object_Class_Set_ReferenceField = value;
				this.RaisePropertyChanged("Object_Class_Set_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public Accounting_Worktag_TypeObjectType Exception_Worktag_Reference
		{
			get
			{
				return this.exception_Worktag_ReferenceField;
			}
			set
			{
				this.exception_Worktag_ReferenceField = value;
				this.RaisePropertyChanged("Exception_Worktag_Reference");
			}
		}

		[XmlElement("Facilities_and_Administration_Object_Class_Mapping_Rule_Data", Order = 3)]
		public Facilities_and_Administration_Object_Class_Mapping_Rule_DataType[] Facilities_and_Administration_Object_Class_Mapping_Rule_Data
		{
			get
			{
				return this.facilities_and_Administration_Object_Class_Mapping_Rule_DataField;
			}
			set
			{
				this.facilities_and_Administration_Object_Class_Mapping_Rule_DataField = value;
				this.RaisePropertyChanged("Facilities_and_Administration_Object_Class_Mapping_Rule_Data");
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
