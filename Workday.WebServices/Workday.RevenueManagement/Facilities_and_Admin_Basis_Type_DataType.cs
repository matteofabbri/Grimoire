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
	public class Facilities_and_Admin_Basis_Type_DataType : INotifyPropertyChanged
	{
		private string facilities_and_Administration_Basis_Type_Reference_IDField;

		private string facilities_and_Administration_Basis_Type_NameField;

		private Object_Class_SetObjectType object_Class_Set_ReferenceField;

		private Object_ClassObjectType[] object_Class_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Facilities_and_Administration_Basis_Type_Reference_ID
		{
			get
			{
				return this.facilities_and_Administration_Basis_Type_Reference_IDField;
			}
			set
			{
				this.facilities_and_Administration_Basis_Type_Reference_IDField = value;
				this.RaisePropertyChanged("Facilities_and_Administration_Basis_Type_Reference_ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Facilities_and_Administration_Basis_Type_Name
		{
			get
			{
				return this.facilities_and_Administration_Basis_Type_NameField;
			}
			set
			{
				this.facilities_and_Administration_Basis_Type_NameField = value;
				this.RaisePropertyChanged("Facilities_and_Administration_Basis_Type_Name");
			}
		}

		[XmlElement(Order = 2)]
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

		[XmlElement("Object_Class_Reference", Order = 3)]
		public Object_ClassObjectType[] Object_Class_Reference
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
