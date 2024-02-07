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
	public class Certification_Issuer_Request_ReferencesType : INotifyPropertyChanged
	{
		private Certification_IssuerObjectType[] certification_Issuer_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Certification_Issuer_Reference", Order = 0)]
		public Certification_IssuerObjectType[] Certification_Issuer_Reference
		{
			get
			{
				return this.certification_Issuer_ReferenceField;
			}
			set
			{
				this.certification_Issuer_ReferenceField = value;
				this.RaisePropertyChanged("Certification_Issuer_Reference");
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
