using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Advanced_Ship_Notice_Request_ReferencesType : INotifyPropertyChanged
	{
		private Advanced_Ship_NoticeObjectType[] advanced_Ship_Notice_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Advanced_Ship_Notice_Reference", Order = 0)]
		public Advanced_Ship_NoticeObjectType[] Advanced_Ship_Notice_Reference
		{
			get
			{
				return this.advanced_Ship_Notice_ReferenceField;
			}
			set
			{
				this.advanced_Ship_Notice_ReferenceField = value;
				this.RaisePropertyChanged("Advanced_Ship_Notice_Reference");
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
