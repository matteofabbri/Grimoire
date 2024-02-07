using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.StudentRecruiting
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Recruiting_Region_Request_ReferencesType : INotifyPropertyChanged
	{
		private RegionObjectType[] recruiting_Region_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Recruiting_Region_Reference", Order = 0)]
		public RegionObjectType[] Recruiting_Region_Reference
		{
			get
			{
				return this.recruiting_Region_ReferenceField;
			}
			set
			{
				this.recruiting_Region_ReferenceField = value;
				this.RaisePropertyChanged("Recruiting_Region_Reference");
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
