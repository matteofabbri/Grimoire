using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Object_Class_SetType : INotifyPropertyChanged
	{
		private Object_Class_SetObjectType object_Class_Set_ReferenceField;

		private Object_Class_Set_DataType[] object_Class_Set_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
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

		[XmlElement("Object_Class_Set_Data", Order = 1)]
		public Object_Class_Set_DataType[] Object_Class_Set_Data
		{
			get
			{
				return this.object_Class_Set_DataField;
			}
			set
			{
				this.object_Class_Set_DataField = value;
				this.RaisePropertyChanged("Object_Class_Set_Data");
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
