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
	public class Specialty_Request_ReferencesType : INotifyPropertyChanged
	{
		private Specialty_ParentObjectType[] specialty_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Specialty_Reference", Order = 0)]
		public Specialty_ParentObjectType[] Specialty_Reference
		{
			get
			{
				return this.specialty_ReferenceField;
			}
			set
			{
				this.specialty_ReferenceField = value;
				this.RaisePropertyChanged("Specialty_Reference");
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
