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
	public class Travel_Profile_Request_ReferencesType : INotifyPropertyChanged
	{
		private Unique_IdentifierObjectType[] travel_Profile_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Travel_Profile_Reference", Order = 0)]
		public Unique_IdentifierObjectType[] Travel_Profile_Reference
		{
			get
			{
				return this.travel_Profile_ReferenceField;
			}
			set
			{
				this.travel_Profile_ReferenceField = value;
				this.RaisePropertyChanged("Travel_Profile_Reference");
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
