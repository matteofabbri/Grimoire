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
	public class Certification_IssuerType : INotifyPropertyChanged
	{
		private Certification_IssuerObjectType certification_Issuer_ReferenceField;

		private Certification_Issuer_DataType certification_Issuer_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Certification_IssuerObjectType Certification_Issuer_Reference
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

		[XmlElement(Order = 1)]
		public Certification_Issuer_DataType Certification_Issuer_Data
		{
			get
			{
				return this.certification_Issuer_DataField;
			}
			set
			{
				this.certification_Issuer_DataField = value;
				this.RaisePropertyChanged("Certification_Issuer_Data");
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
