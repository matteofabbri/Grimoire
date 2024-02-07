using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.HumanResources
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class LGBT_Identification_Request_ReferencesType : INotifyPropertyChanged
	{
		private LGBT_IdentificationObjectType[] lGBT_Identification_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("LGBT_Identification_Reference", Order = 0)]
		public LGBT_IdentificationObjectType[] LGBT_Identification_Reference
		{
			get
			{
				return this.lGBT_Identification_ReferenceField;
			}
			set
			{
				this.lGBT_Identification_ReferenceField = value;
				this.RaisePropertyChanged("LGBT_Identification_Reference");
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
