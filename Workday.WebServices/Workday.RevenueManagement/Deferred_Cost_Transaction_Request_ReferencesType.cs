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
	public class Deferred_Cost_Transaction_Request_ReferencesType : INotifyPropertyChanged
	{
		private Deferred_Cost_AbstractObjectType[] deferred_Cost_Transaction_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Deferred_Cost_Transaction_Reference", Order = 0)]
		public Deferred_Cost_AbstractObjectType[] Deferred_Cost_Transaction_Reference
		{
			get
			{
				return this.deferred_Cost_Transaction_ReferenceField;
			}
			set
			{
				this.deferred_Cost_Transaction_ReferenceField = value;
				this.RaisePropertyChanged("Deferred_Cost_Transaction_Reference");
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
