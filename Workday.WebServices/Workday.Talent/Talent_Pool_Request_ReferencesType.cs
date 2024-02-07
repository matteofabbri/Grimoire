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
	public class Talent_Pool_Request_ReferencesType : INotifyPropertyChanged
	{
		private Talent_Management_PoolObjectType[] static_Talent_Pool_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Static_Talent_Pool_Reference", Order = 0)]
		public Talent_Management_PoolObjectType[] Static_Talent_Pool_Reference
		{
			get
			{
				return this.static_Talent_Pool_ReferenceField;
			}
			set
			{
				this.static_Talent_Pool_ReferenceField = value;
				this.RaisePropertyChanged("Static_Talent_Pool_Reference");
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
