using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Talent
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Succession_Pool_Request_ReferencesType : INotifyPropertyChanged
	{
		private Succession_PoolObjectType[] succession_Pool_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Succession_Pool_Reference", Order = 0)]
		public Succession_PoolObjectType[] Succession_Pool_Reference
		{
			get
			{
				return this.succession_Pool_ReferenceField;
			}
			set
			{
				this.succession_Pool_ReferenceField = value;
				this.RaisePropertyChanged("Succession_Pool_Reference");
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
