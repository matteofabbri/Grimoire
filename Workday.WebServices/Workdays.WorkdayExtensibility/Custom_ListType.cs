using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.WorkdayExtensibility
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Custom_ListType : INotifyPropertyChanged
	{
		private Custom_ListObjectType custom_List_ReferenceField;

		private Custom_List_DataType[] custom_List_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Custom_ListObjectType Custom_List_Reference
		{
			get
			{
				return this.custom_List_ReferenceField;
			}
			set
			{
				this.custom_List_ReferenceField = value;
				this.RaisePropertyChanged("Custom_List_Reference");
			}
		}

		[XmlElement("Custom_List_Data", Order = 1)]
		public Custom_List_DataType[] Custom_List_Data
		{
			get
			{
				return this.custom_List_DataField;
			}
			set
			{
				this.custom_List_DataField = value;
				this.RaisePropertyChanged("Custom_List_Data");
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
