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
	public class Custom_List_Request_ReferencesType : INotifyPropertyChanged
	{
		private Custom_ListObjectType[] custom_List_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Custom_List_Reference", Order = 0)]
		public Custom_ListObjectType[] Custom_List_Reference
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
