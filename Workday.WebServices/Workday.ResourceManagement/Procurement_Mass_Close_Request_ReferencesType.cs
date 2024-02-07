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
	public class Procurement_Mass_Close_Request_ReferencesType : INotifyPropertyChanged
	{
		private Procurement_Mass_CloseObjectType[] procurement_Mass_Close_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Procurement_Mass_Close_Reference", Order = 0)]
		public Procurement_Mass_CloseObjectType[] Procurement_Mass_Close_Reference
		{
			get
			{
				return this.procurement_Mass_Close_ReferenceField;
			}
			set
			{
				this.procurement_Mass_Close_ReferenceField = value;
				this.RaisePropertyChanged("Procurement_Mass_Close_Reference");
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
