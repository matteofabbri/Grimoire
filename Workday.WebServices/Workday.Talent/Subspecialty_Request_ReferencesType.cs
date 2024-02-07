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
	public class Subspecialty_Request_ReferencesType : INotifyPropertyChanged
	{
		private Specialty_ChildObjectType[] subspecialty_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Subspecialty_Reference", Order = 0)]
		public Specialty_ChildObjectType[] Subspecialty_Reference
		{
			get
			{
				return this.subspecialty_ReferenceField;
			}
			set
			{
				this.subspecialty_ReferenceField = value;
				this.RaisePropertyChanged("Subspecialty_Reference");
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
