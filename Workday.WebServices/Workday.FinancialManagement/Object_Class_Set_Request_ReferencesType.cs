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
	public class Object_Class_Set_Request_ReferencesType : INotifyPropertyChanged
	{
		private Object_Class_SetObjectType[] object_Class_Set_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Object_Class_Set_Reference", Order = 0)]
		public Object_Class_SetObjectType[] Object_Class_Set_Reference
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
